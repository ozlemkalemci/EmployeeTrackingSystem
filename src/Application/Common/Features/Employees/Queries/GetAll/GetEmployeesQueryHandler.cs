using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Features.Employees.Queries.GetAll
{
    public class GetEmployeesQueryHandler : IRequestHandler<GetEmployeesQuery, List<GetEmployeesDto>>
    {
        private readonly IApplicationDbContext _dbContext;

        public GetEmployeesQueryHandler(IApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }

        public async Task<List<GetEmployeesDto>> Handle(GetEmployeesQuery request, CancellationToken cancellationToken)
        {
            var dbQuery = _dbContext.Employees.AsQueryable();

            var employees = await dbQuery
                .ToListAsync(cancellationToken);
            var employeeDto = MapGetEmployeesDtos(employees);
            return employeeDto.ToList();
        }

        private IEnumerable<GetEmployeesDto> MapGetEmployeesDtos(List<Employee> employees)
        {
            List<GetEmployeesDto> getEmployeesDto = new List<GetEmployeesDto>();
            foreach (var employee in employees)
            {

                yield return new GetEmployeesDto()
                {
                    Id = employee.Id,
                    IdentityNumber = employee.IdentityNumber,
                    FirstName = employee.FirstName,
                    LastName = employee.LastName,
                    Gender = employee.Gender,
                    MaritalStatus = employee.MaritalStatus,
                    BirthDate = employee.BirthDate,
                    BirthPlace = employee.BirthPlace,
                    EducationLevel = employee.EducationLevel,
                    LanguageSkill = employee.LanguageSkill,


                };
            }

        }
    }
}
