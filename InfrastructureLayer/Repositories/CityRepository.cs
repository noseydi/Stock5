// CityRepository.cs
using DomainLayer.Entities;
using DomainLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace InfrastructureLayer.Repositories
{
    public class CityRepository : ICityRepository
    {
        private readonly StockDbContext _context;

        public CityRepository(StockDbContext context)
        {
            _context = context;
        }

        public List<CityEntity> GetAllCities()
        {
            return _context.Cities.ToList();
        }

        public CityEntity GetCityById(int id)
        {
            return _context.Cities.FirstOrDefault(c => c.CityID == id);
        }

        public CityEntity CreateCity(CityEntity city)
        {
            _context.Cities.Add(city);
            _context.SaveChanges();
            return city;
        }

        public CityEntity UpdateCity(CityEntity city)
        {
            _context.Cities.Update(city);
            _context.SaveChanges();
            return city;
        }

        public CityEntity DeleteCity(int id)
        {
            var city = _context.Cities.FirstOrDefault(c => c.CityID == id);
            if (city != null)
            {
                _context.Cities.Remove(city);
                _context.SaveChanges();
                return city;
            }
            return null;
        }
    }
}