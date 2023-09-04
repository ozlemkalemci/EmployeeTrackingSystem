using Application.Common.Interfaces;
using Domain.Common;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Features.PhoneNumbers.Command.Add
{
    public class AddPhoneNumbersCommandHandler : IRequestHandler<AddPhoneNumbersCommand, Response<IEnumerable<Guid>>>
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public AddPhoneNumbersCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<Response<IEnumerable<Guid>>> Handle(AddPhoneNumbersCommand request, CancellationToken cancellationToken)
        {
            var employee = await _applicationDbContext.Employees.FindAsync(request.EmployeeId);

            if (employee == null)
            {
                return new Response<IEnumerable<Guid>>("Employee not found.", null, new List<string> { "Employee not found." });
            }

            var phoneIds = new List<Guid>();

            foreach (var phoneDto in request.Phones)
            {
                var phone = new Phone
                {
                    Name = phoneDto.Name,
                    PhoneNumber = phoneDto.PhoneNumber,
                    PhoneNumberType = phoneDto.PhoneNumberType,
                    EmployeeId = employee.Id
                };

                await _applicationDbContext.Phones.AddAsync(phone, cancellationToken);
                phoneIds.Add(phone.Id);
            }

            await _applicationDbContext.SaveChangesAsync(cancellationToken);

            return new Response<IEnumerable<Guid>>("Phone numbers added successfully.", phoneIds);
        }
    }
}
