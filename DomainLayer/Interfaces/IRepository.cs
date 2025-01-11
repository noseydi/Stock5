using DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Interfaces
{
    public interface IRepository<T> where T : BaseModel
    {
        Task<T> Get(int id);
        Task<List<T>> GetAll();
        Task Delete(int id);
        IQueryable<T> GetQuery(Expression<Func<T, bool>> predicate);
        Task Add(T entity);
        Task Update(int id , T entity);
    }
}
