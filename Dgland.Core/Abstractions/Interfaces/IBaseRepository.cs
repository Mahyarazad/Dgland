using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Dgland.Core.Abstractions.Interfaces
{
    public interface IBaseRepository<T, Tkey> where T : class
    {
        Task<T> AddAsync(T entity, CancellationToken cancellationToken = default);
        Task<bool> AnyAsync(string stringValue, string fieldValue, CancellationToken cancellationToken = default);
        void Delete(T entity);
        void Update(T entity, CancellationToken cancellationToken = default);

        Task<T> GetByIdAsync(Tkey key, CancellationToken cancellationToken = default);

        Task<IQueryable<T>> GetListAsync(Expression<Func<T, bool>> predicate
            , Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null!);
    }

}
