using Netflix.Api.Application.Extensions;
using Netflix.Api.Application.Services.Repositories;
using Netflix.Infrastructure.Persistance;
using Netflix.Infrastructure.Persistance.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(x =>
{
    x.ModelValidatorProviders.Clear();
});
builder.Services.AddPersistanceServices(builder.Configuration);

builder.Services.AddApplicationServices();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
