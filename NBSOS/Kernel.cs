using Cosmos.HAL;
using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace NBSOS
{
    public class Kernel : Sys.Kernel
    {
        string programm = "home";
        string status = "";

        protected override void BeforeRun()
        {
            Console.WriteLine("");
            Console.WriteLine("NBSOS - National Bochafreeya Secure Operating System");
        }

        protected override void Run()
        {
            Console.Write(programm+status+">> ");
            var input = Console.ReadLine();
            if (input == "/exit" && programm!="home") 
            {
            }
            switch (programm)
            {
                default: 
                {
                    Error("programm not found");
                    programm = "home";
                    break;
                }
                case "home":
                {
                    Home_programm(input);
                    break;
                }
                case "console":
                {
                    Console_programm(input);
                    break;
                }
                case "calc":
                {
                    Calculator_programm(input);
                    break;
                }
            }
        }
        protected void Error(string message)
        {
            Console.Beep(200, 100);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
        protected void Info(string message)
        {
            Console.Beep(300, 50);
            Console.Beep(400, 50);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
        protected void Warning(string message)
        {
            Console.Beep(100, 200);
            Console.Beep(200, 100);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }


        protected void Home_programm(string command)
        {
            switch (command)
            {
                default:
                {
                    programm = Console.ReadLine();
                    break;
                }
                case "exit":
                {
                    Power.ACPIShutdown();
                    break;
                }
                case "reboot":
                {
                    Power.ACPIReboot();
                    break;
                }
            }
        }
        protected void Console_programm(string command)
        {
            switch (command)
            {
                case "error": 
                {
                    Error(Console.ReadLine()); 
                    break;
                }
                case "info":
                {
                    Info(Console.ReadLine());
                    break;
                }
                case "warning":
                {
                    Warning(Console.ReadLine());
                    break;
                }
            }
        }
        protected void Calculator_programm(string command) 
        { 

        }
    }
}
