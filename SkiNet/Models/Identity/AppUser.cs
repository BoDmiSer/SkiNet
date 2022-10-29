using Microsoft.AspNetCore.Identity;

namespace SkiNet.Models.Identity
{
    public class AppUser: IdentityUser
    {
        public string DisplayName { get; set; }
        public Address Address { get; set; }
    }
}
