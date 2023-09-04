using Domain.Common;
using Domain.Entities;
using Domain.Enums.PersonalEnums;
using Microsoft.AspNetCore.Identity;

namespace Domain.Identity
{
    public class User:IdentityUser<string>,IEntityBase<string>,ICreatedByEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTimeOffset CreatedOn { get; set; }
        public string? CreatedByUserId { get; set; }

    }
}
