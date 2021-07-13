using System;

namespace ModelsForTwitter
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DbTwitterCloneContex twitterClone = new DbTwitterCloneContex())
            {
                Console.WriteLine("END!!");
            }
        }
    }
}
