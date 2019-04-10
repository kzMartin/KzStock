using System.Collections.Generic;
using System.Threading.Tasks;

namespace KzStock.Core
{
    public interface IGeneric<T> where T : class
    {
        IEnumerable<T> SelectAll();
        Task<T> SelectById(int id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(int id);
    }
}