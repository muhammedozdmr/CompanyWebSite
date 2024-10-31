using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CompanyWebSite.DataAccess.Factories
{
    public class CompanyWebSiteContextFactory : IDesignTimeDbContextFactory<CompanyWebSiteContext>
    {
        public CompanyWebSiteContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CompanyWebSiteContext>();

            // appsettings.json'dan connection string'i almak için
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            optionsBuilder.UseSqlServer(connectionString);

            return new CompanyWebSiteContext(optionsBuilder.Options);
        }
    }
}
