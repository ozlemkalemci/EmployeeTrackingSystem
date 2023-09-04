using Domain.Common;
using Domain.Enums.JobEnums;

namespace Domain.Entities
{
    public class EmployeeTask : EntityBase<Guid>
    {
        public Guid EmployeeId { get; set; }
        public string TaskName { get; set; }
        public Departments Department { get; set; }
        public string TaskDescription { get; set; }
        public Employee AssignedEmployee { get; set; }
    }

}
