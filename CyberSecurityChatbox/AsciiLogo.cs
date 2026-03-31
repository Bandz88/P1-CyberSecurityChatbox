using System;

namespace CyberSecurityChatbot
{
    public static class AsciiLogo
    {
        public static void Display()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            string logo = @"
   _____       _                _____                      _ _         
  / ____|     | |              / ____|                    (_) |        
 | |     _   _| |__   ___ _ __| (___   ___  ___ _   _ _ __ _| |_ _   _ 
 | |    | | | | '_ \ / _ \ '__|\___ \ / _ \/ __| | | | '__| | __| | | |
 | |____| |_| | |_) |  __/ |   ____) |  __/ (__| |_| | |  | | |_| |_| |
  \_____|\__, |_.__/ \___|_|  |_____/ \___|\___|\__,_|_|  |_|\__|\__, |
           __/ |                                                   __/ |
          |___/                                                   |___/ 
";

            Console.WriteLine(logo);
            Console.ResetColor();
        }
    }
}