using ShopFlow.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ShopFlowDbContext>(
    options =>
    {
        options.UseNpgsql(configuration.GetConnectionString(nameof(ShopFlowDbContext)));
    });

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();


