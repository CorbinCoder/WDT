using System;

namespace WDT_08
{
    class Request
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

        public void sendIP()
        {
            Console.WriteLine("IP address {0} sent.", ip);
        }
    }

    class HTTPRequest : Request
    {
        private int netmask;

        // Base is similar to the use of 'super' in Java.
        public HTTPRequest(string ip) : base(ip)
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

        // Main method - entry point
        public static void Main()
        {
            Request req = new Request("131.170.24.40");
            HTTPRequest httpReq = new HTTPRequest("131.170.24.40", 24);

            req.sendIP();
            // again the netmask value is not used in this method:
            httpReq.sendIP();
        }
    }
}
