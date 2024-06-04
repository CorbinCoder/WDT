using System;

namespace WDT_03
{
    /* Note this has the same class name
     * as the previous example this is only 
     * possible because they are in different 
     * namespaces */
    class Request
    {
        // private scope on attributes
        private string ip;
        private int netmask;

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
        /* Can you think why it is better to
         * use a setter like this rather than 
         * a public instance variable? */
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
            Request req = new Request();

            req.setIP("131.170.27.121");
            req.setNetmask(24);
            Console.WriteLine("The CIDR address of the requeset is {0}/{1}.",
                              req.getIP(), req.getNetmask());

        }
    }
}
