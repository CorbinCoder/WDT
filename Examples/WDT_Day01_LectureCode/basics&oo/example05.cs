using System;

namespace WDT_05
{
    class Request
    {
        // convention (camel case)
        private string ip;
        private int netmask;

        // constructor(s)
        public Request() { }

        public Request(string ip, int netmask)
        {
            this.ip = ip;
            this.netmask = netmask;
        }

        // properties (essentially a get and set in one block)
        // convention here is begin with a capital letter.
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

        public int Netmask
        {
            get
            {
                return netmask;
            }

            set
            {
                // code to check netmask validity
                // note the use of value here it is 
                // a c# keyword and is provided by the system.
                netmask = value;
            }
        }

        // Main method - entry point
        public static void Main()
        {
            Request req = new Request();

            /* Note accessing properties
             * syntax is like accessing an attribute
             * directly.  Also note that the 'get'
             * 'set' is worked out by the syntax.*/
            req.IP = "131.170.24.42";
            req.Netmask = 24;

            Console.WriteLine("The CIDR address of the request is {0}/{1}.",
                              req.IP, req.Netmask);
        }
    }
}
