using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.Extensions.Options;
using System.Linq;

namespace CheckingCreationOfModels
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                /*
                 * Without navigation property and foreign key
                 */
                Company microsoft = new Company { Name = "Microsoft" };
                Company google = new Company { Name = "Google" };
                db.Companies.AddRange(microsoft, google);
                db.SaveChanges();
                User tom = new User { Name = "Tom", Company = microsoft };
                User bob = new User { Name = "Bob"};
                User alice = new User { Name = "Alice"};
                User kate = new User { Name = "Kate"};
                db.Users.AddRange(tom, bob, alice, kate);
                db.SaveChanges();


                // получаем пользователей
                var users = db.Users.ToList();
                foreach (var user in users) Console.WriteLine($"{user.Name}");

                // Удаляем первую компанию
               /* var comp = db.Companies.FirstOrDefault();
                db.Companies.Remove(comp);
                db.SaveChanges();*/
                Console.WriteLine("\nСписок пользователей после удаления компании");
                // снова получаем пользователей
                users = db.Users.ToList();
                foreach (var user in users) Console.WriteLine($"{user.Name}");
                Console.WriteLine("END!!!");
            }
            Console.Read();
        }
    }
}
