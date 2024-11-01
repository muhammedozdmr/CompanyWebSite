using CompanyWebSite.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.DataAccess.EntityConfiguration
{
    public class BlogConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.ToTable(nameof(Blog));
            builder.Property(x => x.DefaultTitle).HasMaxLength(300).IsRequired();
            builder.Property(x => x.DefaultContent).HasColumnType("nvarchar(max)").IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.Slug).HasMaxLength(300).IsRequired();
            builder.Property(x => x.ImgageUrl).HasMaxLength(150);
            builder.Property(x => x.AuthorImageUrl).HasMaxLength(150);
            builder.Property(x => x.Author).HasMaxLength(250);
            builder.Property(x => x.AuthorTitle).HasMaxLength(150);
            builder.Property(x => x.PublishDate).IsRequired();
            builder.HasMany(x => x.BlogCategories)
           .WithMany(x => x.Blogs)
           .UsingEntity<Dictionary<string, object>>(
               "BlogCategoryMapping", // Geçici tabloya isim veriyoruz
               j => j.HasOne<BlogCategory>().WithMany().HasForeignKey("BlogCategoriesId"),
               j => j.HasOne<Blog>().WithMany().HasForeignKey("BlogId"),
               j =>
               {
                   j.HasData(
                       new { BlogId = 1, BlogCategoriesId = 1 },
                       new { BlogId = 1, BlogCategoriesId = 2 },
                       new { BlogId = 2, BlogCategoriesId = 3 },
                       new { BlogId = 2, BlogCategoriesId = 2 },
                       new { BlogId = 3, BlogCategoriesId = 4 },
                       new { BlogId = 3, BlogCategoriesId = 5 },
                       new { BlogId = 4, BlogCategoriesId = 6 },
                       new { BlogId = 4, BlogCategoriesId = 7 },
                       new { BlogId = 5, BlogCategoriesId = 8 },
                       new { BlogId = 5, BlogCategoriesId = 9 },
                       new { BlogId = 6, BlogCategoriesId = 10 },
                       new { BlogId = 6, BlogCategoriesId = 11 }
                   );
               }
           );
            builder.HasData(
        new Blog
        {
            Id = 1,
            DefaultTitle = "Yazılım Geliştirmenin Temelleri",
            DefaultContent = "Yazılım geliştirme, bir problemin çözümünü sağlayan programları yaratma sürecidir. Teknolojik yenilikler, yazılım geliştirme süreçlerinde köklü değişiklikler yaratmıştır. Günümüzde, yazılım geliştiriciler kullanıcı dostu arayüzler tasarlamak, verimli algoritmalar oluşturmak ve güvenli veri yönetimi sağlamak için çeşitli araçlar kullanmaktadır. Yazılım geliştirme aşamaları, analiz, tasarım, kodlama, test ve bakım süreçlerinden oluşur. Analiz sürecinde, problemin tanımlanması ve çözüm yöntemlerinin belirlenmesi sağlanır. Tasarım aşamasında, kullanıcı ihtiyaçlarına uygun bir yapı oluşturulur. Kodlama ise yazılımın 'görünmeyen' kısmıdır ve mantık burada yazılır. Test süreci, yazılımın doğru çalışıp çalışmadığını kontrol ederken, bakım süreci yazılımın güncellenmesi ve sorunların çözülmesi için gereklidir. Bu süreçlerin her biri, başarılı bir yazılım geliştirme projesinin temel taşlarını oluşturur.",
            IsActive = true,
            Slug = "foundations-of-software-development",
            ImgageUrl = "images/blog1.jpg",
            AuthorImageUrl = "images/author.jpg",
            Author = "Muhammed Özdemir",
            AuthorTitle = "Yazılım Geliştirici",
            PublishDate = new DateTime(2023, 11, 15)
        },
        new Blog
        {
            Id = 2,
            DefaultTitle = "Mobil Uygulama Geliştirirken Dikkat Edilmesi Gerekenler",
            DefaultContent = "Mobil uygulama geliştirme süreci, tasarımdan kullanıcı deneyimine kadar birçok aşamadan oluşur. Başarılı bir mobil uygulama geliştirmek için, kullanıcıların ihtiyaçlarını anlamak ve onlara değer katacak çözümler sunmak gereklidir. Kullanıcı deneyimi, uygulamanın başarısında kritik bir rol oynar. Ayrıca, uygulamanın platform bağımsız çalışabilmesi ve yüksek performans göstermesi önemlidir. Mobil uygulama geliştirme araçları sayesinde, geliştiriciler hızlı ve etkili bir şekilde uygulamalar yaratabilmektedir. Örneğin, Flutter, React Native gibi araçlar hem iOS hem de Android için uyumlu uygulamalar geliştirmenizi sağlar. Güvenlik de mobil uygulamalar için önemli bir faktördür. Kullanıcı verilerinin güvenliğini sağlamak için gerekli önlemleri almak, uygulamanın uzun vadeli başarısına katkı sağlar. Tüm bu aşamalar, kaliteli bir mobil uygulamanın temel taşlarını oluşturur.",
            IsActive = true,
            Slug = "important-tips-for-mobile-app-development",
            ImgageUrl = "images/blog2.jpg",
            AuthorImageUrl = "images/author.jpg",
            Author = "Muhammed Özdemir",
            AuthorTitle = "Yazılım Geliştirici",
            PublishDate = new DateTime(2024, 2, 5)
        },
        new Blog
        {
            Id = 3,
            DefaultTitle = "API Entegrasyonu ve Veri Güvenliği",
            DefaultContent = "API entegrasyonu, farklı yazılım sistemlerinin birbirleriyle etkileşime geçmesini sağlar. Bu süreç, veri güvenliğini ve işlevselliği koruyarak veri paylaşımını mümkün kılar. Günümüz teknolojisinde, uygulamalar arası veri alışverişi büyük önem taşır. API'ler sayesinde, bir uygulama başka bir uygulamanın verilerine erişebilir, ancak bu erişimin güvenli olması büyük önem taşır. Özellikle hassas verilerle çalışan uygulamalar, veri güvenliğini sağlamak için gelişmiş şifreleme teknikleri kullanır. Bu süreçte, API anahtarları ve şifreleme algoritmaları kullanılarak veriler güvenli bir şekilde paylaşılır. Ayrıca, API entegrasyonlarının doğru yapılandırılması, performans ve verimlilik açısından kritik bir rol oynar. Yanlış yapılandırmalar veri sızıntılarına ve performans sorunlarına yol açabilir. API entegrasyonları ile veri güvenliği konuları, başarılı bir yazılım geliştirme sürecinin önemli bir parçasını oluşturur.",
            IsActive = true,
            Slug = "api-integration-and-data-security",
            ImgageUrl = "images/blog3.jpg",
            AuthorImageUrl = "images/author.jpg",
            Author = "Muhammed Özdemir",
            AuthorTitle = "Yazılım Geliştirici",
            PublishDate = new DateTime(2024, 4, 18)
        },
        new Blog
        {
            Id = 4,
            DefaultTitle = "ERP Sistemlerinin İşletmelere Sağladığı Avantajlar",
            DefaultContent = "ERP sistemleri, işletmelerin operasyonlarını daha verimli bir şekilde yönetmelerine olanak tanır. Bu sistemler, finans, insan kaynakları, tedarik zinciri gibi farklı departmanları tek bir platformda birleştirir. ERP sayesinde, işletmeler verilerini merkezi bir noktadan yönetebilir ve tüm iş süreçlerini optimize edebilir. Ayrıca, ERP sistemleri işletmelere maliyet avantajı sunar ve karar alma süreçlerini hızlandırır. Tüm departmanlar arasında anlık veri paylaşımı sağlanır, bu da işletmenin çevik ve esnek bir yapıya kavuşmasına yardımcı olur. Günümüzde birçok şirket, rekabet avantajı sağlamak için ERP sistemlerini tercih etmektedir. ERP, iş süreçlerini dijitalleştirerek verimliliği artıran önemli bir araçtır.",
            IsActive = true,
            Slug = "benefits-of-erp-systems-for-businesses",
            ImgageUrl = "images/blog4.jpg",
            AuthorImageUrl = "images/author.jpg",
            Author = "Muhammed Özdemir",
            AuthorTitle = "Yazılım Geliştirici",
            PublishDate = new DateTime(2024, 6, 12)
        },
        new Blog
        {
            Id = 5,
            DefaultTitle = "Oyun Geliştirme Sürecinde Öne Çıkan Teknolojiler",
            DefaultContent = "Oyun geliştirme dünyasında kullanılan teknolojiler hızla gelişmekte ve yeni fırsatlar sunmaktadır. Özellikle Unity ve Unreal Engine gibi oyun motorları, geliştiricilere üstün performans ve görsellik sunar. Bununla birlikte, oyunların çapraz platform uyumluluğu da önem kazanmıştır; aynı oyunun birden fazla platformda sorunsuz çalışabilmesi gerekmektedir. Ayrıca, yapay zeka (AI) ve sanal gerçeklik (VR) gibi teknolojiler, oyunlara yenilikçi özellikler katmaktadır. Yapay zeka, oyunlarda dinamik karakter davranışlarını mümkün kılarken, VR oyunculara gerçek bir deneyim sunar. Tüm bu gelişmeler, oyun geliştirme sürecini daha da heyecan verici hale getirmektedir.",
            IsActive = true,
            Slug = "leading-technologies-in-game-development",
            ImgageUrl = "images/blog5.jpg",
            AuthorImageUrl = "images/author.jpg",
            Author = "Muhammed Özdemir",
            AuthorTitle = "Yazılım Geliştirici",
            PublishDate = new DateTime(2024, 8, 20)
        },
        new Blog
        {
            Id = 6,
            DefaultTitle = "Web Geliştirme Trendi: Progressive Web Apps",
            DefaultContent = "Progressive Web Apps (PWA), kullanıcı deneyimini geliştiren bir web uygulama türüdür. PWA'lar, mobil cihazlarda yerel uygulamalar gibi çalışabilen web uygulamalarıdır. Bu teknoloji, hızlı yükleme süreleri, çevrimdışı erişim ve push bildirim desteği gibi özellikler sunarak kullanıcı deneyimini artırır. Ayrıca, PWA'lar herhangi bir uygulama mağazasına ihtiyaç duymadan cihazlara yüklenebilir. Bu, işletmelere daha düşük maliyetlerle geniş bir kullanıcı kitlesine ulaşma fırsatı sunar. Google, Twitter gibi büyük şirketler de PWA teknolojisini benimseyerek kullanıcı deneyimini geliştirmektedir. PWA'lar, web geliştirme alanında geleceğin trendi olarak görülmektedir.",
            IsActive = true,
            Slug = "web-development-trend-progressive-web-apps",
            ImgageUrl = "images/blog6.jpg",
            AuthorImageUrl = "images/author.jpg",
            Author = "Muhammed Özdemir",
            AuthorTitle = "Yazılım Geliştirici",
            PublishDate = new DateTime(2024, 10, 29)
        }
    );
        }
    }
}
