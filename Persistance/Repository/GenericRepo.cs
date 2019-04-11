using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using KzStock.Core;
using Microsoft.EntityFrameworkCore;

namespace KzStock.Persistance.Repository
{
    public class GenericRepo<T> : IGeneric<T> where T : class
    {
        private readonly DbSet<T> _entities;

        public GenericRepo(StockDbContext db)
        {
            Db = db;
            _entities = db.Set<T>();
        }

        public StockDbContext Db { get; }

        public void Delete(int id)
        {
            var foundEntity = _entities.Find(id);
            if (foundEntity != null)
                _entities.Remove(foundEntity);
            else
                throw new ArgumentNullException("Entity");
        }

        public void Insert(T obj)
        {
            if (obj != null)
                _entities.Add(obj);
            else
                throw new ArgumentNullException("Entity");
        }

        public IEnumerable<T> SelectAll()
        {
            return _entities;
        }

        public async Task<T> SelectById(int id)
        {
            return await _entities.FindAsync(id);
        }

        public void Update(T obj)
        {
            if (obj != null)
                _entities.Update(obj);
            else
                throw new ArgumentNullException("Entity");
        }
    }
}