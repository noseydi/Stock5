using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer
{
    public class StockDbContext : DbContext
    {
         public DbSet<ProductEntity> products { get; set; }
         public DbSet<CityEntity> Cities { get; set; }
         public DbSet<ProductSerialsEntity> productSerialsEntities { get; set; }
         public DbSet<InventoryTransactionsEntity> inventoryTransactionsEntities { get; set; }
         public DbSet<ShelvesEntity> shelvesEntities { get; set; }
         public DbSet<WarehousesEntity> warehousesEntity { get; set; }
         public DbSet<WarehouseTransferEntity> warehouseTransferEntity { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; database = stockdb ; encrypt=false ;integrated security = true ;");

            base.OnConfiguring(optionsBuilder);
        }

    }
}
