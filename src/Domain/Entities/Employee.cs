using Domain.Common;
using Domain.Enums.PersonalEnums;
using Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Employee : EntityBase<Guid>
    {
        
        public string UserId { get; set; }
        public User User { get; set; }
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public Gender Gender { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public EducationLevel EducationLevel { get; set; }
        public LanguageSkill LanguageSkill { get; set; }
        public EmployeeJobInfo EmployeeJobInfo { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public string? CreatedByUserId { get; set; }
        public ICollection<Address> Addresses { get; set; }
        public ICollection<Phone> Phones { get; set; }
        public ICollection<EmployeeWorkingHours> EmployeeWorkingHours { get; set; }
        
    }
}
