using System;
using Microsoft.EntityFrameworkCore;
using HRMSystem.Models;
using HRM_API;
using HRM_API.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationContext>(options =>
{
   options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddAuthentication();
builder.Services.ConfigureIdentity();

builder.Services.AddCors(x => x.AddPolicy("MyPolicy", builder =>
{
   builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
}));

builder.Services.AddTransient<IBankBranchRepository, BankBranchRepo>();
builder.Services.AddTransient<IBankRepository, BankRepo>();
builder.Services.AddTransient<ICountryRepository, CountryRepo>();
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
   app.UseSwagger();
   app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("MyPolicy");
app.UseAuthorization();

app.MapControllers();

app.Run();
