using Domain.Common;
using Domain.Enums.PersonalEnums;
using MediatR;

namespace Application.Common.Features.Employees.Command.Add
{
    public class AddEmployeeCommand : IRequest<Response<Guid>>
    {
        public string UserId { get; set; }
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public Gender Gender { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public EducationLevel EducationLevel { get; set; }
        public LanguageSkill LanguageSkill { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public string CreatedByUserId { get; set; }
    }
}
