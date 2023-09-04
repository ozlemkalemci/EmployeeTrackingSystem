using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Application
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.User)
                .WithOne()
                .HasForeignKey<Employee>(x => x.UserId)
                .IsRequired();

            // IdentityNumber
            builder.Property(x => x.IdentityNumber).IsRequired();
            builder.Property(x => x.IdentityNumber).HasMaxLength(20);

            // FirstName
            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.FirstName).HasMaxLength(50);

            // LastName
            builder.Property(x => x.LastName).IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(50);

            // BirthDate
            builder.Property(x => x.BirthDate).IsRequired();

            // BirthPlace
            builder.Property(x => x.BirthPlace).HasMaxLength(100);

            // Gender
            builder.Property(x => x.Gender).IsRequired();
            builder.Property(x => x.Gender).HasConversion<int>();

            // MaritalStatus
            builder.Property(x => x.MaritalStatus).IsRequired();
            builder.Property(x => x.MaritalStatus).HasConversion<int>();

            // EducationLevel
            builder.Property(x => x.EducationLevel).IsRequired();
            builder.Property(x => x.EducationLevel).HasConversion<int>();

            // LanguageSkill
            builder.Property(x => x.LanguageSkill).IsRequired();
            builder.Property(x => x.LanguageSkill).HasConversion<int>();

            // CreatedOn
            builder.Property(x => x.CreatedOn).IsRequired();

            // CreatedByUserId
            builder.Property(x => x.CreatedByUserId).HasMaxLength(450);

            builder.HasMany<Address>(x => x.Addresses)
            .WithOne(x => x.Employee)
            .HasForeignKey(x => x.EmployeeId).IsRequired();

            builder.ToTable("Employees");
        }
    }
}
