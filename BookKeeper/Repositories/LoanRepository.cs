using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace BookKeeper.Repositories
{
    public class LoanRepository : IRepository<Loan>
    {
        public event EventHandler Changed;
        public event EventHandler Accessed;
        SqlConnection connection;
        public int Create(Loan entity)
        {
            var commandString = "INSERT INTO Loans (User_id,Book_id,From_date,To_date) OUTPUT INSERTED.id Values(@userid,@bookid,@from,@to)";
            int result;
            using (var command = new SqlCommand(commandString, connection))
            {
                command.Parameters.AddWithValue("@userid", entity.UserId);
                command.Parameters.AddWithValue("@bookid", entity.BookId);
                command.Parameters.AddWithValue("@from", entity.From);
                command.Parameters.AddWithValue("@to", entity.To);
                result = (int)command.ExecuteScalar();
            }
            Changed?.Invoke(this, EventArgs.Empty);
            Accessed?.Invoke(this, EventArgs.Empty);
            return result;
        }
        public void Delete(int id)
        {
            var commandString = "DELETE FROM Loans WHERE Id = @id";
            using (var command = new SqlCommand(commandString, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
            Changed?.Invoke(this, EventArgs.Empty);
            Accessed?.Invoke(this, EventArgs.Empty);
        }
        public bool Exists(int id)
        {
            var commandString = "SELECT EXISTS (SELECT 1 FROM Loans WHERE id = @id)";
            bool result;
            using (var command = new SqlCommand(commandString, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                result = (bool)command.ExecuteScalar();
            }
            Accessed?.Invoke(this, EventArgs.Empty);
            return result;
        }
        public Loan Get(int id)
        {
            if (id < 0) throw new ArgumentOutOfRangeException("id");
            var commandString = "SELECT * FROM Loans WHERE Id = @id";
            Loan result;
            using (var command = new SqlCommand(commandString, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                using (var reader = command.ExecuteReader())
                    result = TranslateReader(reader).Single();
            }
            Accessed?.Invoke(this, EventArgs.Empty);
            return result;
        }
        public IEnumerable<Loan> GetAll()
        {
            var commandString = "SELECT * FROM Loans";
            IEnumerable<Loan> result;
            using (var command = new SqlCommand(commandString, connection))
            {
                using (var reader = command.ExecuteReader())
                    result = TranslateReader(reader);
            }
            Accessed?.Invoke(this, EventArgs.Empty);
            return result;
        }
        public IEnumerable<Loan> GetLoansOfUser(int id)
        {
            if (id < 0) throw new ArgumentOutOfRangeException("id");
            var commandString = "SELECT * FROM Loans WHERE User_id = @id";
            IEnumerable<Loan> result;
            using (var command = new SqlCommand(commandString, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                using (var reader = command.ExecuteReader())
                    result = TranslateReader(reader);
            }
            Accessed?.Invoke(this, EventArgs.Empty);
            return result;
        }
        public bool TryGetLoanOfBook(int id, out Loan loan)
        {
            if (id < 0) throw new ArgumentOutOfRangeException("id");
            var commandString = "SELECT * FROM Loans WHERE Book_id = @id";
            bool result;
            using (var command = new SqlCommand(commandString, connection))
            {
                command.Parameters.AddWithValue("@id", id);

                using (var reader = command.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        loan = default;
                        result = false;
                    }
                    else
                    {
                        loan = TranslateReader(reader).Single();
                        result = true;
                    }
                }
            }
            Accessed?.Invoke(this, EventArgs.Empty);
            return result;
        }
        public void Patch(Loan entity)
        {
            throw new InvalidOperationException();
            //var commandString = "UPDATE Loans SET Name = @name, Author = @author,serial_number = @serialnumber,Description = @description,cover_hash = @coverhash WHERE id = @id";
            //using (var command = new SqlCommand(commandString, connection))
            //{
            //    command.Parameters.AddWithValue("@useid", entity.UserId);
            //    command.Parameters.AddWithValue("@bookid", entity.BookId);
            //    command.Parameters.AddWithValue("@from", entity.From);
            //    command.Parameters.AddWithValue("@serialnumber", entity.SerialNumber);
            //    command.Parameters.AddWithValue("@description", entity.Description);
            //    command.Parameters.AddWithValue("@coverhash", entity.CoverHash.ToByteArray());
            //    command.ExecuteNonQuery();
            //}
            //Changed?.Invoke(this, EventArgs.Empty);
            //Accessed?.Invoke(this, EventArgs.Empty);
        }

        public IEnumerable<Loan> Search(string key, string by)
        {
            throw new NotImplementedException();
            //if (string.IsNullOrEmpty(key)) return GetAll();
            //var commandString = "SELECT * FROM Books WHERE Id LIKE @key OR Name LIKE @key OR Author LIKE @key OR Description LIKE @key";
            //IEnumerable<Book> result;
            //using (var command = new SqlCommand(commandString, connection))
            //{
            //    command.Parameters.AddWithValue("@key", $"%{key}%");
            //    var reader = command.ExecuteReader();
            //    result = TranslateReader(reader);
            //}
            //Accessed?.Invoke(this, EventArgs.Empty);
            //return result;
        }
        public static IEnumerable<Loan> TranslateReader(SqlDataReader reader)
        {
            List<Loan> result = new List<Loan>();
            while (reader.Read())
            {
                var n = new Loan()
                {
                    Id = reader.GetInt32(0),
                    BookId = reader.GetInt32(1),
                    UserId = reader.GetInt32(2),
                    From = reader.GetDateTime(3),
                    To = reader.GetDateTime(4)
                };
                result.Add(n);
            }
            return result;
        }
        public void Extend(int id, DateTime newdeliveryTime)
        {
            var commandstring = "UPDATE Loans SET To_date = @delivery WHERE Id = @id";
            using (var command = new SqlCommand(commandstring, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@delivery", newdeliveryTime);
                command.ExecuteNonQuery();
            }
            Changed?.Invoke(this, EventArgs.Empty);
            Accessed?.Invoke(this, EventArgs.Empty);
        }
        public int Count()
        {
            var commandstring = "SELECT COUNT(Id) FROM Loans";
            int result;
            using (var command = new SqlCommand(commandstring, connection))
            {
                result = (int)command.ExecuteScalar();
            }
            Accessed?.Invoke(this, EventArgs.Empty);
            return result;
        }
        public LoanRepository(SqlConnection connection)
        {
            this.connection = connection;
        }
    }
}
