using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BookKeeper.Repositories
{
    public class DeliveryRepository
    {
        public event EventHandler Accessed;

        readonly SqlConnection connection;
        private IEnumerable<Delivery> TranslateReader(SqlDataReader reader)
        {
            List<Delivery> result = new List<Delivery>();
            while (reader.Read())
            {
                var n = new Delivery()
                {
                    Id = reader.GetInt32(0),
                    BookId = reader.GetInt32(1),
                    UserId = reader.GetInt32(2),
                    From = reader.GetDateTime(3),
                    To = reader.GetDateTime(4),
                    BookName = reader.GetString(5),
                    UserName = reader.GetString(9)
                };
                result.Add(n);
            }
            return result;
        }
        public IEnumerable<Delivery> GetAll()
        {
            var commandString = "SELECT * FROM TodaysDeliveries";
            IEnumerable<Delivery> result;
            using (var command = new SqlCommand(commandString, connection))
            {

                //command.Parameters.AddWithValue("@id", id);
                using (var reader = command.ExecuteReader())
                {
                    result = TranslateReader(reader);

                }
            }
            Accessed?.Invoke(this, EventArgs.Empty);
            return result;
        }
        public IEnumerable<Delivery> Search(string key,string by)
        {
            if (string.IsNullOrWhiteSpace(key)) return GetAll();
            var commandString =  by == null ? "SELECT * FROM SearchDelivery(@key)" :
                $"SELECT * FROM TodaysDeliveries WHERE {by} LIKE @key";
            IEnumerable<Delivery> result;
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
        public DeliveryRepository(SqlConnection connection)
        {
            this.connection = connection;
        }
    }
}
