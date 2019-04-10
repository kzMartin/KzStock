using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using KzStock.Core;
using Microsoft.EntityFrameworkCore;

namespace KzStock.Persistance.Repository
{
    public class GenericRepo<T> : IGeneric<T> where T : class
    {
        public StockDbContext Db { get; }

        private DbSet<T> entities;

        public GenericRepo(StockDbContext db)
        {
            Db = db;
            entities = db.Set<T>();
        }

        public void Delete(int id)
        {
            var foundEntity = entities.Find(id);
            if (foundEntity != null)
            {
                entities.Remove(foundEntity);
            }
            else
            {
                throw new ArgumentNullException("Entity");
            }
        }

        public void Insert(T obj)
        {
            if (obj != null)
            {

                entities.Add(obj);
            }
            else
            {
                throw new ArgumentNullException("Entity");
            }
        }

        public IEnumerable<T> SelectAll()
        {
            return entities;
        }

        public async Task<T> SelectById(int id)
        {
            return await entities.FindAsync(id);
        }

        public void Update(T obj)
        {
            if (obj != null)
            {
                entities.Update(obj);
            }
            else
            {
                throw new ArgumentNullException("Entity");
            }
        }
    }
}