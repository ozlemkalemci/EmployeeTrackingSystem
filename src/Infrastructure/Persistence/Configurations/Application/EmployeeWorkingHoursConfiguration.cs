using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Application
{
    public class EmployeeWorkingHoursConfiguration : IEntityTypeConfiguration<EmployeeWorkingHours>
    {
        public void Configure(EntityTypeBuilder<EmployeeWorkingHours> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.EntryTime).IsRequired(false);
            builder.Property(x => x.ExitTime).IsRequired(false);
            builder.Property(x => x.IsAbsent).IsRequired();

            builder.HasOne(x => x.Employee)
                .WithMany(e => e.EmployeeWorkingHours)
                .HasForeignKey(x => x.EmployeeId);

            builder.ToTable("EmployeeWorkingHours");
        }
    }
}
