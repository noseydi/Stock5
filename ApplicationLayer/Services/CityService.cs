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
    public class CityService
    {
        ICityRepository repo;

        public CityService(ICityRepository _repo) 
        {
            repo = _repo;
        }

        public CityEntity CreateCity(CityEntity item)
        {
            return repo.CreateCity(item);
        }
        public List<CityEntity> GetAllCities()
            { 
        return repo.GetAllCities();
        }
        public CityEntity UpdateCity(CityEntity item)
        {
            return repo.UpdateCity(item);
        }
        public CityEntity DeleteCity(int id)
        {
            return repo.DeleteCity(id );
        }
        public CityEntity GetCityById(int id)
        {
            return repo.GetCityById(id);
        }
             
    }
}
