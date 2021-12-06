using System.Collections.Generic;
using System.Threading.Tasks;
using ModelRestApiDDD.Domain.Entities;

namespace ModelRestApiDDD.Domain.Core.Interfaces.Services
{
    public interface IService<TEntity> where TEntity : Entity
    {
        Task<TEntity> GetById(int id);

        Task<IEnumerable<TEntity>> GetAll();

        Task Add(TEntity entity);

        Task Update(TEntity entity);

        Task Remove(TEntity entity);
    }
}