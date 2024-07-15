using EF_Core_Learning.Database;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        using (var context = new MyDBContext())
        {
            var users = context.Details.ToList();

            foreach (var user in users)
            {

                Console.WriteLine($"{user.UserName}");
            }

            #region create method
            //var newValue = new UserDetails { UserName = "Nishank", Email = "Nishank@gmail.com" };
            //context.Details.Add(newValue);
            //context.SaveChanges();

            #endregion

            #region  Read (filter,sort)

            var nameHaving_R = from b in context.Details
                               where b.UserName.StartsWith("R")
                               select b;


            Console.WriteLine("User names having R");
            if (nameHaving_R != null)
            {
                foreach (var user in nameHaving_R) { Console.WriteLine(user.UserName); }

            }
            else
            {
                Console.WriteLine("No Name in Details table found starting with letter R ");
            }

            var namesInAscOrder = context.Details.OrderBy(e => e.UserName);
            foreach (var user in namesInAscOrder) { Console.WriteLine(user.UserName); }

            #endregion

            #region Update 
            //var nameToUpdate = context.Details.FirstOrDefault(p => p.UserId == 3);
            //if (nameToUpdate != null)
            //{
            //    nameToUpdate.UserName = "Afsal";
            //    context.SaveChanges();
            //}
            #endregion

            #region Remove and Delete
            var nameToDelete = context.Details.FirstOrDefault(p => p.UserId == 3);
            if (nameToDelete != null)
{
                context.Details.Remove(nameToDelete);
                context.SaveChanges();
            }
            #endregion

            #region tracking and non-tracking
            foreach (var entry in context.ChangeTracker.Entries())
    {
                Console.WriteLine($"Entity:{entry.Entity.GetType().Name} " +
                    $"State : {entry.State.ToString()}");
            }
            #endregion

            #region raw queries 
            var nameHavingP = context.Roles.FromSql($"SELECT * FROM Roles WHERE RoleName LIKE 'P%';")
                              .ToList();

            Console.WriteLine("Roles having P in starting");
            foreach (var entry in nameHavingP)
        {

                Console.WriteLine($"user ID :{entry.UserId} , User Role :{entry.RoleName}");
            }
            #endregion


            


        }
    }
}
