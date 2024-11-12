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
    public class CompanyInfoConfiguration : IEntityTypeConfiguration<CompanyInfo>
    {
        public void Configure(EntityTypeBuilder<CompanyInfo> builder)
        {
            builder.ToTable(nameof(CompanyInfo));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CompanyLogoUrl).HasMaxLength(250);
            builder.Property(x => x.CompanyName).HasMaxLength(100).IsRequired();
            builder.Property(x => x.CompanyArea).HasMaxLength(150).IsRequired();
            builder.Property(x => x.CreateDate).IsRequired();
            builder.Property(x => x.Residence).HasMaxLength(100);
            builder.Property(x => x.Address).HasMaxLength(300);
            builder.Property(x => x.Email).HasMaxLength(100);
            builder.Property(x => x.Phone).HasMaxLength(20);
            builder.Property(x => x.LinkedIn).HasMaxLength(200);
            builder.Property(x => x.Twitter).HasMaxLength(200);
            builder.Property(x => x.Facebook).HasMaxLength(200);
            builder.Property(x => x.Instagram).HasMaxLength(200);

            builder.HasData(
                new CompanyInfo
                {
                    Id = 1,
                    CompanyLogoUrl = "images/company_logo.jpg",
                    CompanyName = "TechLiberty",
                    CompanyArea = "Sağlık ve Teknoloji Hizmetleri Limited Şirketi",
                    WorkingHours = "Pazartesi - Cuma: 09:00 - 18:00",
                    CreateDate = new DateTime(2023, 10, 29),
                    Residence = "İstanbul / Türkiye",
                    Address = "Küplüce Mahallesi 5. Zeytinlik Sokak No:13/A 34676 Üsküdar",
                    Email = "info@techliberty.co",
                    Phone = "+90 (543) 233 33 32",
                    LinkedIn = "https://linkedin.com/company/techlibertyco",
                    Twitter = "https://twitter.com/techlibertyco",
                    Facebook = "https://facebook.com/techlibertyco",
                    Instagram = "https://instagram.com/techlibertyco"
                });
        }
    }
}
