using Domain.Enums.PersonalEnums;

namespace Application.Common.Features.Employees.Queries.GetAll
{
    public class GetEmployeesDto
    {
        public Guid Id { get; set; }
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public Gender Gender { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public EducationLevel EducationLevel { get; set; }
        public LanguageSkill LanguageSkill { get; set; }
    }
}
