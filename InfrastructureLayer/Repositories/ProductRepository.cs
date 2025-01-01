using DomainLayer.Entities;
using DomainLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public List<ProductEntity> GetAllProduct()
        {
            return _context.products.OrderBy(x => x.ProductID).ToList();
        }
    }
}
