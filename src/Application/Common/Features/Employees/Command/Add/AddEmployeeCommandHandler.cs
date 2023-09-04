using Application.Common.Interfaces;
using Domain.Common;
using Domain.Entities;
using MediatR;
using System;

namespace Application.Common.Features.Employees.Command.Add
{
    public class AddEmployeeCommandHandler : IRequestHandler<AddEmployeeCommand, Response<Guid>>
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public AddEmployeeCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<Response<Guid>> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = new Employee
            {
                UserId = request.UserId,
                IdentityNumber = request.IdentityNumber,
                FirstName = request.FirstName,
                LastName = request.LastName,
                BirthDate = request.BirthDate,
                BirthPlace = request.BirthPlace,
                Gender = request.Gender,
                MaritalStatus = request.MaritalStatus,
                EducationLevel = request.EducationLevel,
                LanguageSkill = request.LanguageSkill,
                CreatedOn = request.CreatedOn,
                CreatedByUserId = request.CreatedByUserId,
            };

            await _applicationDbContext.Employees.AddAsync(employee, cancellationToken);
            await _applicationDbContext.SaveChangesAsync(cancellationToken);

            return new Response<Guid>(employee.Id);
        }
    }
}
