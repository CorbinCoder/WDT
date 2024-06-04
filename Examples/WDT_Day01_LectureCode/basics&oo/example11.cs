using System;

namespace WDT_11
{
    // Abstract class
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

        // Abstract method provides no implementation
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

        // The override keyword is used, but virtual is not used in the
        // parent class.
        override public void sendIP()
        {
            Console.WriteLine("IP address {0}/{1} sent.", base.IP, netmask);
        }

        // Main method - entry point
        public static void Main()
        {
            HTTPRequest httpReq = new HTTPRequest("131.170.24.40", 24);
            httpReq.sendIP();
        }
    }
}
