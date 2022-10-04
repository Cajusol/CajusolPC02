
using CajusolPC02.DOMAIN.Core.Interfaces;
using CajusolPC02.DOMAIN.Infrastructure.Data;
using CajusolPC02.DOMAIN.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder
    .Configuration
    .GetConnectionString("DevConnection");
builder
    .Services
    .AddDbContext<SalesContext>
    (Options => Options.UseSqlServer(connectionString));

builder.Services.AddTransient<ISupplierRepository, SupplierRepository>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
