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
                new Page { Id = 1, NavbarId = 2, PageContentTitle="Hakkımızda",PageHeaderTitle = "Hakkımızda", PageHeaderSubtitle = "Deneyimimizle Tanışın. Başarı Hikayelerimizi Keşfedin.", PageMainSlogan= "En İyisi Sizin İçin"},
                new Page { Id = 2, NavbarId = 3,PageContentTitle="Hizmetler" ,PageHeaderTitle = "Hizmetler", PageHeaderSubtitle = "Hayalinizdeki Dijital Dünyayı Gerçekleştiren Yaratıcı Hizmetler" },
                new Page { Id = 3, NavbarId = 4,PageContentTitle="Blog", PageHeaderTitle = "Blog", PageHeaderSubtitle = "İlham Veren Hikayeler ve Uzman Görüşleri" },
                new Page { Id = 4, NavbarId = 4,PageContentTitle="Blog", PageHeaderTitle = "Blog", PageHeaderSubtitle = "Hikayenin Arkasındaki Detayları Keşfedin" },
                new Page { Id = 5, NavbarId = 5, PageContentTitle="Bize Ulaşın", PageHeaderTitle = "İletişim", PageHeaderSubtitle = "Sorularınızı Yanıtlamak ve Size Destek Olmak İçin Buradayız", PageMainSlogan= "Bize Ulaşın. Dijital çözümlerle geleceği inşa edelim.",PageSubSlogan= "Her büyük başarı bir adımla başlar. O adımı şimdi atın." },
                new Page { Id = 6, NavbarId = 6,PageContentTitle="SSS" ,PageHeaderTitle = "SSS", PageHeaderSubtitle = "Aklınızdaki sorulara cevap bulmak için doğru yerdesiniz.", PageMainSlogan= "Sıkça Sorulan Sorular", PageSubSlogan= "Hizmetlerimiz ve şirketimiz hakkında sıkça sorulan soruların yanıtlarını burada bulabilirsiniz." },
                new Page { Id = 7, NavbarId = 2, PageContentTitle="Hikayemiz", PageMainSlogan="Şirketimizin Tarihi", PageSubSlogan="TechLiberty'nin kuruluşundan bu yana hedeflediğimiz vizyon ve projelerle büyümemize dair detayları burada bulabilirsiniz." },
                new Page { Id = 8, NavbarId = 5, PageContentTitle="İletişim", PageMainSlogan="Desteğe mi ihtiyacınız var? Lütfen iletişim formunu doldurun."},
                new Page { Id = 9, NavbarId = 3, PageContentTitle="Sürecimiz", PageMainSlogan="Başarınızı Artıran Dijital Stratejiler", PageSubSlogan="Mobil ve web uygulama geliştirme, oyun geliştirme, API entegrasyonu, CRM ve ERP çözümleri, veri tabanı yönetimi ve sistem analizi hizmetleri gibi bir çok alanda profesyonel hizmetler sunuyoruz." }
                );
        }
    }
}
