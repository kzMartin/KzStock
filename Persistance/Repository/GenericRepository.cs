using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using KzStock.Core;
using Microsoft.AspNetCore.Internal;
using Microsoft.EntityFrameworkCore;

namespace KzStock.Persistance.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected StockDbContext Db { get; set; }

        public GenericRepository(StockDbContext db)
        {
            Db = db;
        }

        public async Task<IEnumerable<T>> FindAllAsync()
        {
            return await Db.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> FindByConditionAsync(Expression<Func<T, bool>> expression)
        {
            return await Db.Set<T>().Where(expression).ToListAsync();
        }

        public void Create(T entity)
        {
            Db.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            Db.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            Db.Set<T>().Remove(entity);
        }

        public async Task SaveAsync()
        {
            await Db.SaveChangesAsync();
        }
    }
}