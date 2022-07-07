using App.Infra.Context;
using App.Infra.Repository.Interfaces.BaseInterfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace App.Infra.Repository.Entities
{
    public abstract class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _context;

        protected GenericRepository(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task Add(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            List<T> list = await _context.Set<T>().ToListAsync();
            return list;
        }

        public async Task<IEnumerable<T>> Get(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().Where(predicate).ToListAsync();
        }

        public async Task<T> GetByIdAsync(Expression<Func<T, bool>> predicate)
        {
            T? obj = await _context.Set<T>().FirstOrDefaultAsync(predicate);
            return obj;
        }

        public virtual async Task Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }
    }
}