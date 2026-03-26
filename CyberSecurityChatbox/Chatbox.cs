using System;

namespace CyberSecurityChatbot
{
    public class Chatbot
    {
        public static string GetResponse(string input)
        {
            input = input.ToLower();

            if (input.Contains("how are you"))
                return "I'm functioning perfectly and ready to teach cybersecurity!";

            if (input.Contains("purpose"))
                return "My purpose is to help you stay safe online.";

            if (input.Contains("password"))
                return "Use strong passwords with letters, numbers, and symbols.";

            if (input.Contains("phishing"))
                return "Never click suspicious links from unknown emails.";

            if (input.Contains("browsing"))
                return "Always check HTTPS before entering personal data.";

            return "I didn't quite understand that. Could you rephrase?";
        }
    }
}