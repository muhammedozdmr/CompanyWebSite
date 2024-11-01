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
    public class HighlightConfiguration : IEntityTypeConfiguration<Highlight>
    {
        public void Configure(EntityTypeBuilder<Highlight> builder)
        {
            builder.ToTable(nameof(Highlight));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Content).IsRequired().HasMaxLength(100);
            builder.HasOne(x=>x.Service).WithMany(x => x.Highlights).HasForeignKey(x => x.ServiceId);
            builder.HasData(
                new Highlight { Id = 1, Content = "Modern ve kullanıcı dostu web çözümleri", ServiceId = 1 },
                    new Highlight { Id = 2, Content = "SEO uyumlu web geliştirme", ServiceId = 1 },
                    new Highlight { Id = 3, Content = "Yüksek performans ve güvenlik odaklı", ServiceId = 1 },
                    new Highlight { Id = 4, Content = "iOS ve Android platformları için geliştirme", ServiceId = 2 },
new Highlight { Id = 5, Content = "Kullanıcı dostu ve etkileşimli tasarım", ServiceId = 2 },
new Highlight { Id = 6, Content = "Kolay güncellenebilir ve ölçeklenebilir yapı", ServiceId = 2 },
new Highlight { Id = 7, Content = "Eğlenceli ve yüksek performanslı oyunlar", ServiceId = 3 },
new Highlight { Id = 8, Content = "Unity ve Unreal Engine gibi araçlarla geliştirme", ServiceId = 3 },
new Highlight { Id = 9, Content = "Tekrar oynanabilirlik sağlayan oyun tasarımı", ServiceId = 3 },
new Highlight { Id = 10, Content = "Verimli ve güvenli veri akışı sağlama", ServiceId = 4 },
new Highlight { Id = 11, Content = "Farklı sistemler arası uyum", ServiceId = 4 },
new Highlight { Id = 12, Content = "Güvenlik odaklı entegrasyon", ServiceId = 4 },
new Highlight { Id = 13, Content = "Müşteri ilişkilerini güçlendiren çözümler", ServiceId = 5 },
new Highlight { Id = 14, Content = "Satış, pazarlama ve hizmetleri optimize etme", ServiceId = 5 },
new Highlight { Id = 15, Content = "Tüm müşteri verilerinin analiz edilmesi", ServiceId = 5 },
new Highlight { Id = 16, Content = "Departmanlar arası veri entegrasyonu", ServiceId = 6 },
new Highlight { Id = 17, Content = "İş süreçlerini optimize eden yapı", ServiceId = 6 },
new Highlight { Id = 18, Content = "Karar alma süreçlerini hızlandırma", ServiceId = 6 },
new Highlight { Id = 19, Content = "Güçlü ve güvenli veritabanı altyapısı", ServiceId = 7 },
new Highlight { Id = 20, Content = "Yüksek performans için optimize edilmiş", ServiceId = 7 },
new Highlight { Id = 21, Content = "Verilerin sürekli erişilebilirliği", ServiceId = 7 },
new Highlight { Id = 22, Content = "İş süreçlerinize özel tasarım", ServiceId = 8 },
new Highlight { Id = 23, Content = "Kapsamlı analiz ve performans optimizasyonu", ServiceId = 8 },
new Highlight { Id = 24, Content = "Ölçeklenebilir ve güvenilir çözümler", ServiceId = 8 },
new Highlight { Id = 25, Content = "Projeler için stratejik yönetim çözümleri", ServiceId = 9 },
new Highlight { Id = 26, Content = "Zamanında ve bütçe dahilinde teslim", ServiceId = 9 },
new Highlight { Id = 27, Content = "Kaliteyi ön planda tutan yönetim", ServiceId = 9 },
new Highlight { Id = 28, Content = "Güvenli ve esnek bulut altyapısı", ServiceId = 10 },
new Highlight { Id = 29, Content = "Her yerden erişim ve veri güvenliği", ServiceId = 10 },
new Highlight { Id = 30, Content = "İş yükünü hafifletmek için ölçeklenebilir çözümler", ServiceId = 10 }
                );
        }
    }
}
