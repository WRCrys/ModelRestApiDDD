using System.Collections.Generic;
using System.Threading.Tasks;
using ModelRestApiDDD.Domain.Entities;

namespace ModelRestApiDDD.Domain.Core.Interfaces.Repositories
{
    public interface IRepository<TEntity> where TEntity : Entity

    {
        Task Add(TEntity entity);

        Task<TEntity> GetById(int id);

        Task<IEnumerable<TEntity>> GetAll();

        Task Update(TEntity entity);

        Task Remove(TEntity entity);

        Task<int> SaveChanges();
    }
}