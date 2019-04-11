using System.Threading.Tasks;
using KzStock.Core;

namespace KzStock.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(StockDbContext context)
        {
            Context = context;
        }

        private StockDbContext Context { get; }

        public async Task CompleteAsync()
        {
            await Context.SaveChangesAsync();
        }
    }
}