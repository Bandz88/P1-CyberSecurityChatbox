using System;

namespace CyberSecurityChatbot
{
    class Program
    {
        static void Main()
        {
            
            AudioPlayer.PlayGreeting();

            //  Display ASCII logo
            ConsoleUI.DisplayLogo();

            
            User user = new User();

            //  Ask user name
            Console.Write("Enter your name: ");
            string? nameInput = Console.ReadLine();

            user.Name = string.IsNullOrWhiteSpace(nameInput)
                ? "User"
                : nameInput;

            //  Welcome message
            Console.WriteLine($"\nWelcome {user.Name}! I'm here to help you stay safe online.");

           
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nYou: ");
                Console.ResetColor();
                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Bot: Please enter something.");
                    continue;
                }

                string response = Chatbot.GetResponse(input);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Bot: " + response);
                Console.ResetColor();
            }
        }
    }
}