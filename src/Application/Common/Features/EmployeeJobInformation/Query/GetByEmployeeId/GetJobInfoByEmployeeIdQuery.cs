using MediatR;

namespace Application.Common.Features.EmployeeJobInformation.Query.GetByEmployeeId
{
    public class GetJobInfoByEmployeeIdQuery : IRequest<List<GetJobInfoByEmployeeIdDto>>
    {
        public Guid EmployeeId { get; set; }
    }
}
