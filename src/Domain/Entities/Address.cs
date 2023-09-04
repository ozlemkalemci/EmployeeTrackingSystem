using Domain.Common;
using Domain.Enums.ContactEnums;

namespace Domain.Entities
{
    public class Address : EntityBase<Guid>
    {
        public string Name { get; set; }
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string PostCode { get; set; }
        public string AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public AddressType AddressType { get; set; }


    }
}
