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
    public class PageConfiguration : IEntityTypeConfiguration<Page>
    {
        public void Configure(EntityTypeBuilder<Page> builder)
        {
            builder.ToTable(nameof(Page));
            builder.HasKey(x => x.Id);

            builder.Property(x => x.PageHeaderTitle).HasMaxLength(100);
            builder.Property(x => x.PageHeaderSubtitle).HasMaxLength(500);
            builder.Property(x => x.PageMainSlogan).HasMaxLength(300);
            builder.Property(x => x.PageSubSlogan).HasMaxLength(300);

            builder.HasOne(x => x.NavbarItems)
                .WithMany(x => x.Pages)
                .HasForeignKey(x => x.NavbarId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
                new Page { Id = 1, NavbarId = 2, PageHeaderTitle = "Hakkımızda", PageHeaderSubtitle = "Deneyimimizle Tanışın. Başarı Hikayelerimizi Keşfedin." },
                new Page { Id = 2, NavbarId = 3, PageHeaderTitle = "Hizmetler", PageHeaderSubtitle = "Hayalinizdeki Dijital Dünyayı Gerçekleştiren Yaratıcı Hizmetler" },
                new Page { Id = 3, NavbarId = 4, PageHeaderTitle = "Blog", PageHeaderSubtitle = "İlham Veren Hikayeler ve Uzman Görüşleri" },
                new Page
                {
                    Id = 4,
                    NavbarId = 4,
                    PageHeaderTitle = "Blog",
                    PageHeaderSubtitle = "Hikayenin Arkasındaki Detayları Keşfedin"
                },
                new Page { Id = 5, NavbarId = 5, PageHeaderTitle = "İletişim", PageHeaderSubtitle = "Sorularınızı Yanıtlamak ve Size Destek Olmak İçin Buradayız", PageMainSlogan= "Bize Ulaşın. Dijital çözümlerle geleceği inşa edelim.",PageSubSlogan= "Her büyük başarı bir adımla başlar. O adımı şimdi atın." },
                new Page { Id = 6, NavbarId = 6, PageHeaderTitle = "SSS", PageHeaderSubtitle = "Aklınızdaki sorulara cevap bulmak için doğru yerdesiniz." }
                );
        }
    }
}
