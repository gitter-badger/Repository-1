using System;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepositoryContext : IDisposable
    {
        Task SaveAsync();
    }
}