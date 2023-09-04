using Domain.Common;
using Domain.Enums.JobEnums;
using Domain.Enums.PersonalEnums;

namespace Domain.Entities
{
    public class EmployeeJobInfo : EntityBase<Guid>
    {
        
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public Departments Department { get; set; }
        public JobTitles JobTitle { get; set; }
        public EmploymentType EmploymentType { get; set; }
        public EmploymentStatus EmploymentStatus { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? ResignationDate { get; set; }
        public DateTime? LeaveStartDate { get; set; }
        public DateTime? LeaveEndDate { get; set; }
        
    }
}
