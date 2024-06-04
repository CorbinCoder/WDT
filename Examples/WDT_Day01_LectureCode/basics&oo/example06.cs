using System;

namespace WDT_06
{
    class Request
    {
        private string ip;
        private int netmask;

        /* Note this belongs to all objects
         * it is no longer an instance variable */
        private static int totalReqs = 0;
        private static int totalInstantiations = 0;

        // constructor(s)
        public Request() { totalInstantiations++; }

        public Request(string ip, int netmask)
            : this()
        {
            this.ip = ip;
            this.netmask = netmask;
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

        public int Netmask
        {
            get
            {
                return netmask;
            }

            set
            {
                // code to check netmask validity
                netmask = value;
            }
        }


        // A static property that will be shared
        // across all instances.
        public static int TotalReqs
        {
            get
            {
                return totalReqs;
            }

            set
            {
                totalReqs = value;
            }

        }

        // A static property that will be shared
        // across all instances.
        public static int TotalInstantiations
        {
            get
            {
                return totalInstantiations;
            }

            set
            {
                totalInstantiations = value;
            }

        }

        // Main method - entry point
        public static void Main()
        {
            Request req = new Request();
            Request anotherReq = new Request();

            req.IP = "131.170.24.42";
            req.Netmask = 24;

            Console.WriteLine("The CIDR address of the request is {0}/{1}.",
                              req.IP, req.Netmask);

            Request.TotalReqs++;

            Console.WriteLine("There have been {0} requests.", Request.TotalReqs);

            Console.WriteLine("There have been {0} instantiations.", Request.totalInstantiations);
        }
    }
}
