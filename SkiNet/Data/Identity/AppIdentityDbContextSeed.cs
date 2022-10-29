using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Internal;
using SkiNet.Models.Identity;
using System.Threading.Tasks;
using System.Linq;

namespace SkiNet.Data.Identity
{
    public class AppIdentityDbContextSeed
    {
         public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Дмитрий",
                    Email = "db@test.com",
                    UserName = "Db@test.com",
                    Address = new Address
                    {
                        FirstName = "Дмитрий",
                        LastName = "secret",
                        Street = " 94 The Street",
                        City = "Moscow",
                        State = "RU",
                        ZipCode = "394052"
                    }
                };
                
                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}
