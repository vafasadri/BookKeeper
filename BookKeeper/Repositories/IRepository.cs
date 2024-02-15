using System;
using System.Collections.Generic;

namespace BookKeeper
{
    public interface IRepository<T>
    {
        event EventHandler Changed;
        event EventHandler Accessed;
        int Create(T entity);
        IEnumerable<T> GetAll();
        T Get(int id);
        void Patch(T entity);
        void Delete(int id);
        bool Exists(int id);
        int Count();
        IEnumerable<T> Search(string key,string by);
    }
}
