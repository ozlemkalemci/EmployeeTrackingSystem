using Domain.Common;
using Domain.Entities;
using Domain.Enums.ContactEnums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Application
{
    public class PhoneConfiguration : IEntityTypeConfiguration<Phone>
    {
        public void Configure(EntityTypeBuilder<Phone> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Employee)
                .WithMany(e => e.Phones)
                .HasForeignKey(x => x.EmployeeId);

            // Name
            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.Name).HasMaxLength(100);

            // PhoneNumber
            builder.Property(c => c.PhoneNumber).IsRequired();
            builder.Property(c => c.PhoneNumber).HasMaxLength(20);

            // PhoneNumberType
            builder.Property(x => x.PhoneNumberType)
                .IsRequired()
                .HasConversion<int>();

            builder.ToTable("Phones");
        }
    }
}
