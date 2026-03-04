using Cache;
using Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.OpenApi;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using System.Text.Json;


var builder = WebApplication.CreateBuilder(args);

builder.Services.ApplyDataManager(builder.Configuration);

builder.Services.AddCaching(builder.Configuration);

builder.Services.AddProblemDetails();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options =>
{});

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
});

builder.Services.AddOpenApi();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseRouting();

app.MapControllers();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run();
