using Application.Common.Features.Employees.Command.Add;
using Application.Common.Features.Employees.Queries.GetAll;
using Domain.Entities;
using Infrastructure.Persistence.Contexts;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ApplicationDbContext _dbContext;

        public EmployeeController(IMediator mediator, ApplicationDbContext dbContext)
        {
            _mediator = mediator;
            _dbContext = dbContext;
        }

        [HttpPost("add-employee")]
        public async Task<IActionResult> AddEmployeeAsync(AddEmployeeCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpGet("get-all-employees")]
        public async Task<IActionResult> GetAllEmployees()
        {
            var query = new GetEmployeesQuery();

            var employees = await _mediator.Send(query);

            return Ok(employees);
        }

        [HttpGet("get-employee-by-id/{employeeId}")]
        public async Task<IActionResult> GetEmployeeByIdAsync(Guid employeeId)
        {
            var employee = await _dbContext.GetByIdAsync<Employee>(employeeId);

            if (employee == null)
            {
                return NotFound("Employee not found.");
            }

            return Ok(employee);
        }
    }
}
