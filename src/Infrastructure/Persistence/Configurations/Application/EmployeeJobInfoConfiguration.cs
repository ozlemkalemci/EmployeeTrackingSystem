using Domain.Common;
using Domain.Entities;
using Domain.Enums.JobEnums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Infrastructure.Persistence.Configurations.Application
{
    public class EmployeeJobInfoConfiguration : IEntityTypeConfiguration<EmployeeJobInfo>
    {
        public void Configure(EntityTypeBuilder<EmployeeJobInfo> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.EmployeeId).IsRequired();

            // Department
            builder.Property(x => x.Department)
                .IsRequired()
                .HasConversion<int>();

            // JobTitle
            builder.Property(x => x.JobTitle)
                .IsRequired()
                .HasConversion<int>();

            // EmploymentType
            builder.Property(x => x.EmploymentType)
                .IsRequired()
                .HasConversion<int>();

            // EmploymentStatus
            builder.Property(x => x.EmploymentStatus)
                .IsRequired()
                .HasConversion<int>();

            // HireDate
            builder.Property(x => x.HireDate)
                .IsRequired();

            // ResignationDate
            builder.Property(x => x.ResignationDate)
                .IsRequired(false);

            // LeaveStartDate
            builder.Property(x => x.LeaveStartDate)
                .IsRequired(false);

            // LeaveEndDate
            builder.Property(x => x.LeaveEndDate)
                .IsRequired(false);

            builder.HasOne(eji => eji.Employee)
                .WithOne(e => e.EmployeeJobInfo)
                .HasForeignKey<EmployeeJobInfo>(eji => eji.EmployeeId);

            builder.ToTable("EmployeeJobInfos");
        }
    }
}
