using ApplicationLayer.Services;
using DomainLayer.Entities;
using DomainLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Stock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private CityService _cityService;

        public CityController(ICityRepository repo)
        {
            _cityService = new CityService(repo);
        }

        // GET: api/city
        [HttpGet]
        public List<CityEntity> GetCities()
        {
            return _cityService.GetAllCities();
        }

        // GET: api/city/5
        [HttpGet("{id}")]
        public CityEntity GetCity(int id)
        {
            return _cityService.GetCityById(id);
        }

        // POST: api/city
        [HttpPost]
        public CityEntity CreateCity([FromBody] CityEntity city)
        {

            _cityService.CreateCity(city);
        return city;
        }

        // PUT: api/city/5
        [HttpPut("{id}")]
        public CityEntity UpdateCity(int id, [FromBody] CityEntity city)
        {

            _cityService.UpdateCity(city);
            return city;
        }

        // DELETE: api/city/5
        [HttpDelete("{id}")]
        public CityEntity DeleteCity(int id)
        {
            var city = _cityService.GetCityById(id);

            _cityService.DeleteCity(id);
            return null;
        }
    }
}