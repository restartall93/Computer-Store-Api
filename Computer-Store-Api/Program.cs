using Computer_Store_Api.Common;
using Computer_Store_Api.Database;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using ConfigurationManager = Microsoft.Extensions.Configuration.ConfigurationManager;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

IWebHostEnvironment environment = builder.Environment;


// Connect db
var apiOption = builder.Configuration.GetSection("ApiOptions").Get<ApiOption>();
builder.Services.AddSingleton(apiOption);
builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseMySql(apiOption.linkDB, MySqlServerVersion.LatestSupportedServerVersion));

// cors

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseStaticFiles();
    app.UseCors();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
