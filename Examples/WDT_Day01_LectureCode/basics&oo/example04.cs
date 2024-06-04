using System;

namespace WDT_04
{
    class Request
    {
        private string ip;
        private int netmask;

        // constructor(s)
        public Request() { }

        public Request(string ip, int netmask)
        {
            this.ip = ip;
            this.netmask = netmask;
        }

        // accessor methods
        public string getIP()
        {
            return ip;
        }

        public int getNetmask()
        {
            return netmask;
        }

        // mutator methods
        public void setIP(string ip)
        {
            this.ip = ip;
        }

        public void setNetmask(int netmask)
        {
            this.netmask = netmask;
        }

        // Main method - entry point
        public static void Main()
        {
            /* Try commenting out the constructors in the Request
             * class and observer the impact.  What does this tell
             * you about default constructors? */
            Request req = new Request();
            Request req2 = new Request("131.170.27.121", 24);

            Console.WriteLine("The CIDR address of the request is {0}/{1}.",
                              req2.getIP(), req2.getNetmask());
        }
    }
}
