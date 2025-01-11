using ApplicationLayer.Services;
using DomainLayer.Entities;
using DomainLayer.Interfaces;
using InfrastructureLayer;
using InfrastructureLayer.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<StockDbContext>(ServiceLifetime.Scoped); 
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddScoped<ICityRepository, CityRepository>();
//builder.Services.AddScoped<IProductRepository , ProductRepository>();
builder.Services.AddDbContext<StockDbContext>(contextLifetime : ServiceLifetime.Scoped,optionsLifetime:ServiceLifetime.Scoped );
builder.Services.AddScoped<IRepository<ProductEntity>, BaseRepository<ProductEntity>>();
builder.Services.AddScoped<IRepository<CityEntity>, BaseRepository<CityEntity>>();
builder.Services.AddScoped<IRepository<InventoryTransactionsEntity>, BaseRepository<InventoryTransactionsEntity>>();
builder.Services.AddScoped<IRepository<ProductSerialsEntity>, BaseRepository<ProductSerialsEntity>>();
builder.Services.AddScoped<IRepository<ShelvesEntity>, BaseRepository<ShelvesEntity>>();
builder.Services.AddScoped<IRepository<WarehousesEntity>, BaseRepository<WarehousesEntity>>();
builder.Services.AddScoped<IRepository<WarehouseTransferEntity>, BaseRepository<WarehouseTransferEntity>>();

builder.Services.AddScoped<IBaseService<ProductEntity>, BaseService<ProductEntity>>();
builder.Services.AddScoped<IBaseService<CityEntity>, BaseService<CityEntity>>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
