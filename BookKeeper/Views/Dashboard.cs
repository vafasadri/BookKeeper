using System;
using System.Windows.Forms;
namespace BookKeeper
{
    public partial class Dashboard : UserControl, IViewer
    {
        UnitOfWork UnitOfWork;
        public int ModelID => -1;
        public string DisplayName => "داشبورد";
        private void btnGC_Click(object sender, EventArgs e)
        {
            UnitOfWork.FileRepository.GarbageCollector();
        }
        private void UnitOfWork_Updated(object sender, EventArgs e)
        {
            txtUsers.Text = UnitOfWork.UserRepository.Count().ToString();
            txtBooks.Text = UnitOfWork.BookRepository.Count().ToString();
            txtLoans.Text = UnitOfWork.LoanRepository.Count().ToString();
            txtFiles.Text = UnitOfWork.FileRepository.Count().ToString();
            txtUnusedFiles.Text = UnitOfWork.FileRepository.CountUnused().ToString();
        }

        public void LoadModel(int modelID) { }
        public void ViewerClosing(object sender, ViewerClosingEventArgs eventArgs) { }
        public void Initialize(UnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
            unitOfWork.Updated += UnitOfWork_Updated;
            UnitOfWork_Updated(null, null);
        }


        public Dashboard()
        {
            InitializeComponent();

        }
    }
}
