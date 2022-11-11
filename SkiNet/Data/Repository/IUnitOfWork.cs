using SkiNet.Models;
using System.Threading.Tasks;

namespace SkiNet.Data.Repository
{
    public interface IUnitOfWork
    {
        IGenericRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity;
        Task<int> Complete();
    }
}
