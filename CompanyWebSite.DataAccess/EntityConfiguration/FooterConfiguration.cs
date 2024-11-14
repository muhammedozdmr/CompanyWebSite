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
    //TODO: Configuration dosyasını tamamla
    internal class FooterConfiguration : IEntityTypeConfiguration<Footer>
    {
        public void Configure(EntityTypeBuilder<Footer> builder)
        {
            builder.ToTable(nameof(Footer));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CompanyInfoTitle).HasMaxLength(100);
            builder.Property(x => x.NewsletterTitle).HasMaxLength(100);
            builder.Property(x => x.NewsletterPlaceholder).HasMaxLength(100);
            builder.Property(x => x.QuickLinksTitle).HasMaxLength(100);

            builder.HasData(
                new Footer
                {
                    Id = 1,
                    CompanyInfoTitle = "Bizi Nerede Bulabilirsiniz?",
                    NewsletterTitle = "Bültenimize Abone Olun",
                    NewsletterPlaceholder = "E-posta adresinizi girin",
                    QuickLinksTitle = "Kolay Erişim"
                }
                );
        }
    }
}
