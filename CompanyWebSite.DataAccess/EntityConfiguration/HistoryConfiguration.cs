﻿using CompanyWebSite.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.DataAccess.EntityConfiguration
{
    public class HistoryConfiguration : IEntityTypeConfiguration<History>
    {
        public void Configure(EntityTypeBuilder<History> builder)
        {
            builder.ToTable(nameof(History));
            builder.HasKey(h => h.Id);
            builder.Property(x => x.DefaultTitle).HasMaxLength(100).IsRequired();
            builder.Property(x => x.DefaultContent).HasMaxLength(500).IsRequired();
            builder.Property(x => x.Slug).HasMaxLength(100).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(h => h.Year).IsRequired();
            builder.Property(h => h.YearDescription).IsRequired().HasMaxLength(2000);
            builder.HasOne(h => h.About).WithMany(a=>a.Histories).HasForeignKey(h => h.AboutId).OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
                new History
                {
                    Id = 1,
                    DefaultTitle = "Şirketimizin Tarihi",
                    DefaultContent = "TechLiberty'nin kuruluşundan bu yana hedeflediğimiz vizyon ve projelerle büyümemize dair detayları burada bulabilirsiniz.",
                    IsActive = true,
                    Slug = "our-history",
                    Year = 2023,
                    YearDescription = "TechLiberty Software Solutions, 29 Ekim 2023 tarihinde, özel sektördeki ERP çözümlerinin eksikliklerini gidermek amacıyla kuruldu. Kurucumuz, sektördeki firmaların verimliliğini artırmak ve dijital dönüşümlerine katkıda bulunmak için yeni nesil yazılım çözümleri geliştirme hedefiyle yola çıktı.",
                    AboutId = 1
                },
                new History
                {
                    Id = 2,
                    DefaultTitle = "Şirketimizin Tarihi",
                    DefaultContent = "TechLiberty'nin kuruluşundan bu yana hedeflediğimiz vizyon ve projelerle büyümemize dair detayları burada bulabilirsiniz.",
                    IsActive = true,
                    Slug = "expanding-our-vision",
                    Year = 2024,
                    YearDescription = "TechLiberty, kurucusunun sevgili köpeği Gofret’ten ilham alınarak geliştirdiği 'Gof Games' projesini duyurdu. Bu oyun, oyunculara hem eğlenceli hem de duygusal bir deneyim sunmayı hedefliyor. Aynı zamanda, ERP çözümleri alanında sektördeki işletmelere değer katan yazılımlar geliştirme sürecine hız verdik. Mevcut ERP sistemlerindeki eksiklikleri gidermek için daha esnek, kullanımı kolay ve güçlü bir çözüm üzerinde çalışıyoruz.",
                    ProjectUrl = "https://www.gofgames.com.tr",
                    AboutId = 1
                },
                new History
                {
                    Id = 3,
                    DefaultTitle = "Şirketimizin Tarihi",
                    DefaultContent = "TechLiberty'nin kuruluşundan bu yana hedeflediğimiz vizyon ve projelerle büyümemize dair detayları burada bulabilirsiniz.",
                    IsActive = true,
                    Slug = "ongoing-innovation",
                    Year = 2024,
                    YearDescription = "TechLiberty olarak teknoloji ve inovasyonu işimizin merkezine koyduk. Şirketlerin dijital dönüşümlerine destek olmak, süreçlerini optimize etmek ve onlara değer katmak için sürekli yenilikçi çözümler sunuyoruz. Mevcut projelerimize ek olarak, küçük ve orta ölçekli işletmelere yönelik veri odaklı ERP çözümleri ile sektörün ihtiyaçlarını karşılamaya devam ediyoruz.",
                    AboutId = 1
                },
                new History
                {
                    Id = 4,
                    DefaultTitle = "Şirketimizin Tarihi",
                    DefaultContent = "TechLiberty'nin kuruluşundan bu yana hedeflediğimiz vizyon ve projelerle büyümemize dair detayları burada bulabilirsiniz.",
                    IsActive = true,
                    Slug = "construction-innovation",
                    Year = 2024,
                    YearDescription = "Şantiye Bul projesi, küçük ve orta ölçekli işletmeleri (KOBİ) büyük şantiyeler ve inşaat projeleriyle bir araya getirmeyi hedefleyen yenilikçi bir girişimdir. Bu proje, devlet kontrol mekanizmalarının etkinliğini en üst seviyeye çıkararak, KOBİ'lerin kalkınmasını desteklemeyi ve ülke genelinde daha güvenli ve kaliteli yapılar inşa edilmesini sağlamayı amaçlamaktadır. Şantiye Bul projesi ile birlikte, deprem risklerini azaltmak, kaçak yapılaşmayı önlemek, ucuz işçilikle oluşan riskleri minimuma indirmek ve düşük kaliteli malzeme kullanımını kontrol altına almak mümkün hale gelecektir. Böylece, hem sektör standartları yükselecek hem de ülke çapında daha sağlam, güvenilir ve sürdürülebilir yapılar ortaya çıkacaktır. Bu girişim, Türkiye’nin inşaat sektöründe kaliteyi ve güvenliği artırmak adına atılan önemli bir adımdır.",
                    ProjectUrl = "https://www.santiyebul.com",
                    AboutId = 1
                }
            );
        }
    }
}
