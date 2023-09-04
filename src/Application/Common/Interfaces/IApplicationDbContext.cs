using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Employee> Employees { get; set; }
        DbSet<EmployeeJobInfo> EmployeeJobInfos { get; set; }
        DbSet<EmployeeTask> EmployeeTasks { get; set; }
        DbSet<Phone> Phones { get; set; }
        DbSet<Address> Addresses { get; set; }
        DbSet<EmployeeWorkingHours> EmployeeWorkingHours { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        int SaveChanges();

    }
}
