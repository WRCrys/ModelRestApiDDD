using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModelRestApiDDD.Domain.Core.Interfaces.Repositories;
using ModelRestApiDDD.Domain.Entities;

namespace ModelRestApiDDD.Infrastructure.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        private readonly ModelRestApiContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public Repository(ModelRestApiContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public async Task Add(TEntity entity)
        {
            try
            {
                _dbSet.Add(entity);
                await SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task Update(TEntity entity)
        {
            try
            {
                _dbSet.Update(entity);
                await SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task Remove(TEntity entity)
        {
            try
            {
                _dbSet.Remove(entity);
                await SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<int> SaveChanges()
        {
            return await _context.SaveChangesAsync();
        }
    }
}