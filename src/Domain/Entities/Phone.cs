using Domain.Common;
using Domain.Enums.ContactEnums;

namespace Domain.Entities
{
    public class Phone : EntityBase<Guid>
    {
        public string Name { get; set; }
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public string PhoneNumber { get; set; }
        public PhoneNumberType PhoneNumberType { get; set; }
    }
}
