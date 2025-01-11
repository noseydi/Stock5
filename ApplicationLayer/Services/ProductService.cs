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
    public class ProductService : BaseService<ProductEntity>
    {

        public ProductService(BaseRepository<ProductEntity> repo , IBaseService<ProductSerialsEntity> productserial ): base (repo) 
        {
        }

             
    }
}
