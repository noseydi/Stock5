using DomainLayer.Entities;
using DomainLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Repositories
{
    public class ProductRepository : IProductRepository 
    {
        private StockDbContext _context;
        public ProductRepository(StockDbContext context)
        { 
            _context = context; 
        }

        public ProductEntity Create(string name, int dimensions)
        {
            ProductEntity product = new ProductEntity()
            { ProductName = name, Dimensions = dimensions };    
             _context.Add(product);
            _context.SaveChanges();
            return product;


        }

        public ProductEntity DeleteProduct(int id)
        {
            ProductEntity entity = GetProduct(id);
            _context.products.Remove(entity);
            _context.SaveChanges();
            return entity;

        }

        public List<ProductEntity> GetAllProduct()
        {
            return _context.products.OrderBy(x => x.ProductID).ToList();
        }

        public ProductEntity GetProduct(int id)
        {
            ProductEntity entity = _context.products.Find(id);
            return entity;
        }

        public ProductEntity UpdateProduct(int id, string name, int dimensions)
        {
            throw new NotImplementedException();
        }
    }
}
