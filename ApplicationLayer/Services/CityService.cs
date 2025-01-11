using ApplicationLayer.Dtos;
using DomainLayer.Entities;
using DomainLayer.Interfaces;
using InfrastructureLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Services
{
    
        public class CityService : BaseService<CityEntity>
        {

            public CityService(BaseRepository<CityEntity> repo, IBaseService<CityEntity> city) : base(repo)
            {
            }


        }
    
}