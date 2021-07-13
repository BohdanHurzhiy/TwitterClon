using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.Extensions.Options;

namespace CheckingCreationOfModels
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
               
                Console.WriteLine("END!!!");
            }
            Console.Read();
        }
    }
}
