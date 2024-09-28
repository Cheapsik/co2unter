using co2unter.API.Interfaces;
using co2unter.API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ITransportEmissionsService, TransportEmissionsService>();
builder.Services.AddScoped<IServiceEmissionsService, ServiceEmissionsService>();
builder.Services.AddScoped<ITreeEmissionEffectivityCalculateService, TreeEmissionEffectivityCalculateService>();
builder.Services.AddScoped<ICarbonEmissionService, CarbonEmissionService>();

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
