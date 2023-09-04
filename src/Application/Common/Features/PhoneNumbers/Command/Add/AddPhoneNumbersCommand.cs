using Domain.Common;
using Domain.Enums.ContactEnums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Features.PhoneNumbers.Command.Add
{
    public class AddPhoneNumbersCommand : IRequest<Response<IEnumerable<Guid>>>
    {
        public Guid EmployeeId { get; set; }
        public List<PhoneDto> Phones { get; set; }

        public class PhoneDto
        {
            public string Name { get; set; }
            public string PhoneNumber { get; set; }
            public PhoneNumberType PhoneNumberType { get; set; }
        }
    }
}
