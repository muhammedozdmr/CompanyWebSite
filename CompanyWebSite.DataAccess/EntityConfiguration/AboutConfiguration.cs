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
    public class AboutConfiguration : IEntityTypeConfiguration<About>
    {
        public void Configure(EntityTypeBuilder<About> builder)
        {
            builder.ToTable(nameof(About));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.DefaultTitle).HasMaxLength(100).IsRequired();
            builder.Property(x => x.DefaultContent).HasColumnType("nvarchar(max)").IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.Slug).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Summary).HasMaxLength(500).IsRequired();
            builder.HasOne(x => x.CompanyInfo).WithMany().HasForeignKey(x => x.CompanyInfoId).OnDelete(DeleteBehavior.Cascade);

            //Seed Data
            builder.HasData(
                new About
                {
                    Id = 1,
                    AboutSlogan = "En İyisi Sizin İçin",
                    DefaultTitle = "Hakkımızda",
                    DefaultContent = "TechLiberty Software Solutions olarak, 29 Ekim 2023 tarihinde kurulan şirketimiz, müşterilerine teknolojik çözümler sunma misyonunu benimsemiştir. Dijital çağın gereksinimlerine uygun olarak mobil uygulamalar, web projeleri, oyun geliştirme, proje yönetimi, SEO optimizasyonu, API servisleri, CRM ve ERP hizmetleri, veri tabanı yönetim sistemleri ve sistem analizi gibi geniş bir yelpazede profesyonel çözümler sunmaktayız. Deneyimli ve yenilikçi ekibimizle, işletmelerin dijital dönüşüm yolculuğunda güvenilir bir iş ortağı olarak yer alıyoruz. Amacımız, müşterilerimize sürdürülebilir başarıyı getirecek, verimli ve ölçeklenebilir çözümler sunarak değer katmaktır.",
                    IsActive = true,
                    Slug = "about-us",
                    Summary = "TechLiberty Software Solutions, mobil uygulamalar, web projeleri, oyun geliştirme ve kurumsal çözümler sunarak işletmelerin dijital dönüşüm süreçlerinde güvenilir bir iş ortağıdır.",
                    CompanyInfoId = 1
                }
            );
        }
    }
}
