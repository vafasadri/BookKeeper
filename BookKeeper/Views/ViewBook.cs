using System;
using System.Windows.Forms;

namespace BookKeeper
{
    public partial class ViewBook : UserControl, IViewer
    {
        public event EventHandler Canceled;
        public event EventHandler RecordDeleted;
        public event EventHandler LoanCreated;
        public event EventHandler<IdEventArgs> LoanOpened;
        private bool _editing;
        private bool _changed = false;
        UnitOfWork UnitOfWork;
        public int ModelID { get; private set; } = -1;
        private bool Editing
        {
            get => _editing;
            set
            {
                _editing = value;
                btnEdit.Visible = !value;
                btnLend.Visible = !value && txtCurrentState.Tag == null;
                btnReturn.Visible = !value && txtCurrentState.Tag != null;
                btnCancel.Visible = btnOk.Visible = value;

                txtName.ReadOnly = txtAuthor.ReadOnly = txtDescription.ReadOnly = !value;
                cmbCategory.Enabled = value;
            }
        }
        private bool Changed
        {
            get => _changed;
            set
            {
                btnOk.Enabled = value;
                _changed = value;
            }
        }
        public string DisplayName
        {
            get
            {
                if (ModelID == -1) return "افزودن کتاب";
                else if (Editing) return "ویرایش کتاب";
                else return "نمایش کتاب";
            }
        }

        public Hash CoverHash { get; private set; }

        public void ViewerClosing(object sender, ViewerClosingEventArgs eventArgs)
        {
            if (Changed)
            {
                eventArgs.Cancel = !Utilities.ConfirmViewClosing();
            }
        }
        private void CommonInput(object sender, EventArgs e)
        {
            Changed = true;
        }

        private void imgCover_DoubleClick(object sender, EventArgs e)
        {
            if (!Editing) return;

            if (dialogOpenCover.ShowDialog() == DialogResult.OK)
            {
                imgCover.ImageLocation = dialogOpenCover.FileName;
                Changed = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Editing = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ModelID == -1) return;
            if (Utilities.ConfirmRecordDeletion("کتاب")) RecordDeleted?.Invoke(this, EventArgs.Empty);
        }
        public void LoadModel(int modelID)
        {
            ModelID = modelID;
            Editing = modelID == -1;
            btnLend.Visible = txtCurrentState.Visible = lblCurrentState.Visible = btnDelete.Visible = modelID != -1;
            lblId.Visible = modelID != -1;
            imgCover.ImageLocation = null;
            if (modelID == -1)
            {
                txtDescription.Text = txtAuthor.Text = txtName.Text = txtCurrentState.Text = string.Empty;
                cmbCategory.SelectedIndex = -1;
                imgCover.ImageLocation = null;
                imgCover.Image = Properties.Resources.BookCoverDefault;
                CoverHash = Hash.Empty;
            }
            else
            {
                var obj = UnitOfWork.BookRepository.Get(modelID);
                CoverHash = obj.CoverHash;
                imgCover.Image = CoverHash == Hash.Empty ?
                    Properties.Resources.BookCoverDefault : UnitOfWork.FileRepository.GetBitmap(CoverHash);
                txtName.Text = obj.Name;
                txtAuthor.Text = obj.Author;
                txtDescription.Text = obj.Description;
                var categoryIndex = cmbCategory.FindString(obj.Category);
                if (categoryIndex == -1) throw new Exception("wtf?");
                cmbCategory.SelectedIndex = categoryIndex;
                lblId.Text = $"کتاب شماره {obj.Id}";
                if (UnitOfWork.LoanRepository.TryGetLoanOfBook(modelID, out var loan))
                {

                    var username = UnitOfWork.UserRepository.Get(loan.UserId).Fullname;
                    txtCurrentState.Text = "امانت: " + username;
                    txtCurrentState.Tag = loan.Id;
                    btnLend.Enabled = false;
                    btnReturn.Visible = true;
                    btnLend.Visible = false;
                }
                else
                {
                    txtCurrentState.Text = "در کتابخانه";
                    txtCurrentState.Tag = null;
                    btnLend.Enabled = true;
                    btnReturn.Visible = false;
                    btnLend.Visible = true;
                }
            }
            Changed = false;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text)) Utilities.FieldRequired("نام کتاب");
            else if (string.IsNullOrWhiteSpace(txtAuthor.Text)) Utilities.FieldRequired("نام نویسنده");
            else if (cmbCategory.SelectedIndex == -1) Utilities.FieldRequired("دسته بندی");
            else
            {
                var model = new Book()
                {
                    Id = ModelID,
                    Name = txtName.Text,
                    Author = txtAuthor.Text,
                    Category = (string)cmbCategory.SelectedValue,
                    Description = txtDescription.Text,
                    CoverHash = imgCover.ImageLocation == null ? CoverHash : UnitOfWork.FileRepository.GetHash(imgCover.ImageLocation)
                };

                if (ModelID == -1)
                {
                    var id = UnitOfWork.BookRepository.Create(model);
                    switch (Properties.Settings.Default.OnRecordCreation)
                    {
                        case 0:
                            LoadModel(id);
                            break;
                        case 1:
                            LoadModel(-1);
                            break;
                        default:
                            throw new Exception();
                    }
                }
                else
                {
                    UnitOfWork.BookRepository.Patch(model);
                    LoadModel(ModelID);
                }
            }
        }
        private void txtCurrentState_DoubleClick(object sender, EventArgs e)
        {
            if (txtCurrentState.Tag == null) return;
            else LoanOpened?.Invoke(sender, new IdEventArgs() { Id = (int)txtCurrentState.Tag });
        }

        private void btnLend_Click(object sender, EventArgs e)
        {
            LoanCreated?.Invoke(this, EventArgs.Empty);
        }
        public ViewBook()
        {
            InitializeComponent();

        }
        private void CategoryRepository_Changed(object sender, EventArgs e) => cmbCategory.DataSource = UnitOfWork.CategoryRepository.GetAll();

        private void UnitOfWork_Updated(object sender, EventArgs e)
        {
            if (!Editing) LoadModel(ModelID);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (ModelID == -1)
            {
                Canceled?.Invoke(this, EventArgs.Empty);
            }
            else LoadModel(ModelID);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (txtCurrentState.Tag == null) return;
            var id = (int)txtCurrentState.Tag;

            UnitOfWork.LoanRepository.Delete(id);
        }

        private void btnClearPFP_Click(object sender, EventArgs e)
        {
            if (CoverHash == Hash.Empty && imgCover.ImageLocation == null) return;

            Editing = true;
            imgCover.ImageLocation = null;
            imgCover.Image = Properties.Resources.PFPDefault;
            CoverHash = Hash.Empty;
            Changed = true;

        }

        public void Initialize(UnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
            unitOfWork.Updated += UnitOfWork_Updated;
            unitOfWork.CategoryRepository.Changed += CategoryRepository_Changed;
            CategoryRepository_Changed(null, null);
        }
    }
}
