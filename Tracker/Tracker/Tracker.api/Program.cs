using Microsoft.EntityFrameworkCore;
using Tracker.application.Interfaces;
using Tracker.infrastructure.Services;
using Tracker.persistence;
using Tracker.persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//builder.Services.AddPersistenceServices(builder.Configuration);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var x = builder.Configuration.GetConnectionString("TrackerConnection");
Console.WriteLine(x);

builder.Services.AddDbContext<TrackerDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("TrackerConnection")));

builder.Services.AddScoped<IVehicleRepository, VehicleRepository>();
builder.Services.AddScoped<VehicleService>();

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
