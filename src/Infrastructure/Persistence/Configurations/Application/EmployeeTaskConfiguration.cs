using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Application
{
    public class EmployeeTaskConfiguration : IEntityTypeConfiguration<EmployeeTask>
    {
        public void Configure(EntityTypeBuilder<EmployeeTask> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.EmployeeId).IsRequired();

            builder.Property(x => x.TaskName).IsRequired();
            builder.Property(x => x.TaskName).HasMaxLength(255);

            builder.Property(x => x.Department).IsRequired();

            builder.Property(x => x.TaskDescription).IsRequired();
            builder.Property(x => x.TaskDescription).HasMaxLength(1000);


            builder.HasOne<Employee>(x => x.AssignedEmployee)
                   .WithMany()
                   .HasForeignKey(x => x.EmployeeId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("EmployeeTasks");
        }
    }
}
