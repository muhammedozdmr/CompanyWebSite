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
    public class FAQConfiguration : IEntityTypeConfiguration<FAQ>
    {
        public void Configure(EntityTypeBuilder<FAQ> builder)
        {
            builder.ToTable(nameof(FAQ));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.DefaultTitle).HasMaxLength(100).IsRequired();
            builder.Property(x => x.DefaultContent).HasColumnType("nvarchar(max)").IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.Slug).HasMaxLength(300).IsRequired();
            builder.Property(x => x.Question).IsRequired().HasMaxLength(350);
            builder.Property(x => x.Answer).IsRequired().HasMaxLength(500);

            builder.HasData(
                new FAQ
                {
                    Id = 1,
                    DefaultTitle = "Sıkça Sorulan Sorular",
                    DefaultContent = "Hizmetlerimiz ve şirketimiz hakkında sıkça sorulan soruların yanıtlarını burada bulabilirsiniz.",
                    IsActive = true,
                    Slug = "what-is-techliberty",
                    Question = "TechLiberty nedir?",
                    Answer = "TechLiberty, yazılım çözümleri sunan ve dijital dönüşüm süreçlerinde işletmelere destek veren bir teknoloji firmasıdır."
                },
                new FAQ
                {
                    Id = 2,
                    DefaultTitle = "Sıkça Sorulan Sorular",
                    DefaultContent = "Hizmetlerimiz ve şirketimiz hakkında sıkça sorulan soruların yanıtlarını burada bulabilirsiniz.",
                    IsActive = true,
                    Slug = "which-services-do-you-offer",
                    Question = "Hangi hizmetleri sunuyorsunuz?",
                    Answer = "Mobil ve web uygulama geliştirme, oyun geliştirme, API entegrasyonu, CRM ve ERP çözümleri, veri tabanı yönetimi ve sistem analizi hizmetleri sunuyoruz."
                },
                new FAQ
                {
                    Id = 3,
                    DefaultTitle = "Sıkça Sorulan Sorular",
                    DefaultContent = "Hizmetlerimiz ve şirketimiz hakkında sıkça sorulan soruların yanıtlarını burada bulabilirsiniz.",
                    IsActive = true,
                    Slug = "how-can-i-contact-you",
                    Question = "Sizinle nasıl iletişime geçebilirim?",
                    Answer = "Bize e-posta (info@techliberty.co) veya telefon (+90 (543) 233 33 32) üzerinden ulaşabilirsiniz. Ayrıca sosyal medya hesaplarımız üzerinden de iletişime geçebilirsiniz."
                },
                new FAQ
                {
                    Id = 4,
                    DefaultTitle = "Sıkça Sorulan Sorular",
                    DefaultContent = "Hizmetlerimiz ve şirketimiz hakkında sıkça sorulan soruların yanıtlarını burada bulabilirsiniz.",
                    IsActive = true,
                    Slug = "what-is-the-process-of-a-project",
                    Question = "Bir proje süreci nasıl ilerliyor?",
                    Answer = "Projelerimiz analiz, tasarım, geliştirme, test ve teslim aşamalarından oluşur. Her aşamada müşteriyle yakın iletişim halinde oluruz."
                },
                new FAQ
                {
                    Id = 5,
                    DefaultTitle = "Sıkça Sorulan Sorular",
                    DefaultContent = "Hizmetlerimiz ve şirketimiz hakkında sıkça sorulan soruların yanıtlarını burada bulabilirsiniz.",
                    IsActive = true,
                    Slug = "do-you-offer-support-after-delivery",
                    Question = "Proje tesliminden sonra destek sağlıyor musunuz?",
                    Answer = "Evet, projelerimiz teslim edildikten sonra bakım ve destek hizmetleri sunmaktayız. Projenizin başarılı bir şekilde devam etmesi için her türlü yardımı sağlıyoruz."
                },
                new FAQ
                {
                    Id = 6,
                    DefaultTitle = "Sıkça Sorulan Sorular",
                    DefaultContent = "Hizmetlerimiz ve şirketimiz hakkında sıkça sorulan soruların yanıtlarını burada bulabilirsiniz.",
                    IsActive = true,
                    Slug = "what-industries-do-you-serve",
                    Question = "Hangi sektörlere hizmet veriyorsunuz?",
                    Answer = "Finans, sağlık, eğitim, perakende, üretim ve lojistik gibi birçok sektöre yönelik yazılım çözümleri sunuyoruz."
                },
                new FAQ
                {
                    Id = 7,
                    DefaultTitle = "Sıkça Sorulan Sorular",
                    DefaultContent = "Hizmetlerimiz ve şirketimiz hakkında sıkça sorulan soruların yanıtlarını burada bulabilirsiniz.",
                    IsActive = true,
                    Slug = "how-long-does-a-project-take",
                    Question = "Bir proje ne kadar sürer?",
                    Answer = "Proje süresi, projenin karmaşıklığına ve gereksinimlerine bağlı olarak değişir. Genellikle bir proje birkaç hafta ila birkaç ay sürebilir."
                },
                new FAQ
                {
                    Id = 8,
                    DefaultTitle = "Sıkça Sorulan Sorular",
                    DefaultContent = "Hizmetlerimiz ve şirketimiz hakkında sıkça sorulan soruların yanıtlarını burada bulabilirsiniz.",
                    IsActive = true,
                    Slug = "do-you-have-international-experience",
                    Question = "Uluslararası projelerde deneyiminiz var mı?",
                    Answer = "Evet, yurt dışındaki birçok müşteriyle projeler gerçekleştirdik ve uluslararası iş süreçlerine aşinayız."
                },
                new FAQ
                {
                    Id = 9,
                    DefaultTitle = "Sıkça Sorulan Sorular",
                    DefaultContent = "Hizmetlerimiz ve şirketimiz hakkında sıkça sorulan soruların yanıtlarını burada bulabilirsiniz.",
                    IsActive = true,
                    Slug = "what-technologies-do-you-use",
                    Question = "Hangi teknolojileri kullanıyorsunuz?",
                    Answer = "Proje gereksinimlerine bağlı olarak .NET, Java, Python, React, Angular, Flutter gibi çeşitli yazılım dillerini ve araçlarını kullanıyoruz."
                },
                new FAQ
                {
                    Id = 10,
                    DefaultTitle = "Sıkça Sorulan Sorular",
                    DefaultContent = "Hizmetlerimiz ve şirketimiz hakkında sıkça sorulan soruların yanıtlarını burada bulabilirsiniz.",
                    IsActive = true,
                    Slug = "how-do-you-ensure-data-security",
                    Question = "Veri güvenliğini nasıl sağlıyorsunuz?",
                    Answer = "Güvenlik protokolleri ve en iyi uygulamalar ile veri güvenliğini sağlıyoruz. Veri şifreleme, güvenli API ve erişim kontrolleri gibi önlemler alıyoruz."
                }
            );
        }
    }
}
