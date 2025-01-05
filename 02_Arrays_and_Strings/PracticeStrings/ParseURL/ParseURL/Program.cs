using System;

namespace ParseURL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a URL to parse:");
            string url = Console.ReadLine();

            ParseAndDisplayURL(url);
        }

        static void ParseAndDisplayURL(string url)
        {
            string protocol = "";
            string server = "";
            string resource = "";

            // Check if protocol is present
            int protocolEnd = url.IndexOf("://");
            if(protocolEnd != -1)
            {
                protocol = url.Substring(0, protocolEnd);
                url = url.Substring(protocolEnd + 3); // Remove protocol from URL
            }

            // Split the remaining URL into server and resource
            int resourceStart = url.IndexOf('/');
            if(resourceStart != -1)
            {
                server = url.Substring(0, resourceStart);
                resource = url.Substring(resourceStart + 1);
            }
            else
            {
                server = url;
                resource = "";
            }

            // Display the parsed components
            Console.WriteLine($"[protocol] = \"{protocol}\"");
            Console.WriteLine($"[server] = \"{server}\"");
            Console.WriteLine($"[resource] = \"{resource}\"");
        }
    }
}