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

    }
}
