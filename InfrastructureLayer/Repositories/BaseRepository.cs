using DomainLayer.Entities;
using DomainLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : BaseModel
    {
        private StockDbContext db;
        public BaseRepository(StockDbContext _db) 
        {
        db = _db;
        }
        public Task Add(T entity)
        {
            db.Add(entity);
            db.SaveChanges();
            return Task.CompletedTask;
        }

        public async Task Delete(int id)
        {
            T entity =await  Get(id);
            db.Remove(id);
        }

        public async Task<T> Get(int id)
        {
           return  db.Set<T>().FirstOrDefault(x => x.Id == id && !x.IsDeleted);
        }

        public Task<List<T>> GetAll()
        {
            return db.Set<T>().Where(x=> x.IsDeleted == false ).ToListAsync();
        }

        public IQueryable<T> GetQuery(Expression<Func<T, bool>> predicate)
        {
            return db.Set<T>().Where(predicate);
        }

        public Task Update(int id, T entity)
        {
            db.Update(entity);
            db.SaveChanges();
            return Task.CompletedTask;

        }

    }
}
