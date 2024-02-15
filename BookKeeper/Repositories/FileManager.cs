using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace BookKeeper
{
    public class FileManager : IDisposable
    {
        public event EventHandler Accessed;
        public event EventHandler Changed;
        static readonly string DATA_FOLDER = Application.StartupPath + "\\PFP\\";

        SqlConnection SqlConnection;
        SHA256 HashFunction;
        Dictionary<Hash, WeakReference<Bitmap>> m_cacheList;
        Aes aes;
        private bool disposedValue;

        private Stream GetStream(Hash hash)
        {
            if (!RetrieveHash(hash, out var url, out var iv)) throw new ArgumentOutOfRangeException();
            aes.IV = iv;
            var file = File.OpenRead(Path.Combine(DATA_FOLDER, url));
            var decryptor = new CryptoStream(file, aes.CreateDecryptor(), CryptoStreamMode.Read);
            var realHash = new Hash(HashFunction.ComputeHash(decryptor));
            if (realHash != hash) throw new CryptographicException("the hashes don't match");
            file.Position = 0;
            return new CryptoStream(file, aes.CreateDecryptor(), CryptoStreamMode.Read);
        }
        public Bitmap GetBitmap(Hash hash)
        {
            if (m_cacheList.TryGetValue(hash, out var weak) && weak.TryGetTarget(out var cache))
            {
                return cache;
            }
            var stream = GetStream(hash);
            var bitmap = new Bitmap(stream);
            if (m_cacheList.TryGetValue(hash, out var x))
            {
                x.SetTarget(bitmap);
            }
            else m_cacheList[hash] = new WeakReference<Bitmap>(bitmap);
            return bitmap;
        }
        public Hash GetHash(string url)
        {
            if (url == null) return new Hash();
            using (var inputFile = File.OpenRead(url))
            {
                var hash = new Hash(HashFunction.ComputeHash(inputFile));

                bool dataWasRetrieved = RetrieveHash(hash, out _, out _);
                if (dataWasRetrieved) return hash;
                aes.GenerateIV();

                var filename = Path.GetRandomFileName();
                var fullname = Path.Combine(DATA_FOLDER, filename);
                inputFile.Position = 0;
                using (var outputfile = File.Open(fullname, FileMode.Create))
                {
                    using (var encryptor = new CryptoStream(outputfile, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        inputFile.CopyTo(encryptor);
                    }
                }
                SaveDataToDatabase(hash, filename, aes.IV);
                return hash;
            }
        }
        void SaveDataToDatabase(Hash hash, string url, byte[] iv)
        {
            var commandString = "INSERT INTO PFPCRC (Hash,Filename,IV) VALUES (@hash,@filename,@iv)";
            using (var command = new SqlCommand(commandString, SqlConnection))
            {
                command.Parameters.AddWithValue("@hash", hash.GetBytes());
                command.Parameters.AddWithValue("@filename", url);
                command.Parameters.AddWithValue("@iv", iv);
                command.ExecuteNonQuery();
            }
            Changed?.Invoke(this, EventArgs.Empty);
            Accessed?.Invoke(this, EventArgs.Empty);
        }
        bool RetrieveHash(Hash hash, out string url, out byte[] iv)
        {
            var commandString = "SELECT * FROM PFPCRC WHERE Hash = @hash";
            bool result;
            using (var command = new SqlCommand(commandString, SqlConnection))
            {
                command.Parameters.AddWithValue("@hash", hash.GetBytes());
                using (var reader = command.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        url = null;
                        iv = null;
                        result = false;
                    }
                    else
                    {
                        reader.Read();
                        url = reader.GetString(1);
                        iv = new byte[16];
                        reader.GetBytes(2, 0, iv, 0, iv.Length);
                        result = true;
                    }
                }
            }
            Accessed?.Invoke(this, EventArgs.Empty);
            return result;
        }
        public void GarbageCollector()
        {
            using (var command = new SqlCommand("EXEC GC", SqlConnection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var filename = reader.GetString(1);
                        File.Delete(Path.Combine(DATA_FOLDER, filename));
                    }
                }
            }
            Changed?.Invoke(this, EventArgs.Empty);
            Accessed?.Invoke(this, EventArgs.Empty);
        }
        public bool RetrieveAesKey()
        {
            var commandString = "SELECT * FROM AesKey";
            using (var command = new SqlCommand(commandString, SqlConnection))
            {
                using (var reader = command.ExecuteReader())
                {
                    if (!reader.HasRows) return false;
                    reader.Read();
                    var key = new byte[32];
                    reader.GetBytes(1, 0, key, 0, key.Length);
                    aes.Key = key;
                }
            }
            return true;
        }
        public void GenerateAesKey()
        {
            Directory.Delete(DATA_FOLDER, true);
            Directory.CreateDirectory(DATA_FOLDER);
            aes.GenerateKey();
            using (var command = new SqlCommand("CreateEncryptionKey", SqlConnection))
            {

                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@EncryptionKey", aes.Key);
                command.ExecuteNonQuery();
            }
        }
        public void RegenerateAesKey()
        {
            var retrieveCommandString = "SELECT * FROM PFPCRC";
            List<(Hash, string, byte[])> records = new List<(Hash, string, byte[])>();
            using (var retrieveCommand = new SqlCommand(retrieveCommandString, SqlConnection))
            {
                var buffer = new byte[16];
                using (var reader = retrieveCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        reader.GetBytes(0, 0, buffer, 0, buffer.Length);
                        var str = reader.GetString(1);
                        var iv = new byte[16];
                        reader.GetBytes(2, 0, iv, 0, iv.Length);
                        records.Add((
                        new Hash(buffer),
                        str,
                        iv
                        ));
                    }
                }
            }
        }
        public int Count()
        {
            var commandString = "SELECT COUNT(Hash) FROM PFPCRC";
            int result;
            using (var command = new SqlCommand(commandString, SqlConnection))
            {
                result = (int)command.ExecuteScalar();
            }
            Accessed?.Invoke(this, EventArgs.Empty);
            return result - 1;
        }
        public int CountUnused()
        {
            var commandString = "SELECT COUNT(Hash) FROM UnusedFiles";
            int result;
            using (var command = new SqlCommand(commandString, SqlConnection))
            {
                result = (int)command.ExecuteScalar();
            }
            Accessed?.Invoke(this, EventArgs.Empty);
            return result;
        }
        public FileManager(SqlConnection sqlConnection)
        {
            Directory.CreateDirectory(DATA_FOLDER);

            SqlConnection = sqlConnection;

            aes = Aes.Create();
            HashFunction = SHA256.Create();
            m_cacheList = new Dictionary<Hash, WeakReference<Bitmap>>();
        }


        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                    aes.Dispose();
                    HashFunction.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                SqlConnection = null;
                m_cacheList = null;
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~FileManager()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        void IDisposable.Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
