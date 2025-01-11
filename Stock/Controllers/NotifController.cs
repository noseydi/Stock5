using ApplicationLayer.Services;
using DomainLayer.Entities;
using DomainLayer.Interfaces;
using InfrastructureLayer;
using InfrastructureLayer.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Stock.Controllers
{
    public class NotifController : ControllerBase
    {
        private RmqService rmq;
        IBaseService<ProductEntity> repo;
        public NotifController(RmqService _rmq , IBaseService<ProductEntity> _repo)
        { 
           // BaseRepository<ProductEntity> productentity = new BaseRepository<ProductEntity>(_db);
            repo = _repo;
           // repo.GetQuery(x=> x.Id == 1 ).ToList();
            rmq = _rmq;
        }

    }

   
}
