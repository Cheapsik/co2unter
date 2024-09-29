using co2unter.API;
using co2unter.API.Interfaces;
using co2unter.API.Repositories;
using co2unter.API.Services;
using co2unter.API.Settings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ITransportEmissionsRepository, TransportEmissionsRepository>();
builder.Services.AddScoped<IServiceEmissionsRepository, ServiceEmissionsRepository>();
builder.Services.AddScoped<ITreeEmissionEffectivityCalculateService, TreeEmissionEffectivityCalculateService>();
builder.Services.AddScoped<IMassEventRepository, MassEventRepository>();
builder.Services.AddScoped<IGreenAreaRepository, GreenAreaRepository>();

builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.Configure<CarbonEmissionSettings>(builder.Configuration.GetSection("CarbonEmissionSettings"));
builder.Services.Configure<OpenWeatherMapSettings>(builder.Configuration.GetSection("OpenWeatherMapSettings"));

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
