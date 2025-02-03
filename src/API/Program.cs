using API;
using Infrastructure;
using API.Endpoints;
using Infrastructure.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddMediatR();
builder.Services.AddDbContext();

builder.Services.AddIdentity();

builder.Services.Configure<HamsterDbContextOptions>(builder.Configuration.GetSection("HamsterDbContextOptions"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapEndpoints();

app.Run();