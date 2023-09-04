using Application.Common.Interfaces;
using Domain.Common;
using MediatR;

namespace Application.Common.Features.EmployeeWorkingHours.Command.Add
{
    public class AddEmployeeWorkingHoursCommandHandler : IRequestHandler<AddEmployeeWorkingHoursCommand, Response<Guid>>
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public AddEmployeeWorkingHoursCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<Response<Guid>> Handle(AddEmployeeWorkingHoursCommand request, CancellationToken cancellationToken)
        {
            var employee = await _applicationDbContext.Employees.FindAsync(request.EmployeeId);

            if (employee == null)
            {
                return new Response<Guid>("Employee not found.", default, new List<string> { "Employee not found." });
            }

            var employeeWorkingHours = new Domain.Entities.EmployeeWorkingHours
            {
                EmployeeId = employee.Id,
                EntryTime = request.EntryTime,
                ExitTime = request.ExitTime,
                IsAbsent = request.IsAbsent
            };

            await _applicationDbContext.EmployeeWorkingHours.AddAsync(employeeWorkingHours, cancellationToken);
            await _applicationDbContext.SaveChangesAsync(cancellationToken);

            return new Response<Guid>("Employee working hours added successfully.", employeeWorkingHours.Id);
        }
    }
}
