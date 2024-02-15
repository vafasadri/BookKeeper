using System;
using System.Linq;
using System.Windows.Forms;
namespace BookKeeper
{
    public partial class ViewUser : UserControl, IViewer
    {
        public event EventHandler Cancelled;
        public event EventHandler<IdEventArgs> LoanOpened;
        public event EventHandler RecordDeleted;
        public event EventHandler LoanCreated;

        UnitOfWork UnitOfWork;
        private bool _editing;
        private bool _changed = false;
        public Hash PFPHash { get; set; } = Hash.Empty;
        public int ModelID { get; private set; } = -1;
        private bool Editing
        {
            get => _editing;
            set
            {
                _editing = value;
                btnEdit.Visible = !value;
                btnCancel.Visible = value;
                txtFullname.ReadOnly = txtFatherName.ReadOnly = txtNationalID.ReadOnly = txtPhoneNumber.ReadOnly = !value;
                cmbGrade.Enabled = cmbMajor.Enabled = value;
            }
        }
        bool Changed
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
                if (ModelID == -1) return "عضو جدید";
                else if (Editing) return "ویرایش عضو";
                else return "نمایش عضو";
            }
        }

        void Common_Input(object sender, EventArgs args)
        {
            Changed = true;
        }

        private void UnitOfWork_Updated(object sender, EventArgs e)
        {
            if (Editing)
            {
                RefreshLoans();
            }
            else LoadModel(ModelID);
        }

        private void picPFP_DoubleClick(object sender, EventArgs e)
        {
            if (!Editing) return;
            if (dialogOpenPFP.ShowDialog() == DialogResult.OK)
            {
                imgPFP.ImageLocation = dialogOpenPFP.FileName;
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
            if (Utilities.ConfirmRecordDeletion("عضو")) RecordDeleted?.Invoke(this, EventArgs.Empty);
        }
        public void ViewerClosing(object sender, ViewerClosingEventArgs args)
        {
            if (!Changed) return;
            args.Cancel = !Utilities.ConfirmViewClosing();
        }
        private void btnClearPFP_Click(object sender, EventArgs e)
        {
            if (PFPHash == Hash.Empty && imgPFP.ImageLocation == null) return;

            Editing = true;
            imgPFP.ImageLocation = null;
            imgPFP.Image = Properties.Resources.BookCoverDefault;
            PFPHash = Hash.Empty;
            Changed = true;

        }
        public void LoadModel(int modelID)
        {
            ModelID = modelID;
            Editing = modelID == -1;
            btnDelete.Visible = gridLoans.Visible = lblLoans.Visible = modelID != -1;
            lblId.Visible = modelID != -1;
            imgPFP.ImageLocation = null;
            if (modelID == -1)
            {
                txtPhoneNumber.Text = txtFullname.Text = txtFatherName.Text = txtNationalID.Text = string.Empty;
                cmbMajor.SelectedIndex = cmbGrade.SelectedIndex = -1;
                imgPFP.Image = Properties.Resources.PFPDefault;
                PFPHash = Hash.Empty;
            }
            else
            {
                var obj = UnitOfWork.UserRepository.Get(modelID);
                PFPHash = obj.PFPHash;
                if (obj.PFPHash == Hash.Empty) imgPFP.Image = Properties.Resources.PFPDefault;
                else imgPFP.Image = UnitOfWork.FileRepository.GetBitmap(obj.PFPHash);
                txtPhoneNumber.Text = obj.PhoneNumber;
                txtFullname.Text = obj.Fullname;
                txtFatherName.Text = obj.FatherName;
                txtNationalID.Text = obj.NationalId;
                cmbMajor.SelectedIndex = (int)obj.Major;
                cmbGrade.SelectedIndex = (int)obj.Grade;
                lblId.Text = $"عضو شماره {obj.Id}";
            }
            RefreshLoans();
            Changed = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFatherName.Text)) Utilities.FieldRequired("نام پدر");

            //else if (string.IsNullOrEmpty(txtNationalID.Text)) Utilities.FieldRequired("کد ملی");
            else if (string.IsNullOrWhiteSpace(txtFullname.Text)) Utilities.FieldRequired("نام");
            else if (txtPhoneNumber.Text.Any(n => !char.IsDigit(n))) Utilities.FieldInvalid("تلفن", "فیلد نمی تواند شامل چیزی غیر از عدد باشد");
            else if (txtNationalID.Text.Any(n => !char.IsDigit(n))) Utilities.FieldInvalid("کد ملی", "فیلد نمی تواند شامل چیزی غیر از عدد باشد");
            else if (cmbMajor.SelectedIndex == -1) Utilities.FieldRequired("رشته");
            else if (cmbGrade.SelectedIndex == -1) Utilities.FieldRequired("پایه");
            else
            {
                var model = new User()
                {
                    Id = ModelID,
                    PhoneNumber = txtPhoneNumber.Text,
                    Fullname = txtFullname.Text,
                    FatherName = txtFatherName.Text,
                    NationalId = txtNationalID.Text,
                    PFPHash = imgPFP.ImageLocation != null ? UnitOfWork.FileRepository.GetHash(imgPFP.ImageLocation) : PFPHash,
                    Grade = (Grade)cmbGrade.SelectedIndex,
                    Major = (Major)cmbMajor.SelectedIndex
                };
                if (ModelID == -1)
                {
                    var id = UnitOfWork.UserRepository.Create(model);
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
                    UnitOfWork.UserRepository.Patch(model);
                    LoadModel(ModelID);
                }
            }
        }
        private void RefreshLoans()
        {
            gridLoans.Rows.Clear();
            if (ModelID == -1) return;
            var loans = UnitOfWork.LoanRepository.GetLoansOfUser(ModelID);
            foreach (var item in loans)
            {
                var row = new DataGridViewRow();
                row.Cells.AddRange(
                    new DataGridViewTextBoxCell() { Value = UnitOfWork.BookRepository.Get(item.BookId).Name },
                    new DataGridViewTextBoxCell() { Value = Utilities.ToPersianDate(item.From) },
                    new DataGridViewTextBoxCell() { Value = Utilities.ToPersianDate(item.To) },
                    new DataGridViewImageCell()
                    );
                row.Tag = item.Id;
                gridLoans.Rows.Add(row);
            }
        }
        private void gridLoans_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var id = e.RowIndex < gridLoans.RowCount - 1 ? (int)gridLoans.Rows[e.RowIndex].Tag : -1;
            if (id == -1)
            {
                LoanCreated?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                if (e.ColumnIndex == 3)
                {
                    UnitOfWork.LoanRepository.Delete(id);

                }
                else LoanOpened?.Invoke(this, new IdEventArgs() { Id = id });
            }
        }
        public ViewUser()
        {
            InitializeComponent();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (ModelID == -1)
            {
                Cancelled?.Invoke(this, EventArgs.Empty);

            }
            else
            {
                LoadModel(ModelID);
            }
        }

        public void Initialize(UnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
            UnitOfWork.Updated += UnitOfWork_Updated;
        }
    }
}
