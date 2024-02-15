using System;
using System.Collections.Generic;
using System.Linq;

namespace BookKeeper.Repositories
{
    internal class MockRepository<T> : IRepository<T> where T : IDataModel
    {
        public event EventHandler Changed;
        public event EventHandler Accessed;
        int idGen = 1000000;
        readonly Dictionary<int, T> data = new Dictionary<int, T>();
        private readonly Func<T, string, bool> searchFunc;
        public int Create(T entity)
        {
            entity.Id = ++idGen;
            if (data.ContainsKey(entity.Id)) throw new Exception();
            data.Add(entity.Id, entity);
            Changed(this, EventArgs.Empty);
            return entity.Id;
        }
        public void Delete(int id)
        {
            data.Remove(id);
            Changed(this, EventArgs.Empty);
        }

        public T Get(int id)
        {
            return data[id];
        }
        public void Patch(T entity)
        {
            data[entity.Id] = entity;
            Changed(this, EventArgs.Empty);
        }
        public IEnumerable<T> Search(string key,string by)
        {
            if (string.IsNullOrEmpty(key)) return data.Values;
            else return data.Values.Where(n => searchFunc(n, key));
        }

        public bool Exists(int id)
        {
            return data.ContainsKey(id);
        }

        public IEnumerable<T> GetAll()
        {
            return data.Values;
        }

        public int Count() => data.Count;

        public MockRepository(Func<T, string, bool> searchFunc)
        {
            this.searchFunc = searchFunc;
            //this.connection = connection;
        }
    }
}
