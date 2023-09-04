using Domain.Enums.ContactEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Features.PhoneNumbers
{
    public class PhoneDto
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public PhoneNumberType PhoneNumberType { get; set; }
    }
}
