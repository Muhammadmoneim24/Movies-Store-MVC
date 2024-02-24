using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Mvc_Day4.Areas.Identity.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder builder)
        {
            var PassowrdHasher = new PasswordHasher<IdentityUser>();

            List<IdentityRole> roles = new List<IdentityRole>()
            {
                new IdentityRole("Adminstration"){Id=Guid.NewGuid().ToString(),NormalizedName="ADMINSTRATION"},
                new IdentityRole("Manager"){Id=Guid.NewGuid().ToString(),NormalizedName="MANAGER"},
                new IdentityRole("User"){Id=Guid.NewGuid().ToString(),NormalizedName="USER"},
                new IdentityRole("Med-Manager"){Id=Guid.NewGuid().ToString(),NormalizedName="MED-MANAGER"}


            };
            builder.Entity<IdentityRole>().HasData(roles);
            List<IdentityUser> users = new List<IdentityUser>()
            {
                new User()
                {Id=Guid.NewGuid().ToString(),
                    FirstName="Mohamed",
                    LastName="Ahmed",
                    Age=22,
                    UserName="Mohamed.Ahmed@gmail.com",
                    NormalizedUserName="MOHAMED.AHMED@GMAIL.COM",
                    Email="Mohamed.Ahmed@gmail.com"  ,
                    NormalizedEmail="MOHAMED.AHMED@GMAIL.COM",
                    EmailConfirmed=true,
                    SecurityStamp=Guid.NewGuid().ToString(),
                    ConcurrencyStamp=Guid.NewGuid().ToString(),
                    PhoneNumber="01094456724",
                    PhoneNumberConfirmed=true,
                    TwoFactorEnabled=true,
                    LockoutEnd=null ,
                    AccessFailedCount=0   
                    
                },
                new User()
                {Id=Guid.NewGuid().ToString(),
                    FirstName="Ali",
                    LastName="Ahmed",
                    Age=20,
                    UserName="Ali.Ahmed@gmail.com",
                    NormalizedUserName="ALI.AHMED@GMAIL.COM",
                    Email="Ali.Ahmed@gmail.com"  ,
                    NormalizedEmail="ALI.AHMED@GMAIL.COM",
                    EmailConfirmed=true,
                    SecurityStamp=Guid.NewGuid().ToString(),
                    ConcurrencyStamp=Guid.NewGuid().ToString(),
                    PhoneNumber="01194456724",
                    PhoneNumberConfirmed=true,
                    TwoFactorEnabled=true,
                    LockoutEnd=null ,
                    AccessFailedCount=0
                },
                new User()
                {Id=Guid.NewGuid().ToString(),
                    FirstName="Alaa",
                    LastName="Mohamed",
                    Age=21,
                    UserName="Alaa.Mohamed@gmail.com",
                    NormalizedUserName="ALAA.MOHAMED@GMAIL.COM",
                    Email="Alaa.Mohamed@gmail.com"  ,
                    NormalizedEmail="ALAA.MOHAMED@GMAIL.COM",
                    EmailConfirmed=true,
                    SecurityStamp=Guid.NewGuid().ToString(),
                    ConcurrencyStamp=Guid.NewGuid().ToString(),
                    PhoneNumber="01294456724",
                    PhoneNumberConfirmed=true,
                    TwoFactorEnabled=true,
                    LockoutEnd=null ,
                    AccessFailedCount=0
                },
                new User()
                {Id=Guid.NewGuid().ToString(),
                    FirstName="Mona",
                    LastName="Mohamed",
                    Age=20,
                    UserName="Mona.Mohamed@gmail.com",
                    NormalizedUserName="MONA.MOHAMED@GMAIL.COM",
                    Email="Mona.Mohamed@gmail.com"  ,
                    NormalizedEmail="MONA.MOHAMED@GMAIL.COM",
                    EmailConfirmed=true,
                    SecurityStamp=Guid.NewGuid().ToString(),
                    ConcurrencyStamp=Guid.NewGuid().ToString(),
                    PhoneNumber="01095556724",
                    PhoneNumberConfirmed=true,
                    TwoFactorEnabled=true,
                    LockoutEnd=null ,
                    AccessFailedCount=0
                },


            };

            foreach(var user in users) 
            {
                user.PasswordHash = PassowrdHasher.HashPassword(user,"Web123456789@");
            }

            builder.Entity<User>().HasData(users);

            List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>() 
            {
                new IdentityUserRole<string>(){UserId=users[0].Id,RoleId=roles[0].Id},
                new IdentityUserRole<string>(){UserId=users[0].Id,RoleId=roles[1].Id},
                new IdentityUserRole<string>(){UserId=users[0].Id,RoleId=roles[2].Id},
                new IdentityUserRole<string>(){UserId=users[0].Id,RoleId=roles[3].Id },
                new IdentityUserRole<string>(){UserId=users[1].Id,RoleId=roles[1].Id},
                new IdentityUserRole<string>(){UserId=users[2].Id,RoleId=roles[2].Id},
                new IdentityUserRole<string>(){UserId=users[3].Id,RoleId=roles[3].Id},



            };
            builder.Entity<IdentityUserRole<string>>().HasData(userRoles);


        }
    }
}
