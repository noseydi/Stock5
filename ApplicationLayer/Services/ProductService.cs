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

    }
}
