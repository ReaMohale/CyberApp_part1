using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberApp_part1
{
    /// <summary>
    /// Handles generating responses for the chatbot based on user input.
    /// </summary>
    public class ResponseHandler
    {
        public string GetResponse(string input)
        {
            if (input.Contains("how are you"))
                return "I'm just code, but I'm functioning perfectly! How can I help you with cybersecurity today?";

            if (input.Contains("purpose") || input.Contains("what can you do"))
                return "My purpose is to teach you about online safety: phishing, strong passwords, and safe browsing. Ask me anything!";

            if (input.Contains("what can i ask") || input.Contains("topics"))
                return "You can ask about:\n- Password safety\n- Phishing emails\n- Suspicious links\n- Safe browsing habits";

            if (input.Contains("password"))
                return " Use long, unique passwords for each account. Enable two-factor authentication (2FA) wherever possible. Never share passwords!";

            if (input.Contains("phish"))
                return " Phishing emails try to trick you into clicking bad links. Check the sender's address, hover over links, and don't share personal info.";

            if (input.Contains("link") || input.Contains("url"))
                return " Before clicking a link, hover to see the real URL. Look for 'https' and beware of tiny URLs or misspellings.";

            if (input.Contains("brows") || input.Contains("safe browsing"))
                return " Use HTTPS, avoid public Wi-Fi for sensitive tasks, and keep your browser updated. Consider a trusted ad-blocker.";

            return "I didn't quite understand that. Could you rephrase? Try asking about passwords, phishing, links, or safe browsing.";
        }
    }
}
