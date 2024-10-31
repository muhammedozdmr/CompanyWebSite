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
    public class ServiceConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.ToTable(nameof(Service));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.DefaultTitle).HasMaxLength(250);
            builder.Property(x => x.DefaultContent).HasMaxLength(500);
            builder.Property(x => x.Slug).HasMaxLength(100);
            builder.Property(x => x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.ServiceSummary).HasMaxLength(250);
            builder.HasMany(x => x.Categories).WithMany(x => x.Services).UsingEntity(y => y.ToTable("ServiceCategories"));
            builder.HasMany(x => x.MediaItems).WithOne(y => y.Service).HasForeignKey(y => y.ServiceId);

            builder.HasData
            (
                new Service
                {
                    Id = 1,
                    DefaultTitle = "Web Geliştirme",
                    DefaultContent = "Profesyonel web geliştirme hizmetleri sunarak web projenizi planlamanıza, oluşturmanıza, yönetmenize ve pazarlamanıza yardımcı oluyoruz.",
                    IsActive = true,
                    Slug = "web-development",
                    ServiceSummary = "Web projeleri için profesyonel web geliştirme hizmetleri sunuyoruz.",
                    Categories = new List<Category>
                    {
                new Category { Id = 1, Name = "Web Geliştirme" }
                    },
                    MediaItems = new List<Media>
                    {
                new Media { Id = 1, FilePath = "images/web-dev-icon.jpg", MediaType = "icon", ServiceId = 1 },
                new Media { Id = 2, FilePath = "images/web-dev-image.jpg", MediaType = "image", ServiceId = 1 }
                    }
                },
                new Service
                {
                    Id = 2,
                    DefaultTitle = "Mobil Uygulama Geliştirme",
                    DefaultContent = "Mobil uygulama geliştirme sürecini destekleyen kapsamlı hizmetler sunuyoruz. iOS ve Android platformlarında kullanıcı dostu uygulamalar geliştirin.",
                    IsActive = true,
                    Slug = "mobile-app-development",
                    ServiceSummary = "Kullanıcı dostu mobil uygulama geliştirme hizmetleri sunuyoruz.",
                    Categories = new List<Category>
                    {
                new Category { Id = 2, Name = "Mobil Geliştirme" }
                    },
                    MediaItems = new List<Media>
                    {
                new Media { Id = 3, FilePath = "images/mobile-dev-icon.jpg", MediaType = "icon", ServiceId = 2 },
                new Media { Id = 4, FilePath = "images/mobile-dev-image.jpg", MediaType = "image", ServiceId = 2 }
                    }
                },
                new Service
                {
                    Id = 3,
                    DefaultTitle = "Oyun Geliştirme",
                    DefaultContent = "İleri teknolojilerle oyun geliştirme hizmetleri sunarak eğlenceli ve interaktif oyunlar yaratmanıza yardımcı oluyoruz.",
                    IsActive = true,
                    Slug = "game-development",
                    ServiceSummary = "İnteraktif oyun geliştirme hizmetleri sunuyoruz.",
                    Categories = new List<Category>
                    {
                new Category { Id = 3, Name = "Oyun Geliştirme" }
                    },
                    MediaItems = new List<Media>
                    {
                new Media { Id = 5, FilePath = "images/game-dev-icon.jpg", MediaType = "icon", ServiceId = 3 },
                new Media { Id = 6, FilePath = "images/game-dev-image.jpg", MediaType = "image", ServiceId = 3 }
                    }
                },
                new Service
                {
                    Id = 4,
                    DefaultTitle = "API Entegrasyonu",
                    DefaultContent = "Farklı sistemlerin entegrasyonunu sağlayarak veri akışını optimize eden API geliştirme ve entegrasyon hizmetleri sunuyoruz.",
                    IsActive = true,
                    Slug = "api-integration",
                    ServiceSummary = "Veri akışını optimize eden API entegrasyon hizmetleri.",
                    Categories = new List<Category>
                    {
                new Category { Id = 4, Name = "API Entegrasyonu" }
                    },
                    MediaItems = new List<Media>
                    {
                new Media { Id = 7, FilePath = "images/api-icon.jpg", MediaType = "icon", ServiceId = 4 },
                new Media { Id = 8, FilePath = "images/api-image.jpg", MediaType = "image", ServiceId = 4 }
                    }
                },
                new Service
                {
                    Id = 5,
                    DefaultTitle = "CRM Çözümleri",
                    DefaultContent = "Müşteri ilişkilerini geliştirmek ve süreçleri yönetmek için kapsamlı CRM çözümleri sunuyoruz.",
                    IsActive = true,
                    Slug = "crm-solutions",
                    ServiceSummary = "Kapsamlı CRM çözümleri ile müşteri ilişkilerini yönetin.",
                    Categories = new List<Category>
                    {
                new Category { Id = 5, Name = "CRM Çözümleri" }
                    },
                    MediaItems = new List<Media>
                    {
                new Media { Id = 9, FilePath = "images/crm-icon.jpg", MediaType = "icon", ServiceId = 5 },
                new Media { Id = 10, FilePath = "images/crm-image.jpg", MediaType = "image", ServiceId = 5 }
                    }
                },
                new Service
                {
                    Id = 6,
                    DefaultTitle = "ERP Çözümleri",
                    DefaultContent = "İş süreçlerini yönetmek ve verimliliği artırmak için gelişmiş ERP çözümleri sunuyoruz.",
                    IsActive = true,
                    Slug = "erp-solutions",
                    ServiceSummary = "İş süreçlerini yöneten gelişmiş ERP çözümleri.",
                    Categories = new List<Category>
                    {
                new Category { Id = 6, Name = "ERP Çözümleri" }
                    },
                    MediaItems = new List<Media>
                    {
                new Media { Id = 11, FilePath = "images/erp-icon.jpg", MediaType = "icon", ServiceId = 6 },
                new Media { Id = 12, FilePath = "images/erp-image.jpg", MediaType = "image", ServiceId = 6 }
                    }
                },
                new Service
                {
                    Id = 7,
                    DefaultTitle = "Veritabanı Yönetim Sistemleri",
                    DefaultContent = "Güvenli ve ölçeklenebilir veritabanı yönetim sistemleriyle verilerinizi etkin şekilde yönetin.",
                    IsActive = true,
                    Slug = "database-management",
                    ServiceSummary = "Verilerinizi etkin şekilde yönetmeniz için veritabanı çözümleri.",
                    Categories = new List<Category>
                    {
                new Category { Id = 7, Name = "Veritabanı Yönetimi" }
                    },
                    MediaItems = new List<Media>
                    {
                new Media { Id = 13, FilePath = "images/db-icon.jpg", MediaType = "icon", ServiceId = 7 },
                new Media { Id = 14, FilePath = "images/db-image.jpg", MediaType = "image", ServiceId = 7 }
                    }
                },
                new Service
                {
                    Id = 8,
                    DefaultTitle = "Sistem Analizi ve Tasarımı",
                    DefaultContent = "İş süreçlerinizi analiz ederek ihtiyaçlarınıza uygun sistem tasarımları sunuyoruz.",
                    IsActive = true,
                    Slug = "system-analysis",
                    ServiceSummary = "İş süreçlerinize özel sistem analizi ve tasarım hizmetleri.",
                    Categories = new List<Category>
                    {
                new Category { Id = 8, Name = "Sistem Analizi" }
                    },
                    MediaItems = new List<Media>
                    {
                new Media { Id = 15, FilePath = "images/system-analysis-icon.jpg", MediaType = "icon", ServiceId = 8 },
                new Media { Id = 16, FilePath = "images/system-analysis-image.jpg", MediaType = "image", ServiceId = 8 }
                    }
                },
                new Service
                {
                    Id = 9,
                    DefaultTitle = "Proje Yönetimi",
                    DefaultContent = "Projelerinizi etkin bir şekilde yönetmenize yardımcı olacak profesyonel proje yönetimi çözümleri sunuyoruz.",
                    IsActive = true,
                    Slug = "project-management",
                    ServiceSummary = "Projelerinizi başarıya ulaştırmak için proje yönetimi çözümleri.",
                    Categories = new List<Category>
                    {
                new Category { Id = 9, Name = "Proje Yönetimi" }
                    },
                    MediaItems = new List<Media>
                    {
                new Media { Id = 17, FilePath = "images/project-management-icon.jpg", MediaType = "icon", ServiceId = 9 },
                new Media { Id = 18, FilePath = "images/project-management-image.jpg", MediaType = "image", ServiceId = 9 }
                    }
                },
                new Service
                {
                    Id = 10,
                    DefaultTitle = "Bulut Çözümleri",
                    DefaultContent = "Veri depolama ve yönetimi için ölçeklenebilir ve güvenilir bulut çözümleri sunuyoruz.",
                    IsActive = true,
                    Slug = "cloud-solutions",
                    ServiceSummary = "Güvenilir ve ölçeklenebilir bulut çözümleri ile verilerinizi yönetin.",
                    Categories = new List<Category>
                    {
                new Category { Id = 10, Name = "Bulut Çözümleri" }
                    },
                    MediaItems = new List<Media>
                    {
                new Media { Id = 19, FilePath = "images/cloud-icon.jpg", MediaType = "icon", ServiceId = 10 },
                new Media { Id = 20, FilePath = "images/cloud-image.jpg", MediaType = "image", ServiceId = 10 }
                    }
                }
            );
        }
    }
}
