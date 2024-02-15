using System;
using System.Linq;
using System.Windows.Forms;

namespace BookKeeper
{
    public partial class ViewLoan : UserControl, IViewer
    {
        public event EventHandler Cancelled;
        public event EventHandler GrabUserId;
        public event EventHandler GrabBookId;
        public event EventHandler<IdEventArgs> UserOpened;
        public event EventHandler<IdEventArgs> BookOpened;
        public event EventHandler RecordDeleted;

        UnitOfWork UnitOfWork;
        bool _changed;
        private bool _editing;
        public string DisplayName => ModelID == -1 ? "امانت جدید" : "نمایش امانت";
        public int ModelID { get; private set; } = -1;
        bool Changed
        {
            get => _changed;
            set
            {
                _changed = value;
                btnOk.Enabled = value;
            }
        }
        private bool Editing
        {
            get => _editing;
            set
            {
                _editing = value;
                btnPostpone.Visible = btnDelete.Visible = !value;
                btnOk.Visible = btnCancel.Visible = value;
                txtTo.ReadOnly = !value;
            }
        }
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
        private void UnitOfWork_Updated(object sender, EventArgs e)
        {
            if (!Editing) LoadModel(ModelID);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ModelID == -1) return;
            //UnitOfWork.LoanRepository.Delete(ModelID);
            RecordDeleted?.Invoke(this, EventArgs.Empty);

        }
        private void txtUserCode_DoubleClick(object sender, EventArgs e)
        {
            if (ModelID == -1) return;
            UserOpened?.Invoke(this, new IdEventArgs()
            {
                Id = UnitOfWork.LoanRepository.Get(ModelID).UserId
            });
        }

        private void txtBookCode_DoubleClick(object sender, EventArgs e)
        {
            if (ModelID == -1) return;
            BookOpened?.Invoke(this, new IdEventArgs()
            {
                Id = UnitOfWork.LoanRepository.Get(ModelID).BookId
            });
        }
        private void btnPickUser_Click(object sender, EventArgs e)
        {
            //var args = new IdEventArgs();
            GrabUserId?.Invoke(this, EventArgs.Empty);
            //var id = args.Id;
            //if (id == -1)
            //{
            //    MessageBox.Show(
            //        $"قبل از فشار دادن دکمه از نوار سمت چپ برنامه یک عضو انتخاب کنید",
            //        "خطا",
            //    MessageBoxButtons.OK,
            //    MessageBoxIcon.Warning,
            //    MessageBoxDefaultButton.Button1,
            //    MessageBoxOptions.RtlReading
            //    );
            //    return;
            //}
            //txtUserCode.Text = id.ToString();
        }
        public void FillUserId(int id)
        {
            txtUserCode.Text = id.ToString();
        }
        private void btnPickBook_Click(object sender, EventArgs e)
        {
            //var args = new IdEventArgs();
            GrabBookId?.Invoke(this, EventArgs.Empty);
            //var id = args.Id;
            //if (id == -1)
            //{
            //    MessageBox.Show(
            //        $"قبل از فشار دادن دکمه از نوار سمت چپ برنامه یک کتاب انتخاب کنید",
            //        "خطا",
            //    MessageBoxButtons.OK,
            //    MessageBoxIcon.Warning,
            //    MessageBoxDefaultButton.Button1,
            //    MessageBoxOptions.RtlReading
            //    );
            //}            
        }
        
        public void FillBookId(int id)
        {
            txtBookCode.Text = id.ToString();
        }
        public void LoadModel(int id)
        {
            ModelID = id;
            bool isNull = id == -1;
            bool isNotNull = !isNull;

            Editing = isNull;
            btnOk.Visible = isNull;
            btnDelete.Visible = isNotNull;
            btnPickBook.Visible = btnPickUser.Visible = isNull;
            txtBookCode.ReadOnly = txtUserCode.ReadOnly = txtFrom.ReadOnly = txtTo.ReadOnly = isNotNull;
            btnPostpone.Visible = isNotNull;
            if (id == -1)
            {
                txtFrom.Text = Utilities.ToPersianDate(DateTime.Today);
                txtTo.Text = Utilities.ToPersianDate(DateTime.Today.AddDays(Properties.Settings.Default.LoanKeepingDays));
                txtBookCode.Text = txtUserCode.Text = string.Empty;
            }
            else
            {
                var value = UnitOfWork.LoanRepository.Get(id);
                txtBookCode.Text = value.BookId.ToString();
                txtUserCode.Text = value.UserId.ToString();
                txtFrom.Text = Utilities.ToPersianDate(value.From);
                txtTo.Text = Utilities.ToPersianDate(value.To);
            }
            Changed = false;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBookCode.Text)) Utilities.FieldRequired("کد کتاب");
            else if (string.IsNullOrEmpty(txtUserCode.Text)) Utilities.FieldRequired("کد گیرنده");
            else if (!int.TryParse(txtUserCode.Text, out int userId)) Utilities.FieldInvalid("کد گیرنده", "فیلد نمی تواند شامل چیزی غیر از عدد باشد");
            else if (!int.TryParse(txtBookCode.Text, out int bookId)) Utilities.FieldInvalid("کد کتاب", "فیلد نمی تواند شامل چیزی غیر از عدد باشد");
            else if (!UnitOfWork.UserRepository.Exists(userId)) Utilities.FieldInvalid("کد گیرنده", "هیچ عضوی با این کد وجود ندارد");
            else if (!UnitOfWork.BookRepository.Exists(bookId)) Utilities.FieldInvalid("کد کتاب", "کتابی با این کد موجود نیست");
            else if (!Utilities.FromPersianDate(txtFrom.Text, out var From)) Utilities.FieldInvalid("از تاریخ", "تاریخ نادرست است");
            else if (!Utilities.FromPersianDate(txtTo.Text, out var to)) Utilities.FieldInvalid("تا تاریخ", "تاریخ نادرست است");
            else if (ModelID == -1 && UnitOfWork.LoanRepository.TryGetLoanOfBook(bookId, out _)) Utilities.FieldInvalid("کد کتاب", "کتاب در امانت است");
            else if (ModelID == -1 && UnitOfWork.LoanRepository.GetLoansOfUser(userId).Count() >= 5) Utilities.FieldInvalid("کد گیرنده", "گیرنده 5 کتاب در امانت دارد");
            else if (From > to)
            {
                MessageBox.Show(
                $"تاریخ تحویل نمی تواند قبل از تاریخ دریافت باشد",
                "خطا",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RtlReading
                );
            }
            else
            {
                var model = new Loan
                {
                    BookId = bookId,
                    UserId = userId,
                    From = From,
                    To = to
                };
                if (ModelID == -1)
                {
                    var id = UnitOfWork.LoanRepository.Create(model);
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
                    UnitOfWork.LoanRepository.Extend(ModelID, to);
                    LoadModel(ModelID);

                }
            }
        }
        private void btnPostpone_Click(object sender, EventArgs e)
        {
            Editing = true;
            txtTo.Focus();
        }
        public ViewLoan()
        {
            InitializeComponent();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (ModelID == -1) Cancelled?.Invoke(this, EventArgs.Empty);
            else LoadModel(ModelID);
        }

        public void Initialize(UnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
            unitOfWork.Updated += UnitOfWork_Updated;
        }
    }

}
