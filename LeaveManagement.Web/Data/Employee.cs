using Microsoft.AspNetCore.Identity;

namespace LeaveManagement.Web.Data
{
    //Custom class that mimmicks the default user
    //Let the rest of the application know that this is the class it should be using for all of its operations
    public class Employee: IdentityUser
    {
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? TaxId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateJoined { get; set; }

    }
}
