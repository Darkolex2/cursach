using Microsoft.AspNetCore.Identity;

namespace Workforce.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Role { get; set; } = default!;
    }
}
