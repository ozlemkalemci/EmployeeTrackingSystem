using Application.Common.Interfaces;
using Domain.Common;
using Domain.Entities;
using MediatR;

namespace Application.Common.Features.EmployeeTasks.Command.Add
{
    public class AddEmployeeTaskCommandHandler : IRequestHandler<AddEmployeeTaskCommand, Response<Guid>>
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public AddEmployeeTaskCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<Response<Guid>> Handle(AddEmployeeTaskCommand request, CancellationToken cancellationToken)
        {
            var employee = await _applicationDbContext.Employees.FindAsync(request.EmployeeId);

            if (employee == null)
            {
                return new Response<Guid>("Employee not found.", default, new List<string> { "Employee not found." });
            }

            var task = new EmployeeTask
            {
                EmployeeId = employee.Id,
                TaskName = request.TaskName,
                Department = request.Department,
                TaskDescription = request.TaskDescription
            };

            await _applicationDbContext.EmployeeTasks.AddAsync(task, cancellationToken);
            await _applicationDbContext.SaveChangesAsync(cancellationToken);

            return new Response<Guid>($"The new task was successfully added.", task.Id);
        }
    }
}
