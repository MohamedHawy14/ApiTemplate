using CleanArchitecture.DataAccess.Models;
using System.Linq.Expressions;


namespace CleanArchitecture.DataAccess.IRepository
{
    public interface IRepository<T> where T : ModelBase
    {
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, string? includeProperties = null);

        IQueryable<T> GetAllQuery(Expression<Func<T, bool>>? filter = null, string? includeProperties = null);
        T Get(Expression<Func<T, bool>> filter, string? includeProperties = null, bool tracked = false);
        void Add(T entity);
        void Delete(T entity);
        void DeleteRange(IEnumerable<T> entities);
        void Update(T entity);
    }
}
