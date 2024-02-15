using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BookKeeper.Repositories
{
    public class CategoryRepository
    {
        public event EventHandler Changed;
        public event EventHandler Accessed;
        SqlConnection connection;
        public int Count() => throw new NotImplementedException();
        public int Create(string entity)
        {
            var commandString = "INSERT INTO Categories (Name) Values(@name)";
            using (var command = new SqlCommand(commandString, connection))
            {
                command.Parameters.AddWithValue("@name", entity);
                command.ExecuteNonQuery();
            }
            Changed?.Invoke(this, EventArgs.Empty);
            Accessed?.Invoke(this, EventArgs.Empty);
            return -1;
        }
        public void Delete(string name)
        {
            using (var command = new SqlCommand("DeleteCategory", connection))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name", name);
                command.ExecuteNonQuery();
            }
            Changed?.Invoke(this, EventArgs.Empty);
            Accessed?.Invoke(this, EventArgs.Empty);
        }
        public bool Exists(string name)
        {
            var commandString = "SELECT Id FROM Categories WHERE Name = @name";
            bool result;
            using (var command = new SqlCommand(commandString, connection))
            {

                command.Parameters.AddWithValue("@name", name);
                using (var reader = command.ExecuteReader())
                {
                    result = reader.HasRows;
                }
            }
            Accessed?.Invoke(this, EventArgs.Empty);
            return result;
        }
        public string Get(int id) => throw new NotImplementedException();
        public IEnumerable<string> GetAll()
        {
            var result = new List<string>();
            var commandString = "SELECT Name FROM Categories";
            using (var command = new SqlCommand(commandString, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(reader.GetString(0));
                    }
                }
            }
            Accessed?.Invoke(this, EventArgs.Empty);
            return result;
        }
        public CategoryRepository(SqlConnection sqlConnection)
        {
            this.connection = sqlConnection;
        }
    }
}
