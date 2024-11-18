using CompanyWebSite.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CompanyWebSite.DataAccess.EntityConfiguration;

public class NavbarItemConfiguration : IEntityTypeConfiguration<NavbarItem>
{
    public void Configure(EntityTypeBuilder<NavbarItem> builder)
    {
        builder.ToTable(nameof(NavbarItem));
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
        builder.Property(x => x.Slug).IsRequired().HasMaxLength(100);
        builder.HasData(
            new NavbarItem { Id = 1, Name = "Ana Sayfa", Slug = "home", NavbarControllerName = "Home" },
            new NavbarItem { Id = 2, Name = "Hakkımızda", Slug = "about", NavbarControllerName = "About" },
            new NavbarItem { Id = 3, Name = "Hizmetler", Slug = "services", NavbarControllerName = "Service" },
            new NavbarItem { Id = 4, Name = "Blog", Slug = "blog", NavbarControllerName = "Blog" },
            new NavbarItem { Id = 5, Name = "İletişim", Slug = "contact", NavbarControllerName = "Contact" },
            new NavbarItem { Id = 6, Name = "SSS", Slug = "faq", NavbarControllerName = "Faq" }
        );
    }
}
