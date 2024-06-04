using System;

namespace WDT_10
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

        /* Here we use the keyword 'virtual' in the parent class.  
         * This allows the method to be overriden. */
        virtual public void sendIP()
        {
            Console.WriteLine("IP address {0} sent.", ip);
        }
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

        // Here we use the keyword override instead of 'new' to achieve what we normally
        // expect from Polymorphism.  This is known as late binding.
        override public void sendIP()
        {
            Console.WriteLine("IP address {0}/{1} sent.", base.IP, netmask);
        }

        // Main method - entry point
        public static void Main()
        {
            Request req = new Request("131.170.24.40");
            HTTPRequest httpReq = new HTTPRequest("131.170.24.40", 24);
            Request reqRef;

            req.sendIP();
            // now the new method is used
            httpReq.sendIP();

            // set the reference to the derived object and call the method
            // calls sendIP of the derived class because the object pointed to is of
            // this class
            reqRef = httpReq;
            reqRef.sendIP();
        }
    }
}
