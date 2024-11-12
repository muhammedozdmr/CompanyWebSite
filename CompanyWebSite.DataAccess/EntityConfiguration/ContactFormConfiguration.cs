using CompanyWebSite.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CompanyWebSite.DataAccess.EntityConfiguration;

public class ContactFormConfiguration : IEntityTypeConfiguration<ContactForm>
{
    public void Configure(EntityTypeBuilder<ContactForm> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.FullName).HasMaxLength(100).IsRequired();
        
    }
}
