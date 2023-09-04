using Domain.Common;
using Domain.Enums.JobEnums;
using MediatR;

namespace Application.Common.Features.EmployeeTasks.Command.Add
{
    public class AddEmployeeTaskCommand : IRequest<Response<Guid>>
    {
        public Guid EmployeeId { get; set; }
        public string TaskName { get; set; }
        public Departments Department { get; set; }
        public string TaskDescription { get; set; }
    }
}
