using CompanyWebSite.Business.Repository.Interface;
using CompanyWebSite.Business.Repository;
using CompanyWebSite.Business.Services.Interface;
using CompanyWebSite.Business.Services;
using CompanyWebSite.DataAccess;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddDbContext<CompanyWebSiteContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
builder.Services.AddControllersWithViews();

//builder.Services.AddScoped<ITranslationService, TranslationService>();
//builder.Services.AddScoped<ITranslationRepository, TranslationRepository>();
//builder.Services.AddScoped<ILanguageRepository, LanguageRepository>();
//builder.Services.AddScoped<IAboutService, AboutService>();
//builder.Services.AddScoped<IBlogService, BlogService>();
//builder.Services.AddScoped<ICompanyInfoService, CompanyInfoService>();
//builder.Services.AddScoped<IContactFormService, ContactFormService>();
//builder.Services.AddScoped<IContactService, ContactService>();
//builder.Services.AddScoped<IFAQService, FAQService>();
//builder.Services.AddScoped<IHomeService, HomeService>();
//builder.Services.AddScoped<INavbarFooterSidePanelService, NavbarFooterSidePanelService>();
//builder.Services.AddScoped<INavbarItemService, NavbarItemService>();
//builder.Services.AddScoped<INewsletterService, NewsletterService>();
//builder.Services.AddScoped<IServiceService, ServiceService>();
//builder.Services.AddScoped<IFooterService, FooterService>();
//builder.Services.AddScoped<ISidePanelService, SidePanelService>();

//builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
