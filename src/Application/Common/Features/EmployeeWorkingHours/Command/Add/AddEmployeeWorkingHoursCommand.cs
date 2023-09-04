using Domain.Common;
using MediatR;

namespace Application.Common.Features.EmployeeWorkingHours.Command.Add
{
    public class AddEmployeeWorkingHoursCommand : IRequest<Response<Guid>>
    {
        public Guid EmployeeId { get; set; }
        public DateTimeOffset? EntryTime { get; set; }
        public DateTimeOffset? ExitTime { get; set; }
        public bool IsAbsent { get; set; }
    }
}
