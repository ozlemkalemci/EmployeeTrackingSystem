using Application.Common.Interfaces;
using Domain.Common;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Features.EmployeeJobInformation.Command.Add
{
    public class AddEmployeeJobInfoCommandHandler : IRequestHandler<AddEmployeeJobInfoCommand, Response<Guid>>
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public AddEmployeeJobInfoCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<Response<Guid>> Handle(AddEmployeeJobInfoCommand request, CancellationToken cancellationToken)
        {
            var employee = await _applicationDbContext.Employees.FindAsync(request.EmployeeId);

            if (employee == null)
            {
                return new Response<Guid>("Employee not found.", default, new List<string> { "Employee not found." });
            }

            var employeeJobInfo = new EmployeeJobInfo
            {
                
                EmployeeId = employee.Id,
                Department = request.Department,
                JobTitle = request.JobTitle,
                EmploymentType = request.EmploymentType,
                EmploymentStatus = request.EmploymentStatus,
                HireDate = request.HireDate,
                ResignationDate = request.ResignationDate,
                LeaveStartDate = request.LeaveStartDate,
                LeaveEndDate = request.LeaveEndDate
            };

            await _applicationDbContext.EmployeeJobInfos.AddAsync(employeeJobInfo, cancellationToken);
            await _applicationDbContext.SaveChangesAsync(cancellationToken);

            return new Response<Guid>($"The new employee job info was successfully added.", employeeJobInfo.Id);
        }
    }
}
