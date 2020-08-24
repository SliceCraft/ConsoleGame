using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleGame
{
    class install
    {
        public void Install()
        {
            Random random = new Random();
            int min = 100;
            int max = 300;
            Console.Clear();
            Console.Title = "Loading";
            Console.WriteLine("██████████████████████████████████████████████████████████████████████");
            Console.WriteLine("Loading: USB:/install/display.driver");
            System.Threading.Thread.Sleep(random.Next(min, max));
            Console.WriteLine("Loading: USB:/install/keyboard.driver");
            System.Threading.Thread.Sleep(random.Next(min, max));
            Console.WriteLine("Loading: USB:/install/pre_install.config");
            System.Threading.Thread.Sleep(random.Next(min, max));
            Console.WriteLine("Loading: USB:/install/wall.krnl");
            System.Threading.Thread.Sleep(random.Next(min, max));
            Console.WriteLine("Loading: USB:/install/fallback.font");
            System.Threading.Thread.Sleep(random.Next(min, max));
            Console.WriteLine("Loading: USB:/install/main.font");
            System.Threading.Thread.Sleep(random.Next(min, max));
            Console.WriteLine("Loading: USB:/install/ETH.sys");
            System.Threading.Thread.Sleep(random.Next(min, max));
            Console.WriteLine("Loading: USB:/install/Defend.sys");
            System.Threading.Thread.Sleep(random.Next(min, max));
            Console.WriteLine("Loading: USB:/install/Mail.sys");
            System.Threading.Thread.Sleep(random.Next(min, max));
            Console.WriteLine("Loading: USB:/install/custom_files.conf");
            System.Threading.Thread.Sleep(random.Next(min, max));
            Console.WriteLine("Loading: USB:/install/easter_egg.exe");
            System.Threading.Thread.Sleep(random.Next(min, max));
            Console.WriteLine("Loading: USB:/install/readme.txt");
            System.Threading.Thread.Sleep(random.Next(min, max));
            Console.WriteLine("Loading: USB:/install/help.exe");
            System.Threading.Thread.Sleep(random.Next(min, max));
            Console.WriteLine("Loading: USB:/install/clear.exe");
            System.Threading.Thread.Sleep(random.Next(min, max));
            Console.WriteLine("Loading: USB:/install/exit.exe");
            System.Threading.Thread.Sleep(random.Next(min, max));
            Console.WriteLine("Loading: USB:/install/edit.exe");
            System.Threading.Thread.Sleep(random.Next(min, max));
            Console.WriteLine("██████████████████████████████████████████████████████████████████████");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Confirming successful loading to RAM");
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("Loaded files!");
            Console.WriteLine("Installing to C:");
            Console.Title = "Installing!";
            System.Threading.Thread.Sleep(1000);

            Console.Clear();
            Console.WriteLine("██████████████████████████████████████████████████████████████████████");
            Console.WriteLine("Installing: C:/wall/display.driver");
            System.Threading.Thread.Sleep(random.Next(min, max));
            Console.WriteLine("Installing: C:/wall/keyboard.driver");
            System.Threading.Thread.Sleep(random.Next(min, max));
            Console.WriteLine("Installing: C:/wall/wall.krnl");
            System.Threading.Thread.Sleep(random.Next(min, max));
            Console.WriteLine("Installing: C:/wall/fallback.font");
            System.Threading.Thread.Sleep(random.Next(min, max));
            Console.WriteLine("Installing: C:/wall/main.font");
            System.Threading.Thread.Sleep(random.Next(min, max));
            Console.WriteLine("Installing: C:/wall/ETH.sys");
            System.Threading.Thread.Sleep(random.Next(min, max));
            Console.WriteLine("Installing: C:/wall/Defend.sys");
            System.Threading.Thread.Sleep(random.Next(min, max));
            Console.WriteLine("Installing: C:/wall/Mail.sys");
            System.Threading.Thread.Sleep(random.Next(min, max));
            Console.WriteLine("Copying files: C:/Desktop (custom_files.conf)");
            System.Threading.Thread.Sleep(random.Next(min, max));
            Console.WriteLine("Installing: C:/wall/easter_egg.exe");
            System.Threading.Thread.Sleep(random.Next(min, max));
            Console.WriteLine("Installing: C:/wall/readme.txt");
            System.Threading.Thread.Sleep(random.Next(min, max));
            Console.WriteLine("Installing: C:/wall/help.exe");
            System.Threading.Thread.Sleep(random.Next(min, max));
            Console.WriteLine("Installing: C:/wall/clear.exe");
            System.Threading.Thread.Sleep(random.Next(min, max));
            Console.WriteLine("Installing: C:/wall/exit.exe");
            System.Threading.Thread.Sleep(random.Next(min, max));
            Console.WriteLine("Installing: C:/wall/edit.exe");
            System.Threading.Thread.Sleep(random.Next(min, max));
            Console.WriteLine("██████████████████████████████████████████████████████████████████████");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Confirming successful installation");
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("Installation finished, the computer will restart in 5 seconds!");
            Console.WriteLine("5");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("4");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("3");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("2");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("1");
            System.Threading.Thread.Sleep(1000);
            return;
        }
    }
}
