using Domain.Common;
using Domain.Enums.ContactEnums;
using MediatR;

namespace Application.Common.Features.Addresses.Command.Add
{
    public class AddAddressCommand : IRequest<Response<IEnumerable<Guid>>>
    {
        public Guid EmployeeId { get; set; }
        public List<AddressDto> Addresses { get; set; }

        public class AddressDto
        {
            public string Name { get; set; }
            public string Country { get; set; }
            public string City { get; set; }
            public string District { get; set; }
            public string PostCode { get; set; }
            public string AddressLine1 { get; set; }
            public string AddressLine2 { get; set; }
            public AddressType AddressType { get; set; }
        }
    }
}
