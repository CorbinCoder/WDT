using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Strings
{
    class RegularExpression
    {
        
        // Main method - entry point
        public static void Main()
        {
            HTTPRequest req = new HTTPRequest("131.170.24.40", 24);
            
            // Match an exact number of digits
            Regex pattern = new Regex(@"(?<!\d)\d{2}(?!\d)");

            // Searches for the first occurence of a match
            Match firstFixedLength = pattern.Match(req.IP);

            Console.WriteLine("first byte = {0}", firstFixedLength);

            // Or use the static version
            // Find first 3 digit number
            Match firstByte = Regex.Match (req.IP, "(?<!\\d)\\d{3}(?!\\d)");

            Console.WriteLine("first byte = {0}", firstByte);
            
        }
    }

    abstract class Request
    {
        private string ip;

        public Request(string ip)
        {
            this.ip = ip;
        }

        // properties
        public string IP
        {
            get
            {
                return ip;
            }

            set
            {
                ip = value;
            }
        }

        abstract public void sendIP();
    }

    class HTTPRequest : Request
    {
        private int netmask;

        public HTTPRequest(string ip)
            : base(ip)
        {
            // netmask based on first byte of IP address
            this.netmask = 18;
        }

        public HTTPRequest(string ip, int netmask)
            : this(ip)
        {
            this.netmask = netmask;
        }

        // properties
        public int Netmask
        {
            get
            {
                return netmask;
            }

            set
            {
                netmask = value;
            }
        }

        public override void sendIP()
        {
            Console.WriteLine("IP address {0}/{1} sent.", base.IP, netmask);
        }
    }
}

