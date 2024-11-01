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
    { //TODO: ServiceConfiguration sınıfını çoka çok ilişkiyi konfigure etmek için kullanabilirsiniz.
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.ToTable(nameof(Service));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.DefaultTitle).HasMaxLength(250);
            builder.Property(x => x.DefaultContent).HasMaxLength(500);
            builder.Property(x => x.Slug).HasMaxLength(100);
            builder.Property(x => x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.ServiceSummary).HasMaxLength(250);
            builder.HasMany(x => x.ServiceCategories).WithMany(x => x.Services).UsingEntity<Dictionary<string,object>>("ServiceCategory",
                j => j.HasOne<ServiceCategory>().WithMany().HasForeignKey("ServiceCategoryId"), // `ServiceCategoryId` FK'sı
               j => j.HasOne<Service>().WithMany().HasForeignKey("ServiceId"), // `ServiceId` FK'sı
                j =>j.HasData(
                new {ServiceId = 1, ServiceCategoryId = 1},
                new {ServiceId = 2, ServiceCategoryId = 2},
                new {ServiceId = 3, ServiceCategoryId = 3},
                new {ServiceId = 4, ServiceCategoryId = 4},
                new {ServiceId = 5, ServiceCategoryId = 5},
                new {ServiceId = 6, ServiceCategoryId = 6},
                new {ServiceId = 7, ServiceCategoryId = 7},
                new {ServiceId = 8, ServiceCategoryId = 8},
                new {ServiceId = 9, ServiceCategoryId = 9},
                new {ServiceId = 10, ServiceCategoryId = 10}
                ));
            builder.HasMany(x => x.MediaItems).WithOne(y => y.Service).HasForeignKey(y => y.ServiceId);
            builder.HasMany(x => x.Highlights).WithOne(y => y.Service).HasForeignKey(y => y.ServiceId);

            builder.HasData
            (
                new Service
                {
                    Id = 1,
                    DefaultTitle = "Web Geliştirme",
                    DefaultContent = "Web geliştirme, işletmelerin dijital varlığını güçlendirmek için stratejik bir süreçtir. İhtiyaçlarınızı ve hedeflerinizi analiz ederek kullanıcı dostu, modern ve ölçeklenebilir web çözümleri sunuyoruz. Tasarım ve kullanıcı deneyiminden performansa kadar tüm aşamalarda yanınızdayız. Kod kalitesi, SEO uyumu ve güvenlik önceliklerimiz arasında yer alır. Profesyonel ekibimiz, işletmenizin çevrimiçi ortamda başarıya ulaşması için en uygun çözümleri sunmaya hazırdır.",
                    IsActive = true,
                    Slug = "web-development",
                    ServiceSummary = "Profesyonel web geliştirme ile modern, kullanıcı dostu ve ölçeklenebilir web siteleri sunuyoruz."
                },
                new Service
                {
                    Id = 2,
                    DefaultTitle = "Mobil Uygulama Geliştirme",
                    DefaultContent = "Mobil cihazlar günümüzde kullanıcı deneyiminin merkezi haline gelmiştir. İOS ve Android platformlarında yüksek performanslı, kullanıcı dostu uygulamalar geliştiriyoruz. Kullanıcı alışkanlıklarını analiz ederek, etkileşimi artıracak ve kullanıcıyı çeken tasarımlar sunuyoruz. Uygulamalarımız, güvenlik ve hız odaklı geliştirilirken, kolay güncellenebilir ve ölçeklenebilir yapısıyla da uzun vadeli bir çözüm sağlar. Dijital dünyada işinizi büyütmeniz için yanınızdayız.",
                    IsActive = true,
                    Slug = "mobile-app-development",
                    ServiceSummary = "iOS ve Android platformlarına uygun, kullanıcı odaklı mobil uygulama geliştirme hizmetleri sağlıyoruz."
                },
                new Service
                {
                    Id = 3,
                    DefaultTitle = "Oyun Geliştirme",
                    DefaultContent = "Oyun geliştirme, hem teknik hem de yaratıcı bir süreçtir. Eğlenceli, etkileyici ve yüksek performanslı oyunlar yaratmak için gelişmiş teknolojilerden yararlanıyoruz. Unity ve Unreal Engine gibi güçlü araçlarla çalışarak, hedef kitlenizin beklentilerini karşılayacak grafik kalitesine ve akıcı oynanışa sahip oyunlar geliştiriyoruz. Oyuncuların ilgisini çeken, duygusal bağ kurabilecekleri ve tekrar oynama isteği uyandıran oyunlar yaratma sürecinde her aşamada yanınızdayız.",
                    IsActive = true,
                    Slug = "game-development",
                    ServiceSummary = "İleri teknolojilerle oyun tasarımı yaparak eğlenceli ve etkileşimli oyun deneyimleri sunuyoruz."
                    },
                new Service
                {
                    Id = 4,
                    DefaultTitle = "API Entegrasyonu",
                    DefaultContent = "API entegrasyonu, farklı sistemlerin birbiriyle güvenli ve verimli bir şekilde iletişim kurmasını sağlar. İşletmenizdeki veri akışını optimize ederek süreçleri daha etkin hale getirmek için API geliştirme ve entegrasyon hizmetleri sunuyoruz. Kapsamlı güvenlik önlemleri ile hassas verilerinizi koruyarak verimli bir altyapı oluşturuyoruz. Tüm sistemlerinizin uyum içinde çalışmasını sağlayarak iş akışlarınızı hızlandırıyor ve maliyetlerinizi düşürüyoruz.",
                    IsActive = true,
                    Slug = "api-integration",
                    ServiceSummary = "API entegrasyonu ile veri akışını optimize ediyor, sistemler arası bağlantıları güvenli hale getiriyoruz."
                    },
                new Service
                {
                    Id = 5,
                    DefaultTitle = "CRM Çözümleri",
                    DefaultContent = "Müşteri ilişkileri yönetimi, başarılı bir işin temelidir. Müşterilerinizle güçlü ve uzun vadeli ilişkiler kurmanıza yardımcı olan CRM çözümlerimiz, müşteri memnuniyetini artırarak işinizi büyütür. Satış, pazarlama ve müşteri hizmetleri süreçlerinizi optimize eden, tüm müşteri verilerini tek bir platformda toplayan ve analiz eden bir sistem sunuyoruz. İşinizi daha iyi tanımanızı ve hedeflerinize daha hızlı ulaşmanızı sağlamak için buradayız.",
                    IsActive = true,
                    Slug = "crm-solutions",
                    ServiceSummary = "Müşteri ilişkilerini yönetmek için kapsamlı ve kullanımı kolay CRM çözümleri sunuyoruz."  
                },
                new Service
                {
                    Id = 6,
                    DefaultTitle = "ERP Çözümleri",
                    DefaultContent = "İş süreçlerinizi dijitalleştirerek yönetiminizi kolaylaştıran ERP çözümlerimizle işletmenizin verimliliğini artırıyoruz. Finans, insan kaynakları, tedarik zinciri gibi departmanları tek bir sistemde birleştirerek iş süreçlerinizi optimize ediyoruz. ERP çözümlerimiz sayesinde maliyetleri düşürürken, karar alma sürecinizi hızlandırıyor ve departmanlar arasında anlık veri paylaşımını mümkün kılıyoruz. Sürdürülebilir büyüme için ideal bir çözüm sunuyoruz.",
                    IsActive = true,
                    Slug = "erp-solutions",
                    ServiceSummary = "Verimliliği artıran ve iş süreçlerini optimize eden, esnek ve güçlü ERP çözümleri sunuyoruz."
                },
                new Service
                {
                    Id = 7,
                    DefaultTitle = "Veritabanı Yönetim Sistemleri",
                    DefaultContent = "Verilerin güvenliği ve erişilebilirliği her işletme için kritik öneme sahiptir. Güçlü, güvenli ve ölçeklenebilir veritabanı çözümlerimizle verilerinizi etkin bir şekilde yönetmenize yardımcı oluyoruz. Veritabanı yapılarınızı optimize ederek performansı artırırken, verilerinizi sürekli erişilebilir ve güvenli tutmak için gelişmiş güvenlik protokollerini kullanıyoruz. İşletmenizin büyümesi ve karar süreçlerini hızlandırması için verilerinizi en iyi şekilde yönetiyoruz.",
                    IsActive = true,
                    Slug = "database-management",
                    ServiceSummary = "Güvenli ve ölçeklenebilir veritabanı çözümlerimizle verilerinizi etkin şekilde yönetmenize yardımcı oluyoruz."
                },
                new Service
                {
                    Id = 8,
                    DefaultTitle = "Sistem Analizi ve Tasarımı",
                    DefaultContent = "İşletmenizin ihtiyaçlarına uygun sistemler tasarlamak için kapsamlı bir analiz süreci yürütüyoruz. Mevcut süreçlerinizi değerlendirerek iş akışınızı optimize edecek sistem çözümleri sunuyoruz. İhtiyaçlarınıza göre özel olarak tasarlanmış, kullanımı kolay ve sürdürülebilir sistemler geliştiriyoruz. Sistem tasarımı sırasında performans, güvenlik ve ölçeklenebilirlik gibi unsurları önceliklendirerek, işletmenizin dijital dönüşüm sürecine katkıda bulunuyoruz.",
                    IsActive = true,
                    Slug = "system-analysis",
                    ServiceSummary = "İş süreçlerinize uygun sistem tasarımı yaparak, etkin ve ölçeklenebilir çözümler sunuyoruz."
                    },
                new Service
                {
                    Id = 9,
                    DefaultTitle = "Proje Yönetimi",
                    DefaultContent = "Projelerinizi başarıyla tamamlamanızı sağlayacak stratejik proje yönetim çözümlerimizle, kaynaklarınızı etkin bir şekilde kullanmanızı sağlıyoruz. Planlama, izleme, kontrol ve kapanış süreçlerinde size destek olarak hedeflerinize ulaşmanıza yardımcı oluyoruz. Ekibinizle yakın çalışarak zamanında ve bütçe dahilinde projeler tamamlamanızı sağlarken, kaliteyi de garanti ediyoruz. Başarılı projeler için tüm adımlarda yanınızdayız.",
                    IsActive = true,
                    Slug = "project-management",
                    ServiceSummary = "Projelerinizi planlamak, takip etmek ve başarıya ulaştırmak için profesyonel yönetim çözümleri sağlıyoruz."
                },
                new Service
                {
                    Id = 10,
                    DefaultTitle = "Bulut Çözümleri",
                    DefaultContent = "Dijital veri depolama ve yönetimi için güvenli ve ölçeklenebilir bulut çözümleri sunuyoruz. Verilerinize her yerden kolayca erişim sağlarken, güvenlik ve maliyet avantajı sunan bulut altyapılarımızla işinizi büyütmenize destek oluyoruz. İş yükünüzü hafifletmek ve esneklik sağlamak için bulut çözümlerimizde en son teknolojileri kullanıyoruz. Bulut altyapımız sayesinde verilerinizi güvenle saklayın ve işletmenizi daha çevik hale getirin.",
                    IsActive = true,
                    Slug = "cloud-solutions",
                    ServiceSummary = "Güvenilir, esnek ve ölçeklenebilir bulut çözümlerimizle verilerinizi güvenle yönetmenizi sağlıyoruz."    
                }
            );
        }
    }
}
