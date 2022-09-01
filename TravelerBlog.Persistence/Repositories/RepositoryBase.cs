using System.Linq.Expressions;
using TravelerBlog.Core.Entity;
using TravelerBlog.Core.Repository;
using TravelerBlog.Persistence.Data;

namespace TravelerBlog.Persistence.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : EntityBase
    {
        protected readonly TravelerBlogDbContext _context;

        public RepositoryBase(TravelerBlogDbContext context)
        {
            _context = context;
        }

        public Task<T> AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> AddRangeAsync(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public Task<T> DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> DeleteRangeAsync(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<T>> GetAllAsync(bool isChangeTracking, Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAsync(bool isChangeTracking, Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(bool isChangeTracking, int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
