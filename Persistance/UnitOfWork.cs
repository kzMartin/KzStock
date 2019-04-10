using System.Threading.Tasks;
using KzStock.Core;
using KzStock.Persistance.Repository;

namespace KzStock.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        private StockDbContext Context { get; }

        public UnitOfWork(StockDbContext context)
        {
            Context = context;
        }

        public async Task CompleteAsync()
        {
            await Context.SaveChangesAsync();
        }
    }
}