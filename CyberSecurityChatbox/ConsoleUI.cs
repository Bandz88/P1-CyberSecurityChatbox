using System;
using System.IO;

namespace CyberSecurityChatbot
{
    public static class ConsoleUI
    {
        public static void DisplayLogo()
        {
            try
            {
                string path = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "logo.txt"
                );

                string logo = File.ReadAllText(path);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(logo);
                Console.ResetColor();
            }
            catch (Exception)
            {
                Console.WriteLine("Logo could not be loaded.");
            }
        }
    }
}