using EF_Core_Learning.Model;
using Microsoft.EntityFrameworkCore;
using PasswordGenerator;

namespace EF_Core_Learning.Database
{
    internal class MyDBContext : DbContext

    {

        public DbSet<UserDetails> Details { get; set; }

        public DbSet<UserHobbies> Hobbies { get; set; }

        public DbSet<UserPasswords> Passwords { get; set; }

        public DbSet<UserRole> Roles { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;TrustServerCertificate=True;Database=User_Table;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var data = new UserDetails[]
            {
            new UserDetails { UserId=1 ,UserName="Rahul",Email="Rahul.mehra@gmail.com"},
            new UserDetails { UserId=2 ,UserName="Ashwani",Email="Ashwani@gmail.com"},

            };

            var hobbiesData = new UserHobbies[]
                {
                new UserHobbies { HobbiesId=1,HobbiesName="Reading books"},
                new UserHobbies { HobbiesId=2,HobbiesName="Playing football"},
                new UserHobbies { HobbiesId=3,HobbiesName="Travelling"}
                };

            var UserPasswordsList = new UserPasswords[]
                { 
            new UserPasswords {PasswordId=1, Password= new Password().Next(),UserId=1},
            new UserPasswords {PasswordId=2, Password= new Password().Next(),UserId =2},
            };

            var UserRoles = new UserRole[] {
            new UserRole { RoleId=1,RoleName="PMO",UserId=1},
            new UserRole{ RoleId=2,RoleName="PO",UserId=2 },
            new UserRole{ RoleId=3,RoleName ="User",UserId=1 }
            };

            modelBuilder.Entity<UserDetails>().HasData(data);
            modelBuilder.Entity<UserHobbies>().HasData(hobbiesData);
            modelBuilder.Entity<UserPasswords>().HasData(UserPasswordsList);
            modelBuilder.Entity<UserRole>().HasData(UserRoles);

        }


    }
}
