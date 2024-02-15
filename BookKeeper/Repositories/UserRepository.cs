using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace BookKeeper.Repositories
{
    public class UserRepository
    {
        public event EventHandler Changed;
        public event EventHandler Accessed;
        SqlConnection connection;
        public int Create(User entity)
        {
            var commandString = "INSERT INTO Users (Fullname,FatherName,PFPHash,NationalId,PhoneNumber,Major,Degree) OUTPUT INSERTED.id Values(@fullname,@fathername,@pfphash,@nationalid,@phonenumber,@major,@degree)";
            int result;          
            using (var command = new SqlCommand(commandString, connection))
            {
                command.Parameters.AddWithValue("@fullname", entity.Fullname);
                command.Parameters.AddWithValue("@fathername", entity.FatherName);
                command.Parameters.AddWithValue("@pfphash", entity.PFPHash.GetBytes());
                command.Parameters.AddWithValue("@nationalid", entity.NationalId);
                command.Parameters.AddWithValue("@phonenumber", entity.PhoneNumber);
                command.Parameters.AddWithValue("@major", (int)entity.Major);
                command.Parameters.AddWithValue("@degree", (int)entity.Grade);
                result = (int)command.ExecuteScalar();
            }
            Changed?.Invoke(this, EventArgs.Empty);
            Accessed?.Invoke(this, EventArgs.Empty);
            return result;
        }
        public void Delete(int id)
        {
            var commandString = "DELETE FROM Users WHERE Id = @id";
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
            var commandString = "SELECT Id FROM Users WHERE Id = @id";
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

        public User Get(int id)
        {
            if (id < 0) throw new ArgumentOutOfRangeException("id");
            var commandString = "SELECT * FROM Users WHERE Id = @id";
            User result;
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
        public IEnumerable<User> GetAll()
        {
            var commandString = "SELECT * FROM Users";
            IEnumerable<User> result;
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
        public void Patch(User entity)
        {
            var commandString = "UPDATE Users SET Fullname = @fullname, FatherName = @fathername,PFPHash = @pfphash,NationalId = @nationalId,PhoneNumber = @phonenumber,Major = @major,Degree = @degree WHERE id = @id";
            using (var command = new SqlCommand(commandString, connection))
            {
                command.Parameters.AddWithValue("@id", entity.Id);
                command.Parameters.AddWithValue("@fullname", entity.Fullname);
                command.Parameters.AddWithValue("@fathername", entity.FatherName);
                command.Parameters.AddWithValue("@pfphash", entity.PFPHash.GetBytes());
                command.Parameters.AddWithValue("@nationalid", entity.NationalId);
                command.Parameters.AddWithValue("@phonenumber", entity.PhoneNumber);
                command.Parameters.AddWithValue("@major", (int)entity.Major);
                command.Parameters.AddWithValue("@degree", (int)entity.Grade);
                command.ExecuteNonQuery();
            }
            Changed?.Invoke(this, EventArgs.Empty);
            Accessed?.Invoke(this, EventArgs.Empty);
        }
        public IEnumerable<User> Search(string key,string by)
        {
            IEnumerable<User> result;
            var commandString = "Select * FROM SearchUser(@key)";
            if(by != null)
            {
                commandString = $"SELECT * FROM Users WHERE {by} LIKE @key";
            }
            using (var command = new SqlCommand(commandString, connection))
            {
                command.Parameters.AddWithValue("@key", $"%{key}%");
                using (var reader = command.ExecuteReader())
                {
                    result = TranslateReader(reader);
                }
            }
            Accessed?.Invoke(this, EventArgs.Empty);
            return result;
        }
        IEnumerable<User> TranslateReader(SqlDataReader reader)
        {
            List<User> list = new List<User>();
            var hashBuffer = new byte[32];
            while (reader.Read())
            {
                reader.GetBytes(3, 0, hashBuffer, 0, hashBuffer.Length);
                var n = new User()
                {
                    Id = reader.GetInt32(0),
                    Fullname = reader.GetString(1),
                    FatherName = reader.GetString(2),
                    PFPHash = new Hash(hashBuffer),
                    NationalId = reader.IsDBNull(4) ? null : reader.GetString(4),
                    PhoneNumber = reader.GetString(5),
                    Major = (Major)reader.GetInt32(6),
                    Grade = (Grade)reader.GetInt32(7),
                };
                list.Add(n);
            }
            return list;
        }

        public int Count()
        {
            var commandstring = "SELECT COUNT(Id) FROM Users";
            int result;
            using (var command = new SqlCommand(commandstring, connection))
            {
                result = (int)command.ExecuteScalar();
            }
            Accessed?.Invoke(this, EventArgs.Empty);
            return result;
        }

        public UserRepository(SqlConnection connection)
        {
            this.connection = connection;
        }
    }
}
