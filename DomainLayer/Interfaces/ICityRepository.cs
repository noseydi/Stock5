// ICityRepository.cs
using DomainLayer.Entities;
using System.Collections.Generic;

namespace DomainLayer.Interfaces
{
    public interface ICityRepository
    {
        List<CityEntity> GetAllCities();
        CityEntity GetCityById(int id);
        CityEntity CreateCity(CityEntity city);
        CityEntity UpdateCity(CityEntity city);
        CityEntity DeleteCity(int id);
    }
}