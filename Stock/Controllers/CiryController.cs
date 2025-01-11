using ApplicationLayer.Services;
using DomainLayer.Entities;
using DomainLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Stock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : BaseController<CityEntity>
    {
        private CityService _cityService;

        public CityController(IBaseService<CityEntity> _service) : base(_service)
        {
        }
    }
}