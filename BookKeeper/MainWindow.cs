using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BookKeeper
{
    enum GrabberState
    {
        None,
        User,
        Book
    }
    public partial class MainWindow : Form
    {
        readonly UnitOfWork UnitOfWork;
        readonly SettingsPage settingsPage;
        GrabberState grabberState = GrabberState.None;
        GrabberState GrabberState
        {
            get => grabberState;
            set
            {
                grabberState = value;
                listUsers.Cursor = value == GrabberState.User ? Cursors.Hand : Cursors.Default;
                listBooks.Cursor = value == GrabberState.Book ? Cursors.Hand : Cursors.Default;
            }
        }
        IViewer ActiveViewer => grpComponent.Controls.Cast<Control>().Where(n => n.Visible).OfType<IViewer>().SingleOrDefault();
        IEnumerable<IViewer> Viewers => grpComponent.Controls.Cast<Control>().OfType<IViewer>();
        private void btnAddBook_Click(object sender, EventArgs e) => ShowBook(-1);
        private void btnAddUser_Click(object sender, EventArgs e) => ShowUser(-1);
        private void btnLend_Click(object sender, EventArgs e) => ShowLoan(-1);
        private void btnDashboard_Click(object sender, EventArgs e) => ShowDashboard();
        internal void ShowUser(int id) => TryChangeViewer(ViewUser, id, null);
        internal void ShowBook(int id) => TryChangeViewer(ViewBook, id, null);
        internal void ShowLoan(int id) => TryChangeViewer(ViewLoan, id, null);
        internal void ShowDashboard() => TryChangeViewer(Dashboard, -1, null);
        private void searchUsers_Search(object sender, EventArgs e) => RefreshUsers();
        private void searchBooks_Search(object sender, EventArgs e) => RefreshBooks();
        private void searchDeliveries_Search(object sender, EventArgs e) => RefreshDeliveries();
        #region ViewerEvents
        private void ViewUser_LoanOpened(object sender, IdEventArgs e) => ShowLoan(e.Id);
        private void ViewLoan_RecordDeleted(object sender, EventArgs e)
        {
            var viewer = (IViewer)sender;
            var id = viewer.ModelID;
            viewer.LoadModel(-1);
            UnitOfWork.LoanRepository.Delete(id);
            ShowDashboard();
        }

        private void ViewUser_RecordDeleted(object sender, EventArgs e)
        {
            var viewer = (IViewer)sender;
            var id = viewer.ModelID;
            var loans = UnitOfWork.LoanRepository.GetLoansOfUser(id);
            if (loans.Any())
            {
                var act = (OnRecordDeleteAction)Properties.Settings.Default.OnRecordDelete;
                if (act == OnRecordDeleteAction.Prompt)
                {
                    MessageBox.Show(
                   $"این عضو در حال حاضر کتاب در امانت دارد و نمیتوان آن را حذف کرد",
                   "خطا",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning,
                   MessageBoxDefaultButton.Button2,
                   MessageBoxOptions.RtlReading
                   );
                    return;
                }
                else if (act == OnRecordDeleteAction.DeleteDependencies)
                {
                    foreach (var item in loans)
                    {
                        UnitOfWork.LoanRepository.Delete(item.Id);
                    }
                }
            }
            viewer.LoadModel(-1);
            UnitOfWork.UserRepository.Delete(id);
            ShowDashboard();
        }
        private void ViewBook_RecordDeleted(object sender, EventArgs e)
        {
            var viewer = (IViewer)sender;
            var id = viewer.ModelID;
            if (UnitOfWork.LoanRepository.TryGetLoanOfBook(id, out var loan))
            {
                var act = (OnRecordDeleteAction)Properties.Settings.Default.OnRecordDelete;
                if (act == OnRecordDeleteAction.Prompt)
                {
                    MessageBox.Show(
                   $"این کتاب در حال حاضر در امانت است و نمیتوان آن را حذف کرد",
                   "خطا",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning,
                   MessageBoxDefaultButton.Button2,
                   MessageBoxOptions.RtlReading
                   );
                    return;
                }
                else if (act == OnRecordDeleteAction.DeleteDependencies)
                {
                    UnitOfWork.LoanRepository.Delete(loan.Id);
                }
            }
            viewer.LoadModel(-1);
            UnitOfWork.BookRepository.Delete(id);
            ShowDashboard();
        }
        private void ViewUser_LoanCreated(object sender, EventArgs e)
        {
            var id = ViewUser.ModelID;
            TryChangeViewer(ViewLoan, -1, (viewer) =>
            {
                viewer.txtUserCode.Text = id.ToString();
            });
        }
        private void btnSettings_Click(object sender, EventArgs e) => settingsPage.ShowDialog();
        private void ViewUser_Cancelled(object sender, EventArgs e) => ShowDashboard();
        private void ViewBook_Canceled(object sender, EventArgs e) => ShowDashboard();
        private void ViewLoan_Cancelled(object sender, EventArgs e) => ShowDashboard();
        private void ViewLoan_BookOpened(object sender, IdEventArgs e) => ShowBook(e.Id);
        private void ViewLoan_UserOpened(object sender, IdEventArgs e) => ShowUser(e.Id);
        private void UserRepository_Changed(object sender, EventArgs e)
        {
            RefreshUsers();
            RefreshDeliveries();
        }
        private void BookRepository_Changed(object sender, EventArgs e)
        {
            RefreshBooks();
            RefreshDeliveries();
        }
        private void UnitOfWork_Closed(object sender, EventArgs e) => this.Invoke((Action)this.Close);
        private void ViewBook_UserOpened(object sender, IdEventArgs e) => ShowLoan(e.Id);
        private void ViewBook_LoanCreated(object sender, EventArgs e)
        {
            var id = ViewBook.ModelID;
            TryChangeViewer(ViewLoan, -1, (view) =>
            {
                view.txtBookCode.Text = id.ToString();
            });
        }
        #endregion
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UnitOfWork.IsOpen)
            {
                var grp = (GroupBox)panelComponent.Controls[0];
                var Viewer = grp.Controls.Cast<Control>().Where(n => n.Visible).OfType<IViewer>().SingleOrDefault();
                var args = new ViewerClosingEventArgs();
                Viewer?.ViewerClosing(this, args);
            }
        }
        private void listDeliveries_DoubleClick(object sender, EventArgs e)
        {
            if (listDeliveries.SelectedIndex == -1) return;
            ShowLoan((int)listDeliveries.SelectedValue);
        }
        private void listUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var id = e.RowIndex < listUsers.RowCount - 1 ? (int)listUsers.Rows[e.RowIndex].Tag : -1;
            if (id == -1)
            {
                btnAddUser_Click(null, null);

            }
            else
            {
                if (GrabberState == GrabberState.User)
                {
                    ViewLoan.FillUserId(id);
                    GrabberState = GrabberState.None;
                }
                else ShowUser(id);
            }
        }
        private void listBooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var id = e.RowIndex < listBooks.RowCount - 1 ? (int)listBooks.Rows[e.RowIndex].Tag : -1;
            if (id == -1)
            {
                btnAddBook_Click(null, null);

            }
            else
            {
                if (GrabberState == GrabberState.Book)
                {
                    ViewLoan.FillBookId(id);
                    GrabberState = GrabberState.None;
                }
                else ShowBook(id);
            }
        }
        internal bool TryChangeViewer<T>(T viewer, int modelId, Action<T> fillViewer) where T : UserControl, IViewer
        {
            var oldViewer = ActiveViewer;
            var args = new ViewerClosingEventArgs();
            oldViewer?.ViewerClosing(this, args);
            if (args.Cancel) return false;

            if (oldViewer != null && oldViewer != viewer)
            {
                oldViewer?.LoadModel(-1);
                (oldViewer as Control).Visible = false;
            }
            GrabberState = GrabberState.None;
            if (viewer == null)
            {
                grpComponent.Text = null;
                grpComponent.Visible = false;
            }
            else
            {
                viewer.LoadModel(modelId);
                fillViewer?.Invoke(viewer);
                grpComponent.Text = viewer.DisplayName;
                grpComponent.Visible = viewer.Visible = true;
            }
            return true;
        }
        #region Refreshers
        private void RefreshUsers()
        {
            var data = UnitOfWork.UserRepository.Search(searchUsers.SearchKey, searchUsers.SelectedProperty);

            //listUsers.DataSource = data.Select(n => new KeyValuePair<string, int>(n.Fullname + $" ({n.Id})", n.Id)).ToList();
            listUsers.Rows.Clear();
            foreach (var user in data)
            {
                var row = new DataGridViewRow();
                row.Cells.AddRange(
                    new DataGridViewTextBoxCell() { Value = user.Id },
                    new DataGridViewTextBoxCell() { Value = user.Fullname },
                    new DataGridViewTextBoxCell() { Value = user.FatherName },
                    new DataGridViewTextBoxCell() { Value = user.NationalId },
                    new DataGridViewTextBoxCell() { Value = user.PhoneNumber }
                    );
                row.Tag = user.Id;
                listUsers.Rows.Add(row);
            }
        }
        private void RefreshBooks()
        {
            var data = UnitOfWork.BookRepository.Search(searchBooks.SearchKey, searchBooks.SelectedProperty);
            listBooks.Rows.Clear();
            foreach (var book in data)
            {
                var row = new DataGridViewRow();
                row.Cells.AddRange(
                   new DataGridViewTextBoxCell() { Value = book.Id },
                    new DataGridViewTextBoxCell() { Value = book.Name },
                    new DataGridViewTextBoxCell() { Value = book.Author },
                    new DataGridViewTextBoxCell() { Value = book.Category },
                    new DataGridViewTextBoxCell() { Value = book.Description }
                    );
                row.Tag = book.Id;
                listBooks.Rows.Add(row);

            }

        }
        private void RefreshDeliveries() => listDeliveries.DataSource = UnitOfWork.DeliveryRepository.Search(searchDeliveries.SearchKey, searchDeliveries.SelectedProperty).Select(n => new KeyValuePair<string, int>($"{n.BookName}  :  {n.UserName}", n.Id)).ToList();
        #endregion
        #region Initializers
        private void MainWindow_Load(object sender, EventArgs e)
        {
            RefreshBooks();
            RefreshUsers();
            RefreshDeliveries();
            ShowDashboard();
        }

        void InitializeCombos()
        {
            searchUsers.SearchProperties = new Dictionary<string, string>
            {
                { "پیش فرض",null },
                {"کد","Id" },
                { "نام","Fullname" },
                {"نام پدر","Fathername" },
                {"کد ملی","NationalId" },
                {"تلفن","PhoneNumber" },
            }.ToList();
            searchUsers.SelectedPropertyIndex = 0;
            searchBooks.SearchProperties = new Dictionary<string, string>
            {
                {"پیش فرض",null },
                {"کد","Id" },
                {"نام","Name" },
                {"نویسنده","Author" },
                {"دسته بندی","Category" },
                {"توضیحات","Description" }
            }.ToList();
            searchBooks.SelectedPropertyIndex = 0;
            searchDeliveries.SearchProperties = new Dictionary<string, string>
            {
                {"پبش فرض",null },
                {"کد گیرنده","User_id" },
                {"کد کتاب","Book_id" },
                {"نام گیرنده","Fullname" },
                {"تلفن گیرنده","PhoneNumber" },
                {"کدملی گیرنده","NationalId" },
                {"نام کتاب","Name" },
                {"نویسنده کتاب","Author" },
                {"دسته بندی کتاب","Category" },
                {"توضیحات کتاب","Description" },
            }.ToList();
            searchDeliveries.SelectedPropertyIndex = 0;
        }
        public MainWindow(UnitOfWork unitOfWork)
        {
            InitializeComponent();
            foreach (var control in grpComponent.Controls.OfType<IViewer>())
            {
                var viewer = (UserControl)control;
                viewer.Anchor = AnchorStyles.None;
                viewer.Dock = DockStyle.Fill;
                viewer.AutoSize = true;
                //viewer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                viewer.TabIndex = 0;
                viewer.Visible = false;
                control.Initialize(unitOfWork);
            }
            unitOfWork.BookRepository.Changed += BookRepository_Changed;
            unitOfWork.UserRepository.Changed += UserRepository_Changed;
            unitOfWork.LoanRepository.Changed += LoanRepository_Changed;
            UnitOfWork = unitOfWork;
            //unitOfWork.Updated += UnitOfWork_Updated;
            UnitOfWork.Closed += UnitOfWork_Closed;
            settingsPage = new SettingsPage(unitOfWork);
            InitializeCombos();
        }

        private void LoanRepository_Changed(object sender, EventArgs e) => RefreshDeliveries();
        #endregion

        private void ViewLoan_GrabBookId(object sender, EventArgs e)
        {
            GrabberState = GrabberState.Book;
        }

        private void ViewLoan_GrabUserId(object sender, EventArgs e)
        {
            GrabberState = GrabberState.User;
        }

        private void btnCloseComponent_Click(object sender, EventArgs e)
        {
            TryChangeViewer<ViewLoan>(null, -1, null);
        }
    }

}
