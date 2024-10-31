using CompanyWebSite.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.DataAccess.EntityConfiguration
{
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.ToTable(nameof(Language));
            builder.HasKey(l => l.Id);
            builder.Property(l => l.Name).IsRequired().HasMaxLength(100);
            builder.Property(l => l.Code).IsRequired().HasMaxLength(10); // ISO dil kodu (örneğin: "en", "tr")

            // Seed Data
            builder.HasData(
                new Language { Id = 1, Name = "Turkish", Code = "tr" },
                new Language { Id = 2, Name = "English", Code = "en" },
                new Language { Id = 3, Name = "German", Code = "de" },
                new Language { Id = 4, Name = "Russian", Code = "ru" }
            );
        }
    }
}
