using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using OzelDers.Data.Abstract;

namespace OzelDers.Data.Concrete
{
    public class EfCoreGenericRepository<TEntity> : IRepository<TEntity>
        where TEntity : class


    {
        protected readonly DbContext _dbContext;

        public EfCoreGenericRepository(DbContext dbContext)
        {
            _dbContext = dbContext; ;
        }

        public void Create(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetAll()
        {
            var result = _dbContext
                .Set<TEntity>()
                .ToList();
            return result;
        }

        public TEntity GetById(int id)
        {
            return _dbContext
                .Set<TEntity>()
                .Find(id);
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}

