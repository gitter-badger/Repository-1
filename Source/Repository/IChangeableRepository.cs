using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository
{
    public interface IChangeableRepository<T> : IRepository
    {
        Task<T> AddAsync(T item);

        Task<IEnumerable<T>> AddAsync(IEnumerable<T> items);

        Task<T> DeleteAsync(T item);

        Task<IEnumerable<T>> DeleteAsync(IEnumerable<T> items);

        Task<T> EditAsync(T item);

        Task<IEnumerable<T>> EditAsync(IEnumerable<T> items);
    }
}