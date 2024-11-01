using CompanyWebSite.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.DataAccess.EntityConfiguration
{
    public class ServiceCategoryConfiguration : IEntityTypeConfiguration<ServiceCategory>
    {
        public void Configure(EntityTypeBuilder<ServiceCategory> builder)
        {
            builder.ToTable(nameof(ServiceCategory));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.HasData(
                new ServiceCategory { Id = 1, Name = "Web Geliştirme" },
                new ServiceCategory { Id = 2, Name = "Mobil Geliştirme" },
                new ServiceCategory { Id = 3, Name = "Oyun Geliştirme" },
                new ServiceCategory { Id = 4, Name = "API Entegrasyonu" },
                new ServiceCategory { Id = 5, Name = "CRM Çözümleri" },
                new ServiceCategory { Id = 6, Name = "ERP Çözümleri" },
                new ServiceCategory { Id = 7, Name = "Veritabanı Yönetimi" },
                new ServiceCategory { Id = 8, Name = "Sistem Analizi" },
                new ServiceCategory { Id = 9, Name = "Proje Yönetimi" },
                new ServiceCategory { Id = 10, Name = "Bulut Çözümleri" }
                );
        }
    }
}
