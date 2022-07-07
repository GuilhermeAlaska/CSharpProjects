using System.Linq.Expressions;

namespace App.Infra.Repository.Interfaces.BaseInterfaces
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> Get(Expression<Func<T, bool>> predicate);
        Task<T> GetByIdAsync(Expression<Func<T, bool>> predicate);
        Task Add(T entity);
        Task Delete(T entity);
        Task Update(T entity);
        Task Commit();
    }
}