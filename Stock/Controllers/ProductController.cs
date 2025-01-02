using ApplicationLayer.Dtos;
using ApplicationLayer.Services;
using DomainLayer.Entities;
using DomainLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Stock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private ProductService _productService;
        public ProductController(IProductRepository repo)
        {
            _productService = new ProductService(repo);
        }

        [HttpGet]
        public List<ProductEntity> getAll()
        {
            return _productService.GetAllProduct();
        }

        [HttpPost]
        public ProductEntity CreateProduct(CreateProductDto productdto)
        {
            return _productService.Create(productdto);
        }
        [HttpPatch]
        public ProductEntity UpdateProduct(ProductEntity product)
        {
            return _productService.UpdateProduct(product);
        }

        [HttpGet]
        public ProductEntity GetProductById(int id)
        {
            return _productService.GetProduct(id);
        }
        [HttpDelete]
        public ProductEntity DeleteProductById(int id)
        {
            return _productService.DeleteProduct(id);
        }

    }
}
