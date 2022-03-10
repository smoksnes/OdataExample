using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
const string con = @"Server=(localdb)\mssqllocaldb;Database=ExampleDb;Trusted_Connection=True";

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MyContext>(opt => opt.UseSqlServer(con));
builder.Services
    .AddControllers()
    .AddOData(opt => opt.AddRouteComponents("odata", WebApplication1.Models.EdmModel.GetConventionModel()).Filter().Select().Expand())
    ;

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

