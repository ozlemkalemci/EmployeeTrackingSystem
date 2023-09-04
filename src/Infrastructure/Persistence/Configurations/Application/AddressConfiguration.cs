using Domain.Common;
using Domain.Entities;
using Domain.Enums.ContactEnums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Application
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            // Name
            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.Name).HasMaxLength(100);

            // Country
            builder.Property(x => x.Country).IsRequired();
            builder.Property(x => x.Country).HasMaxLength(50);

            // City
            builder.Property(x => x.City).IsRequired();
            builder.Property(x => x.City).HasMaxLength(50);

            // District
            builder.Property(c => c.District).IsRequired();
            builder.Property(c => c.District).HasMaxLength(100);

            // PostCode
            builder.Property(c => c.PostCode).IsRequired();
            builder.Property(c => c.PostCode).HasMaxLength(100);

            // AddressLine1
            builder.Property(c => c.AddressLine1).IsRequired();
            builder.Property(c => c.AddressLine1).HasMaxLength(500);

            // AddressLine2
            builder.Property(c => c.AddressLine2).IsRequired();
            builder.Property(c => c.AddressLine2).HasMaxLength(500);


            // AddressType
            builder.Property(x => x.AddressType)
                .IsRequired()
                .HasConversion<int>();

            

            builder.ToTable("Addresses");
        }
    }
}
