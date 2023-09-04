using Domain.Enums.ContactEnums;
using Domain.Enums.JobEnums;
using Domain.Enums.PersonalEnums;

namespace Application.Common.Models
{
    public class AddNewEmployeeDto
    {
        public string UserId { get; set; }
        public string? CreatedByUserId { get; set; }
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public Gender Gender { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public EducationLevel EducationLevel { get; set; }
        public LanguageSkill LanguageSkill { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string PostCode { get; set; }
        public string AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public AddressType AddressType { get; set; }
        public Departments Department { get; set; }
        public JobTitles JobTitle { get; set; }
        public EmploymentType EmploymentType { get; set; }
        public EmploymentStatus EmploymentStatus { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? ResignationDate { get; set; }
        public DateTime? LeaveStartDate { get; set; }
        public DateTime? LeaveEndDate { get; set; }
        public string PhoneName { get; set; }
        public string PhoneNumber { get; set; }
        public PhoneNumberType PhoneNumberType { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }

        public AddNewEmployeeDto()
        {
            UserId = "50F43A97-F063-41FB-3477-08DBAC86F119";
            CreatedByUserId = "50F43A97-F063-41FB-3477-08DBAC86F119";
            IdentityNumber = " ";
            FirstName = " ";
            LastName = " ";
            BirthDate = DateTime.MinValue;
            BirthPlace = string.Empty;
            Gender = Gender.Other;
            MaritalStatus = MaritalStatus.Single;
            EducationLevel = EducationLevel.BachelorDegree;
            LanguageSkill = LanguageSkill.English;
            Country = " ";
            City = " ";
            District = " ";
            PostCode = " ";
            AddressLine1 = " ";
            AddressLine2 = null;
            AddressType = AddressType.Home;
            Department = Departments.ITDepartment;
            JobTitle = JobTitles.BackendDeveloper;
            EmploymentType = EmploymentType.FullTime;
            EmploymentStatus = EmploymentStatus.Active;
            HireDate = DateTime.MinValue;
            ResignationDate = null;
            LeaveStartDate = null;
            LeaveEndDate = null;
            PhoneName = " ";
            PhoneNumber = " ";
            PhoneNumberType = PhoneNumberType.Home;
            TaskName = " ";
            TaskDescription = " ";
        }
    }


}
