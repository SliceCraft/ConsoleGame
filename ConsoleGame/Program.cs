using System;
using System.Diagnostics;
using ConsoleGame;
using System.Media;
using System.Threading;

namespace ConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int installed = 0;
            int readme = 0;
            Console.Title = "Initializing";
            Console.Clear();
            Console.WriteLine("Retrieving updates");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("No updates found");
            Console.WriteLine("Loading configuration file");
            System.Threading.Thread.Sleep(1000);
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("Configuration file loaded");
            Console.WriteLine("Initializing commands!");
            System.Threading.Thread.Sleep(700);
            Console.WriteLine();
            Console.WriteLine("Execute install.exe to install the OS");
            Console.WriteLine();
            System.Threading.Thread.Sleep(400);

            for (string current_running = "C:/boot"; current_running != "C:/boot/wall.start";)
            {
                Console.Title = "Boot menu";
                Console.Write("C:/boot > ");
                current_running = Console.ReadLine();
                
                if (current_running == "wall.start")
                {
                    if (installed == 0)
                    {
                        Console.WriteLine("Wall has not been installed yet");
                    }
                    else
                    {
                        current_running = "C:/boot/wall.start";
                    }
                }
                else if (current_running == "wall.start -loadram")
                {
                    current_running = "C:/boot/wall.start";
                }
                else if (current_running == "exit")
                {
                    Environment.Exit(0);
                }
                else if (current_running == "install.exe")
                {
                    if (installed == 1)
                    {
                        Console.WriteLine("Wall has already been installed");
                    }
                    else
                    {
                        ConsoleGame.install installCommand = new install();
                        installCommand.Install();
                        installed = 1;
                        Console.Title = "Initializing";
                        Console.Clear();
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine("Retrieving updates");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("No updates found");
                        Console.WriteLine("Loading configuration file");
                        System.Threading.Thread.Sleep(1000);
                        Console.Write(".");
                        System.Threading.Thread.Sleep(1000);
                        Console.Write(".");
                        System.Threading.Thread.Sleep(1000);
                        Console.Write(".");
                        System.Threading.Thread.Sleep(1000);
                        Console.Write(".");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine();
                        Console.WriteLine("Configuration file loaded");
                        Console.WriteLine("Initializing commands!");
                        System.Threading.Thread.Sleep(700);
                        Console.WriteLine();
                        Console.WriteLine("Execute wall.start to open the OS");
                        Console.WriteLine();
                        System.Threading.Thread.Sleep(400);
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("C:/boot/" + current_running);
                    Console.WriteLine("Is not an existing command!");
                    Console.WriteLine();
                }
            }

            Console.Title = "Wall 5";
            Console.Clear();
            Console.WriteLine("Wall 5, Trinity© 2020-2020");
            Console.WriteLine("Logged in as: root");
            Console.WriteLine("Execute commands below");
            if (readme == 0)
            {
                Console.WriteLine("You have one unread readme, please run: readme.txt");
            }
            System.Threading.Thread.Sleep(800);

            while (true)
            {
                Console.Title = "Wall 5";
                Console.WriteLine();
                Console.Write("C:/ > ");
                string command = Console.ReadLine();

                if (command == "debug.exe")
                {
                    Console.WriteLine();
                    Console.WriteLine("You found the debug command!");
                    Console.WriteLine("Have some music!");
                    Console.Beep(659, 125);
                    Console.Beep(659, 125);
                    Thread.Sleep(125);
                    Console.Beep(659, 125);
                    Thread.Sleep(167);
                    Console.Beep(523, 125);
                    Console.Beep(659, 125);
                    Thread.Sleep(125);
                    Console.Beep(784, 125);
                    Thread.Sleep(375);
                    Console.Beep(392, 125);
                    Thread.Sleep(375);
                    Console.Beep(523, 125);
                    Thread.Sleep(250);
                    Console.Beep(392, 125);
                    Thread.Sleep(250);
                    Console.Beep(330, 125);
                    Thread.Sleep(250);
                    Console.Beep(440, 125);
                    Thread.Sleep(125);
                    Console.Beep(494, 125);
                    Thread.Sleep(125);
                    Console.Beep(466, 125);
                    Thread.Sleep(42);
                    Console.Beep(440, 125);
                    Thread.Sleep(125);
                    Console.Beep(392, 125);
                    Thread.Sleep(125);
                    Console.Beep(659, 125);
                    Thread.Sleep(125);
                    Console.Beep(784, 125);
                    Thread.Sleep(125);
                    Console.Beep(880, 125);
                    Thread.Sleep(125);
                    Console.Beep(698, 125);
                    Console.Beep(784, 125);
                    Thread.Sleep(125);
                    Console.Beep(659, 125);
                    Thread.Sleep(125);
                    Console.Beep(523, 125);
                    Thread.Sleep(125);
                    Console.Beep(587, 125);
                    Console.Beep(494, 125);
                    Thread.Sleep(125);
                    Console.Beep(523, 125);
                    Thread.Sleep(250);
                    Console.Beep(392, 125);
                    Thread.Sleep(250);
                    Console.Beep(330, 125);
                    Thread.Sleep(250);
                    Console.Beep(440, 125);
                    Thread.Sleep(125);
                    Console.Beep(494, 125);
                    Thread.Sleep(125);
                    Console.Beep(466, 125);
                    Thread.Sleep(42);
                    Console.Beep(440, 125);
                    Thread.Sleep(125);
                    Console.Beep(392, 125);
                    Thread.Sleep(125);
                    Console.Beep(659, 125);
                    Thread.Sleep(125);
                    Console.Beep(784, 125);
                    Thread.Sleep(125);
                    Console.Beep(880, 125);
                    Thread.Sleep(125);
                    Console.Beep(698, 125);
                    Console.Beep(784, 125);
                    Thread.Sleep(125);
                    Console.Beep(659, 125);
                    Thread.Sleep(125);
                    Console.Beep(523, 125);
                    Thread.Sleep(125);
                    Console.Beep(587, 125);
                    Console.Beep(494, 125);
                    Thread.Sleep(375);
                    Console.Beep(784, 125);
                    Console.Beep(740, 125);
                    Console.Beep(698, 125);
                    Thread.Sleep(42);
                    Console.Beep(622, 125);
                    Thread.Sleep(125);
                    Console.Beep(659, 125);
                    Thread.Sleep(167);
                    Console.Beep(415, 125);
                    Console.Beep(440, 125);
                    Console.Beep(523, 125);
                    Thread.Sleep(125);
                    Console.Beep(440, 125);
                    Console.Beep(523, 125);
                    Console.Beep(587, 125);
                    Thread.Sleep(250);
                    Console.Beep(784, 125);
                    Console.Beep(740, 125);
                    Console.Beep(698, 125);
                    Thread.Sleep(42);
                    Console.Beep(622, 125);
                    Thread.Sleep(125);
                    Console.Beep(659, 125);
                    Thread.Sleep(167);
                    Console.Beep(698, 125);
                    Thread.Sleep(125);
                    Console.Beep(698, 125);
                    Console.Beep(698, 125);
                    Thread.Sleep(625);
                    Console.Beep(784, 125);
                    Console.Beep(740, 125);
                    Console.Beep(698, 125);
                    Thread.Sleep(42);
                    Console.Beep(622, 125);
                    Thread.Sleep(125);
                    Console.Beep(659, 125);
                    Thread.Sleep(167);
                    Console.Beep(415, 125);
                    Console.Beep(440, 125);
                    Console.Beep(523, 125);
                    Thread.Sleep(125);
                    Console.Beep(440, 125);
                    Console.Beep(523, 125);
                    Console.Beep(587, 125);
                    Thread.Sleep(250);
                    Console.Beep(622, 125);
                    Thread.Sleep(250);
                    Console.Beep(587, 125);
                    Thread.Sleep(250);
                    Console.Beep(523, 125);
                    Thread.Sleep(1125);
                    Console.Beep(784, 125);
                    Console.Beep(740, 125);
                    Console.Beep(698, 125);
                    Thread.Sleep(42);
                    Console.Beep(622, 125);
                    Thread.Sleep(125);
                    Console.Beep(659, 125);
                    Thread.Sleep(167);
                    Console.Beep(415, 125);
                    Console.Beep(440, 125);
                    Console.Beep(523, 125);
                    Thread.Sleep(125);
                    Console.Beep(440, 125);
                    Console.Beep(523, 125);
                    Console.Beep(587, 125);
                    Thread.Sleep(250);
                    Console.Beep(784, 125);
                    Console.Beep(740, 125);
                    Console.Beep(698, 125);
                    Thread.Sleep(42);
                    Console.Beep(622, 125);
                    Thread.Sleep(125);
                    Console.Beep(659, 125);
                    Thread.Sleep(167);
                    Console.Beep(698, 125);
                    Thread.Sleep(125);
                    Console.Beep(698, 125);
                    Console.Beep(698, 125);
                    Thread.Sleep(625);
                    Console.Beep(784, 125);
                    Console.Beep(740, 125);
                    Console.Beep(698, 125);
                    Thread.Sleep(42);
                    Console.Beep(622, 125);
                    Thread.Sleep(125);
                    Console.Beep(659, 125);
                    Thread.Sleep(167);
                    Console.Beep(415, 125);
                    Console.Beep(440, 125);
                    Console.Beep(523, 125);
                    Thread.Sleep(125);
                    Console.Beep(440, 125);
                    Console.Beep(523, 125);
                    Console.Beep(587, 125);
                    Thread.Sleep(250);
                    Console.Beep(622, 125);
                    Thread.Sleep(250);
                    Console.Beep(587, 125);
                    Thread.Sleep(250);
                    Console.Beep(523, 125);
                }
                else if(command == "exit")
                {
                    Environment.Exit(0);
                }
                else if (command == "clear")
                {
                    Console.Clear();
                }
                else if (command == "help")
                {
                    Console.WriteLine();
                    Console.WriteLine("help : Show all commands");
                    Console.WriteLine("clear : Clear the console");
                    Console.WriteLine("exit : Exit out of the os");
                    Console.WriteLine("debug.exe : A debug command that you're probably not supposed to see");
                    Console.WriteLine("virus_ransomware.exe : A ransomware, only use this on other pcs!");
                }
                else if (command == "easter_egg.exe")
                {
                    Console.WriteLine();
                    Console.WriteLine("You looked at the loading screen, good job.");
                    Console.WriteLine("This game was made by Slice.");
                    Console.WriteLine("At the time of writing this the existence of Trinity is pretty uncertain as its new");
                    Console.WriteLine("But incase Trinity is still alive:");
                    Console.WriteLine("Trinity is a Discord bot that helps you in managing your server");
                    Console.WriteLine("Trinity has also made the Hypixel Stats bot that will get information from Hypixel");
                    Console.WriteLine("If this invite link is still valid you can join the");
                    Console.WriteLine("Trinity discord server via this link: https://discord.com/invite/RGD8fkD");
                    Console.WriteLine();
                }
                else if (command == "readme.txt")
                {
                    readme = 1;
                    Console.WriteLine();
                    Console.WriteLine("Hello, your friend hopefully gave you this usb.");
                    Console.WriteLine("If your friend gave it to you then we're good.");
                    Console.WriteLine("I have been developing this os for a while, it has some powerful hacks.");
                    Console.WriteLine("People got to know about this os 2 weeks ago and since then I've been attacked multiple times.");
                    Console.WriteLine("I need you to destroy the source code and compiling servers.");
                    Console.WriteLine("The backdoor I was making has only been finished by a tiny bit.");
                    Console.WriteLine("You need to exploit the restart backdoor to get access to the entire server.");
                    Console.WriteLine("I cant help you any further since people are breaking in my house to get this code.");
                    Console.WriteLine("Please hurry!");
                    Console.WriteLine("Password for viruses: Passw0rd");
                    Console.WriteLine();
                }
                else if (command == "virus_ransomware.exe")
                {
                    ConsoleGame.virus_ransomware virusRansomCommand = new virus_ransomware();
                    virusRansomCommand.Virus_ransomware();
                }
                else if (command == "virus_bootcorrupt.exe")
                {
                    ConsoleGame.virus_bootcorrupt virusBootCorruptCommand = new virus_bootcorrupt();
                    virusBootCorruptCommand.Virus_bootcorrupt();
                }
                else
                {
                    Console.WriteLine("Command not found!");
                }
            }
            
        }
    }
}