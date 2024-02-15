using BookKeeper.Repositories;
using System;
using System.Data.SqlClient;
using System.Threading;
namespace BookKeeper
{
    public class UnitOfWork
    {
        public event EventHandler Updated;
        public event EventHandler Closed;

        Timer timer;
        DateTimeOffset lastAccess;
        SqlConnection connection;
        public bool IsOpen { get; private set; } = true;
        public CategoryRepository CategoryRepository { get; private set; }
        public UserRepository UserRepository { get; private set; }
        public BookRepository BookRepository { get; private set; }
        public LoanRepository LoanRepository { get; private set; }
        public FileManager FileRepository { get; private set; }
        public DeliveryRepository DeliveryRepository { get; private set; }

        public UnitOfWork(SqlConnection connection)
        {
            FileRepository = new FileManager(connection);
            UserRepository = new UserRepository(connection);// new MockRepository<User>(searchUser);
            BookRepository = new BookRepository(connection);
            LoanRepository = new LoanRepository(connection);
            CategoryRepository = new CategoryRepository(connection);
            DeliveryRepository = new DeliveryRepository(connection);

            FileRepository.Changed += Repository_Changed;
            UserRepository.Changed += Repository_Changed;
            BookRepository.Changed += Repository_Changed;
            LoanRepository.Changed += Repository_Changed;
            CategoryRepository.Changed += Repository_Changed;
            FileRepository.Accessed += Repository_Accessed;
            UserRepository.Accessed += Repository_Accessed;
            BookRepository.Accessed += Repository_Accessed;
            LoanRepository.Accessed += Repository_Accessed;
            CategoryRepository.Accessed += Repository_Accessed;
            DeliveryRepository.Accessed += Repository_Accessed;
            if (FileRepository.RetrieveAesKey() == false)
            {
                FileRepository.GenerateAesKey();
                
            }
           
            lastAccess = DateTimeOffset.UtcNow;
            timer = new Timer(timer_Callback, null, 5000, 5000);
            this.connection = connection;
        }

        private void timer_Callback(object state)
        {
            var span = DateTimeOffset.UtcNow - lastAccess;
            if (span.TotalMinutes >= 5) Close();
        }

        private void Repository_Accessed(object sender, EventArgs e)
        {
            lastAccess = DateTimeOffset.UtcNow;
        }
        void Repository_Changed(object sender, EventArgs e)
        {
            Updated?.Invoke(sender, e);
        }
        void Close()
        {
            IsOpen = false;
            timer.Dispose();
            connection.Close();
            Closed?.Invoke(this, EventArgs.Empty);
        }
    }
}
