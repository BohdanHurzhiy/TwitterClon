﻿using System;
using System.Linq;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace EntityFrameworkCoreProject
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                // создаем два объекта User
                /*  User user1 = new User { Name = "Tom", Age = 33 };
                  User user2 = new User { Name = "Alice", Age = 26 };

                  // добавляем их в бд
                  db.Users.Add(user1);
                  db.Users.Add(user2);
                  db.SaveChanges();
                  Console.WriteLine("Объекты успешно сохранены");

                  // получаем объекты из бд и выводим на консоль
                  var users = db.Users.ToList();
                  Console.WriteLine("Список объектов:");
                  foreach (User u in users)
                  {
                      Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
                  }*/
                Country country1 = new Country { Name = "Ua" };
                Country country2 = new Country { Name = "UJ" };                
            }
            Console.Read();
        }
    }
}
