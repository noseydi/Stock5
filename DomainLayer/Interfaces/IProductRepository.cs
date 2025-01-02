using DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Interfaces
{
    public interface IProductRepository

    {
        public ProductEntity CreateProduct(string name , int dimensions);
        public List<ProductEntity> GetAllProduct();
        public ProductEntity UpdateProduct(int id , string name , int dimensions);
        public ProductEntity DeleteProduct(int id);
        public ProductEntity GetProduct(int id);
    }
}
