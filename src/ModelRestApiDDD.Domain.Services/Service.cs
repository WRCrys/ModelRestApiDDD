using System.Collections.Generic;
using System.Threading.Tasks;
using ModelRestApiDDD.Domain.Core.Interfaces.Repositories;
using ModelRestApiDDD.Domain.Core.Interfaces.Services;
using ModelRestApiDDD.Domain.Entities;

namespace ModelRestApiDDD.Domain.Services
{
    public class Service<TEntity> : IService<TEntity> where TEntity : Entity
    {
        private readonly IRepository<TEntity> _repository;

        public Service(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task Add(TEntity entity)
        {
            await _repository.Add(entity);
        }

        public async Task Update(TEntity entity)
        {
            await _repository.Update(entity);
        }

        public async Task Remove(TEntity entity)
        {
            await _repository.Remove(entity);
        }
    }
}