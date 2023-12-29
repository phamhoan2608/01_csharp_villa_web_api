using MagicVilla_Villa_API.Data;
using MagicVilla_Villa_API.Logging;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using MySqlConnector;
using MagicVilla_Villa_API;
using MagicVilla_Villa_API.Repository.IRepository;
using MagicVilla_Villa_API.Repository;
using MagicVilla_Villa_API.Models;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddMySqlDataSource(builder.Configuration.GetConnectionString("Default")!);
builder.Services.AddDbContext<ApplicationDbContext>(option => option.UseMySql("server=localhost;port=3306;user=root;password=0000;database=magic_villa", new MySqlServerVersion(new System.Version(7, 0, 0))));
// Add services to the container.
builder.Services.AddScoped<IRepository<Villa>, VillaRepository>();
builder.Services.AddAutoMapper(typeof(MappingConfig));
builder.Services.AddControllers(option =>
{
    //option.ReturnHttpNotAcceptable = true;
}).AddNewtonsoftJson().AddXmlDataContractSerializerFormatters();


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
