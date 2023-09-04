using Application.Common.Interfaces;
using Domain.Common;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Common.Features.Addresses.Command.Add
{
    public class AddAddressCommandHandler : IRequestHandler<AddAddressCommand, Response<IEnumerable<Guid>>>
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public AddAddressCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<Response<IEnumerable<Guid>>> Handle(AddAddressCommand request, CancellationToken cancellationToken)
        {
            var employee = await _applicationDbContext.Employees.FindAsync(request.EmployeeId);

            if (employee == null)
            {
                return new Response<IEnumerable<Guid>>("Employee not found.", null, new List<string> { "Employee not found." });
            }

            var newAddressIds = new List<Guid>();

            foreach (var addressDto in request.Addresses)
            {
                var address = new Address
                {
                    EmployeeId = employee.Id,
                    Name = addressDto.Name,
                    Country = addressDto.Country,
                    City = addressDto.City,
                    District = addressDto.District,
                    PostCode = addressDto.PostCode,
                    AddressLine1 = addressDto.AddressLine1,
                    AddressLine2 = addressDto.AddressLine2,
                    AddressType = addressDto.AddressType
                };

                _applicationDbContext.Addresses.Add(address);
                await _applicationDbContext.SaveChangesAsync(cancellationToken);

                newAddressIds.Add(address.Id);
            }

            return new Response<IEnumerable<Guid>>("Addresses added successfully.", newAddressIds);
        }
    }
}
