using System;

namespace WDT_07
{
    // See sub-class below
    class Request
    {
        private string ip;

        // only the default constructor

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

    /* The colon is used like 'extends' in Java */
    class HTTPRequest : Request
    {
        private int netmask;

        // only the default constructor

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
            Request req = new Request();
            HTTPRequest httpReq = new HTTPRequest();

            req.IP = "131.170.24.40";
            httpReq.IP = "131.170.27.121";
            httpReq.netmask = 18;

            req.sendIP();
            /* Note this method does not exist in the 
             * HTTPRequest class, but is inherited from
             * the Request class */
            httpReq.sendIP();
        }
    }
}
