using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace BookKeeper.Repositories
{
    public class BookRepository : IRepository<Book>
    {
        public event EventHandler Changed;
        public event EventHandler Accessed;
        SqlConnection connection;
        public int Create(Book entity)
        {
            var commandString = "INSERT INTO Books (Name,Author,cover_hash,Category,Description) OUTPUT INSERTED.id Values(@name,@author,@coverhash,@category,@description)";
            int result;
            using (var command = new SqlCommand(commandString, connection))
            {

                command.Parameters.AddWithValue("@name", entity.Name);
                command.Parameters.AddWithValue("@author", entity.Author);
                command.Parameters.AddWithValue("@coverhash", entity.CoverHash.GetBytes());
                command.Parameters.AddWithValue("@category", entity.Category);
                command.Parameters.AddWithValue("@description", entity.Description);
                result = (int)command.ExecuteScalar();
            }
            Changed?.Invoke(this, EventArgs.Empty);
            Accessed?.Invoke(this, EventArgs.Empty);
            return result;
        }
        public void Delete(int id)
        {
            var commandString = "DELETE FROM Books WHERE Id = @id";
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
            var commandString = "SELECT Id FROM Books WHERE Id = @id";
            bool result;
            using (var command = new SqlCommand(commandString, connection))
            {

                command.Parameters.AddWithValue("@id", id);
                using (var reader = command.ExecuteReader())
                {
                    result = reader.HasRows;
                }
            }
            Accessed?.Invoke(this, EventArgs.Empty);
            return result;
        }
        public Book Get(int id)
        {
            if (id < 0) throw new ArgumentOutOfRangeException("id");
            var commandString = "SELECT * FROM Books WHERE Id = @id";
            Book result;
            using (var command = new SqlCommand(commandString, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                using (var reader = command.ExecuteReader())
                {
                    result = TranslateReader(reader).Single();
                }
            }
            Accessed?.Invoke(this, EventArgs.Empty);
            return result;
        }
        public IEnumerable<Book> GetAll()
        {
            var commandString = "SELECT * FROM Books";
            IEnumerable<Book> result;
            using (var command = new SqlCommand(commandString, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    result = TranslateReader(reader);
                }
            }
            Accessed?.Invoke(this, EventArgs.Empty);
            return result;
        }
        public void Patch(Book entity)
        {
            var commandString = "UPDATE Books SET Name = @name, Author = @author,Category = @category,Description = @description,cover_hash = @coverhash WHERE id = @id";
            using (var command = new SqlCommand(commandString, connection))
            {
                command.Parameters.AddWithValue("@id", entity.Id);
                command.Parameters.AddWithValue("@name", entity.Name);
                command.Parameters.AddWithValue("@author", entity.Author);
                command.Parameters.AddWithValue("@category", entity.Category);
                command.Parameters.AddWithValue("@description", entity.Description);
                command.Parameters.AddWithValue("@coverhash", entity.CoverHash.GetBytes());
                command.ExecuteNonQuery();
            }
            Changed?.Invoke(this, EventArgs.Empty);
            Accessed?.Invoke(this, EventArgs.Empty);
        }
        public IEnumerable<Book> Search(string key,string by)
        {
            IEnumerable<Book> result;
            var commandString = by == null ? "Select * FROM SearchBook(@key)" :
                $"SELECT * FROM Books WHERE {by} LIKE @key";          
            using (var command = new SqlCommand(commandString, connection))
            {
                command.Parameters.AddWithValue("@key", $"%{key}%");
                using (var reader = command.ExecuteReader())
                    result = TranslateReader(reader);
            }
            Accessed?.Invoke(this, EventArgs.Empty);
            return result;
        }
        IEnumerable<Book> TranslateReader(SqlDataReader reader)
        {
            var result = new List<Book>();
            var hashbuffer = new byte[32];
            while (reader.Read())
            {
                if (!reader.IsDBNull(4)) reader.GetBytes(4, 0, hashbuffer, 0, hashbuffer.Length);
                var n = new Book()
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Author = reader.GetString(2),
                    Description = reader.GetString(3),
                    CoverHash = new Hash(hashbuffer),
                    Category = reader.GetString(5)
                };
                result.Add(n);
            }
            return result;
        }

        public int Count()
        {
            var commandstring = "SELECT COUNT(*) FROM Books";
            int result;
            using (var command = new SqlCommand(commandstring, connection))
            {
                result = (int)command.ExecuteScalar();
            }
            Accessed?.Invoke(this, EventArgs.Empty);
            return result;
        }
        public BookRepository(SqlConnection connection)
        {
            this.connection = connection;
        }
    }
}
