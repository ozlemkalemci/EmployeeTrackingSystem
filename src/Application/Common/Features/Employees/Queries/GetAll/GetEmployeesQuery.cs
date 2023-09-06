using Domain.Entities;
using Domain.Enums.PersonalEnums;
using MediatR;

namespace Application.Common.Features.Employees.Queries.GetAll
{
    public class GetEmployeesQuery : IRequest<List<GetEmployeesDto>>
    {


    }
}
