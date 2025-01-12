using DomainLayer.Entities;
using DomainLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Services
{
    public class BaseService<T> : IBaseService<T> where T : BaseModel
    {
        private IRepository<T> repo;
        public BaseService(IRepository<T> _repo) 
        {
        repo = _repo;   
        }

        public async Task AddAsync(T entity)
        {
          await  repo.Add(entity);
        }

        public Task DeleteAsync(int id)
        {
           return repo.Delete(id);
        }

        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            return  repo.GetQuery(predicate);
        }

        public  async Task<IEnumerable<T>> GetAllAsync()
        {
           return await repo.GetAll();
        }

        public Task<T> GetByIdAsync(int id)
        {
            return repo.Get(id);
        }

        public Task UpdateAsync(int id , T entity)
        {
            return repo.Update(id, entity);
        }
    }
}
