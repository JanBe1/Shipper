using Microsoft.AspNetCore.Identity;
using Shipper.Core.Enums;

namespace Shipper.Core.Model.Users
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Roles Role { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
