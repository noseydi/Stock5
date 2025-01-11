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
    public class ProductController : BaseController<ProductEntity>
    {
        private ProductService _productService;
        public ProductController(IBaseService<ProductEntity> _service) : base (_service)
        {
        }


}
}
