using ApplicationLayer.Dtos;
using DomainLayer.Entities;
using DomainLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Services
{
    public class ProductService
    {
        IProductRepository repo;

        public ProductService(IProductRepository _repo) 
        {
            repo = _repo;
        }

        public ProductEntity Create(CreateProductDto item)
        {
            return repo.Create(item.ProductName,item.Dimensions);
        }
        public List<ProductEntity> GetAllProduct()
            { 
        return repo.GetAllProduct();
        }
        public ProductEntity UpdateProduct(ProductEntity item)
        {
            return repo.UpdateProduct(item.ProductID , item.ProductName , item.Dimensions);
        }
        public ProductEntity DeleteProduct(int id)
        {
            return repo.DeleteProduct(id );
        }
        public ProductEntity GetProduct(int productID)
        {
            return repo.GetProduct(productID);
        }
             
    }
}
