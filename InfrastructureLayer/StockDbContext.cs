using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer
{
    public class StockDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
         public Microsoft.EntityFrameworkCore.DbSet<ProductEntity> products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; database = stockdb ; encrypt=false ;integrated security = true ;");

            base.OnConfiguring(optionsBuilder);
        }

    }
}
