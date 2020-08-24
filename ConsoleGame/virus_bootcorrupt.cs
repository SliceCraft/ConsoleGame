using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame
{
    class virus_bootcorrupt
    {
        static Random _random = new Random();
        public static char GetLetter()
        {
            // This method returns a random lowercase letter.
            // ... Between 'a' and 'z' inclusize.
            int num = _random.Next(0, 26); // Zero to 25
            char let = (char)('a' + num);
            return let;
        }
        public void Virus_bootcorrupt()
        {
            Console.Title = "Locked";
            Console.WriteLine("This file is locked with a password!");
            Console.Write("Password: ");
            var password = Console.ReadLine();
            if (password != "Passw0rd") return;
            Console.Title = "Oops!";
            int amount = 0;
            Console.WriteLine("Oops, you accidentally enabled this boot sector corruptor.");
            Console.WriteLine("Well have fun!");
            Console.WriteLine("edit.exe: Now editing boot.boot");
            while (amount < 3800)
            {
                Console.Write(GetLetter());
                amount = amount + 1;
                System.Threading.Thread.Sleep(2);
            }
            Console.WriteLine();
            Console.WriteLine("Your bootsector got corrupted, how sad.");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
