using Domain.Enums.ContactEnums;
using Domain.Enums.JobEnums;
using Domain.Enums.PersonalEnums;
using Domain.Identity;
using System.Diagnostics.Metrics;

namespace Application.Common.Features.EmployeeTasks.Command.Add
{
    public class AddEmployeeTaskDto
    {
        public Guid EmployeeId { get; set; }
        public string TaskName { get; set; }
        public Departments Department { get; set; }
        public string TaskDescription { get; set; }

        public AddEmployeeTaskDto()
        {
            EmployeeId = new Guid();
        
            Department = Departments.ITDepartment;
            
            TaskName = "TaskName";

            TaskDescription = "TaskDescription";
        }
    }
}
