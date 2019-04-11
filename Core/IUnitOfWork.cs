using System.Threading.Tasks;

namespace KzStock.Core
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}