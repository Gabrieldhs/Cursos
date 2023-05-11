using FastTech.Application.Services.ProdutoHandler;
using FastTech.Core.Common.Mediatr;
using FastTech.Domain.Interfaces;
using FastTech.Infrastructure.Context;
using FastTech.Infrastructure.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("FastTechConnection")));

// Confing MediaTr
builder.Services.AddScoped<IMediatrHandler, MediatrHandler>();
builder.Services.AddScoped<IRequestHandler<CadastrarProdutoCommand, bool>, ProdutoCommandHandler>();



builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();

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
