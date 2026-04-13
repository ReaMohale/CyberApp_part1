using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace CyberApp_part1
{
    /// <summary>
        /// Represents the chatbot that interacts with the user and provides cybersecurity advice.
        /// </summary>
    public class Chatbot
    {
        private readonly ResponseHandler _responseHandler;
        private string? _userName;

        public Chatbot()
        {
            _responseHandler = new ResponseHandler();
        }

        /// <summary>
        /// Starts the chatbot interaction with the user.
        /// </summary>
        public void Start()
        {
            PlayVoiceGreeting();
            ConsoleUI.ShowAsciiArt();
            ConsoleUI.ShowWelcomeMessage();
            _userName = GetUserName();
            ConsoleUI.ShowDivider();
            ConsoleUI.TypeText($"Nice to meet you, {_userName}! I'm your Cybersecurity Awareness Assistant.\n");
            RunConversationLoop();
        }

       // playing a greeting sound when the chatbot starts.
        private void PlayVoiceGreeting()
        {
            string audioPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "greeting.wav");
            if (File.Exists(audioPath))
            {
                try
                {
                    using (var player = new SoundPlayer(audioPath))
                    {
                        player.PlaySync(); // waits until greeting finishes
                    }
                }
                catch (Exception ex)
                {
                    ConsoleUI.ShowError($"Could not play greeting: {ex.Message}");
                }
            }
            else
            {
                ConsoleUI.ShowError("greeting.wav not found. Voice greeting skipped.");
            }
        }

        // Prompts the user for their name and validates the input to ensure it's not empty or whitespace.
        private string GetUserName()
        {
            ConsoleUI.TypeText("What's your name? ");
            string? name = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(name))
            {
                ConsoleUI.ShowError("Name cannot be empty. Please enter your name: ");
                name = Console.ReadLine();
            }
            return name.Trim();
        }

        // Main conversation loop that continues until the user decides to exit. 
        private void RunConversationLoop()
        {
            bool running = true;
            while (running)
            {
                ConsoleUI.ShowUserPrompt();
                string? input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    ConsoleUI.ShowError("I didn't catch that. Please type something.\n");
                    continue;
                }

                string lowerInput = input.ToLower();
                if (lowerInput == "exit" || lowerInput == "quit" || lowerInput == "bye")
                {
                    ConsoleUI.TypeText($"Goodbye, {_userName}! Stay safe online! \n");
                    running = false;
                    continue;
                }

                string response = _responseHandler.GetResponse(lowerInput);
                ConsoleUI.TypeText(response + "\n");
            }
        }
    }
}
