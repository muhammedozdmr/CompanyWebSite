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
    public class BlogCategoryConfiguration : IEntityTypeConfiguration<BlogCategory>
    {
        public void Configure(EntityTypeBuilder<BlogCategory> builder)
        {
            builder.ToTable(nameof(BlogCategory));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.HasData(
                new BlogCategory { Id = 1, Name = "Yazılım" },
                new BlogCategory { Id = 2, Name = "Geliştirme" },
                new BlogCategory { Id = 3, Name = "Mobil Uygulama" },
                new BlogCategory { Id = 4, Name = "API" },
                new BlogCategory { Id = 5, Name = "Veri Güvenliği" },
                new BlogCategory { Id = 6, Name = "ERP" },
                new BlogCategory { Id = 7, Name = "İşletme Yönetimi" },
                new BlogCategory { Id = 8, Name = "Oyun Geliştirme" },
                new BlogCategory { Id = 9, Name = "Teknoloji" },
                new BlogCategory { Id = 10, Name = "Web Geliştirme" },
                new BlogCategory { Id = 11, Name = "PWA" }
                );
        }
    }
}
