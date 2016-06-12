using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public interface IQueryableRepository<T> : IRepository
    {
        Task<IQueryable<T>> GetAsync();
    }
}