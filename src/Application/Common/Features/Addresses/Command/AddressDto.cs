using Domain.Enums.ContactEnums;

namespace Application.Common.Features.Addresses.Command
{
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
