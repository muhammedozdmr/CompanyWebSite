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
    class SidePanelConfiguration : IEntityTypeConfiguration<SidePanel>
    {
        public void Configure(EntityTypeBuilder<SidePanel> builder)
        {
            builder.ToTable(nameof(SidePanel));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.SidePanelMainTitle).HasMaxLength(500);
            builder.Property(x => x.SidePanelMainContent).HasMaxLength(1000);
            builder.Property(x => x.SidePanelContactTitle).HasMaxLength(1000);
            builder.Property(x => x.SidePanelContactContent).HasMaxLength(500);

            builder.HasData(
                new SidePanel
                {
                    Id = 1,
                    SidePanelMainTitle = "Ölçeklenebilir Çözümlerle Büyümeye Hazırlanın",
                    SidePanelMainContent = "Dijital çözümlerle işinizi büyütün ve rakiplerinize karşı avantaj kazanın. İster startup olun, ister kurumsal bir şirket; ölçeklenebilir ve etkili çözümlerle işletmenize değer katıyoruz. TechLiberty’nin uzman ekibiyle projelerinizi başarıyla hayata geçirin.",
                    SidePanelContactTitle = "Birlikte Dijital Geleceği Şekillendirelim",
                    SidePanelContactContent = "Yeni bir proje için destek mi arıyorsunuz? TechLiberty ekibi, ihtiyaçlarınıza uygun yaratıcı ve ölçeklenebilir çözümler üretmek için burada. Dijital dönüşüm yolculuğunuzda size rehberlik edelim. Bizimle iletişime geçin ve işletmenizi bir üst seviyeye taşıyacak iş birliği fırsatlarını konuşalım!"
                }
                );
        }
    }
}
