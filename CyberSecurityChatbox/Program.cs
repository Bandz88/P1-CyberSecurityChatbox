using System;

namespace CyberSecurityChatbot
{
    class Program
    {
        static void Main()
        {
            // Optional professional startup setup
            Console.Clear();
            Console.Title = "CyberSecurity Chatbot";

            // ✅ 1. Display ASCII logo FIRST
            AsciiLogo.Display();

            // ✅ 2. Play greeting audio
            AudioPlayer.PlayGreeting();

            // ✅ 3. Create user
            User user = new User();

            // ✅ 4. Ask user name
            Console.Write("Enter your name: ");
            string? nameInput = Console.ReadLine();

            user.Name = string.IsNullOrWhiteSpace(nameInput)
                ? "User"
                : nameInput;

            // ✅ 5. Welcome message
            Console.WriteLine($"\nWelcome {user.Name}! I'm here to help you stay safe online.");

            // ✅ 6. Chat loop
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