using System;

namespace WDT_09
{
    class Request
    {
        /* changed to protected to allow the 
         * derived class access, different to Java
         * which also includes all classes in the
         * same package */
        protected string ip;

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

        // Note: this method prints only one variable
        public void sendIP()
        {
            Console.WriteLine("IP address {0} sent.", ip);
        }
    }

    class HTTPRequest : Request
    {
        // changed to protected to allow the derived class access
        protected int netmask;

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

        /* Allows child class to call
         * the parent classes method
         * see example below.
         * 
         * Note: this method prints two variables.*/
        new public void sendIP()
        {
            Console.WriteLine("IP address {0}/{1} sent.", ip, netmask);
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

            /* set the reference to the derived object and call the method
             * calls sendIP of the base class because that is the type of the
             * reference, compare with the next example.
             * This is known as early binding and is different from what you
             * expect in Java.  The parent method will be called despite the 
             * runtime type being the child class.*/
            reqRef = httpReq;
            reqRef.sendIP();
        }
    }
}
