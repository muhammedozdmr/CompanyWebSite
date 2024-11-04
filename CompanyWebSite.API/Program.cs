using CompanyWebSite.Business;
using CompanyWebSite.Business.Repository;
using CompanyWebSite.Business.Repository.Interface;
using CompanyWebSite.Business.Services;
using CompanyWebSite.Business.Services.Interface;
using CompanyWebSite.DataAccess;
using CompanyWebSite.Domain.Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// ConnectionString'i appsettings.json'dan ?ekiyoruz
builder.Services.AddDbContext<CompanyWebSiteContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddAutoMapper(typeof(MappingProfile));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddScoped<ITranslationService, TranslationService>();
builder.Services.AddScoped<ITranslationRepository, TranslationRepository>();
builder.Services.AddScoped<ILanguageRepository, LanguageRepository>();
builder.Services.AddScoped<IAboutService, AboutService>();
builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

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
