using CLI_Project_V2_Aditya.CLI_Project.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CLI_Project_V2_Aditya.CLI_Project.Utilities
{
    internal class Utility
    {
        public static void MainCommand()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Masukkan perintah (/help untuk menu): ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string message = Console.ReadLine().ToLower().Trim();
            Service.pilihan(message);
            Console.ResetColor();
        }

        public static void AlertCommand(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void AnswerCommand(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            message = Console.ReadLine().ToLower().Trim();
            Console.ResetColor();
        }

        public static void InfoCommand(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void InputCommand(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(message);
            Console.ResetColor();
        }

        public static void ErrorCommand(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

    }
}
