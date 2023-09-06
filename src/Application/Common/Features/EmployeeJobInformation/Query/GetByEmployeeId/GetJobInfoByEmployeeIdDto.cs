using Domain.Enums.JobEnums;
using Domain.Enums.PersonalEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Features.EmployeeJobInformation.Query.GetByEmployeeId
{
    public class GetJobInfoByEmployeeIdDto
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
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
