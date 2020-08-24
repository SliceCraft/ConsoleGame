using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame
{
    class virus_ransomware
    {
        public void Virus_ransomware()
        {
            Console.Title = "Locked!";
            Console.WriteLine("This file is locked with a password!");
            Console.Write("Password: ");
            var password = Console.ReadLine();
            if (password != "Passw0rd") return;
            Console.Title = "Oops!";
            Console.WriteLine();
            Console.WriteLine("Writing to C:/wall/ransomware.autoexec");
            System.Threading.Thread.Sleep(600);
            Console.WriteLine("Encoding files");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Making you realize you made a mistake");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("So you made a big mistake");
            Console.WriteLine("You installed this piece of ransomware");
            Console.WriteLine("And now you're fucked");
            Console.WriteLine("Now give me 1 bitcoin or il delete the key");
            Console.WriteLine("But maybe im not fair at all I wont give you a key at all");
            Console.WriteLine("Idk, just reinstall your os and be sad lmao");
            while (true)
            {
                Console.WriteLine();
                Console.Write("C:/fucked > ");
                string command_virus_ransomware = Console.ReadLine();
                if(command_virus_ransomware == "exit")
                {
                    Environment.Exit(0);
                }
                Console.WriteLine("Invalid transaction id");
            }
        }
    }
}
