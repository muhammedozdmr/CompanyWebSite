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
    public class MediaConfiguration : IEntityTypeConfiguration<Media>
    {
        public void Configure(EntityTypeBuilder<Media> builder)
        {
            builder.ToTable(nameof(Media));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FilePath).IsRequired().HasMaxLength(200);
            builder.Property(x => x.MediaType).IsRequired().HasMaxLength(50);
            builder.HasOne(x => x.Service).WithMany(x => x.MediaItems).HasForeignKey(x => x.ServiceId);
            builder.HasData(
                //TODO: iconları yeniden bul ve tasarla
                //TODO: icon hex kodları: #00d1ff #3663d8 #77beff boyut 60x60
                 new Media { Id = 1, FilePath = "images/web-dev-icon.jpg", MediaType = "icon", ServiceId = 1 },
                new Media { Id = 2, FilePath = "images/web-dev-image.jpg", MediaType = "image", ServiceId = 1 },
                new Media { Id = 3, FilePath = "images/mobile-dev-icon.jpg", MediaType = "icon", ServiceId = 2 },
                new Media { Id = 4, FilePath = "images/mobile-dev-image.jpg", MediaType = "image", ServiceId = 2 },
                new Media { Id = 5, FilePath = "images/game-dev-icon.jpg", MediaType = "icon", ServiceId = 3 },
                new Media { Id = 6, FilePath = "images/game-dev-image.jpg", MediaType = "image", ServiceId = 3 },
                 new Media { Id = 7, FilePath = "images/api-icon.jpg", MediaType = "icon", ServiceId = 4 },
                new Media { Id = 8, FilePath = "images/api-image.jpg", MediaType = "image", ServiceId = 4 },
                new Media { Id = 9, FilePath = "images/crm-icon.jpg", MediaType = "icon", ServiceId = 5 },
                new Media { Id = 10, FilePath = "images/crm-image.jpg", MediaType = "image", ServiceId = 5 },
                 new Media { Id = 11, FilePath = "images/erp-icon.jpg", MediaType = "icon", ServiceId = 6 },
                new Media { Id = 12, FilePath = "images/erp-image.jpg", MediaType = "image", ServiceId = 6 },
                new Media { Id = 13, FilePath = "images/db-icon.jpg", MediaType = "icon", ServiceId = 7 },
                new Media { Id = 14, FilePath = "images/db-image.jpg", MediaType = "image", ServiceId = 7 },
                new Media { Id = 15, FilePath = "images/system-analysis-icon.jpg", MediaType = "icon", ServiceId = 8 },
                new Media { Id = 16, FilePath = "images/system-analysis-image.jpg", MediaType = "image", ServiceId = 8 },
                 new Media { Id = 17, FilePath = "images/project-management-icon.jpg", MediaType = "icon", ServiceId = 9 },
                new Media { Id = 18, FilePath = "images/project-management-image.jpg", MediaType = "image", ServiceId = 9 },
                new Media { Id = 19, FilePath = "images/cloud-icon.jpg", MediaType = "icon", ServiceId = 10 },
                new Media { Id = 20, FilePath = "images/cloud-image.jpg", MediaType = "image", ServiceId = 10 }
                );
        }
    }
}
