using Lab.Net.Controllers.User;
using Lab.Net.Data;
using Lab.Net.Models;
using Lab.Net.Service.Account;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IAccountService, AccountService>();
  
builder.Services.AddDbContext<DataBaseContext>(options=>
{
    options.UseNpgsql("Host=localhost;Port=5432;Database=DBLab;Username=postgres;Password=564fhg32");
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
