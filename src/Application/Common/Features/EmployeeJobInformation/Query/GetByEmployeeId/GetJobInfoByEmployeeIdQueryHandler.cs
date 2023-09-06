using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Features.EmployeeJobInformation.Query.GetByEmployeeId
{
    public class GetJobInfoByEmployeeIdQueryHandler : IRequestHandler<GetJobInfoByEmployeeIdQuery, List<GetJobInfoByEmployeeIdDto>>
    {
        private readonly IApplicationDbContext _dbContext;

        public GetJobInfoByEmployeeIdQueryHandler(IApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }

        public async Task<List<GetJobInfoByEmployeeIdDto>> Handle(GetJobInfoByEmployeeIdQuery request, CancellationToken cancellationToken)
        {
            var dbQuery = _dbContext.EmployeeJobInfos.AsQueryable();
            var employeeId = request.EmployeeId;

            var jobInfos = await dbQuery
                .Include(j => j.Employee)
                .Where(j => j.EmployeeId == employeeId)
                .ToListAsync(cancellationToken);


            var employeeDto = MapGetJobInfosDtos(jobInfos);
            return employeeDto.ToList();
        }

        private IEnumerable<GetJobInfoByEmployeeIdDto> MapGetJobInfosDtos(List<EmployeeJobInfo> employeeJobInfos)
        {
            List<GetJobInfoByEmployeeIdDto> getJobInfoByEmployeeIdDtos = new List<GetJobInfoByEmployeeIdDto>();
            foreach (var employee in employeeJobInfos)
            {

                yield return new GetJobInfoByEmployeeIdDto()
                {
                    Id = employee.Id,
                    EmployeeId = employee.Id,
                    Department = employee.Department,
                    JobTitle = employee.JobTitle,
                    EmploymentStatus = employee.EmploymentStatus,
                    EmploymentType = employee.EmploymentType,
                    HireDate = employee.HireDate,
                    LeaveEndDate = employee.LeaveEndDate,
                    LeaveStartDate = employee.LeaveStartDate,
                    ResignationDate = employee.ResignationDate,

                };
            }

        }
    }
}



