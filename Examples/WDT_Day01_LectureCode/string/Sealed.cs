using System;

namespace Sealed
{
    // Sealed class
    sealed class Request
    {
        private string ip;

        public Request(string ip)
        {
            this.ip = ip;
        }

        /* Note: Go to definition to see that the 
         * String class is a 'sealed' class.*/
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
            Console.WriteLine("IP address {0}/{1} sent.", IP);
        }
    }

    /* Note: I cannot sub-class the string class because it is 
     * sealed.*/
    //class CustomString : String
    //{

    //}

    //class HTTPRequest : Request
    //{
    //    private int netmask;

    //    public HTTPRequest(string ip)
    //        : base(ip)
    //    {
    //        // netmask based on first byte of IP address
    //        this.netmask = 18;
    //    }

    //    public HTTPRequest(string ip, int netmask)
    //        : this(ip)
    //    {
    //        this.netmask = netmask;
    //    }

    //    // properties
    //    public int Netmask
    //    {
    //        get
    //        {
    //            return netmask;
    //        }

    //        set
    //        {
    //            netmask = value;
    //        }
    //    }

    //    /* The override keyword is used, but virtual is not used in the
    //     * Note this class must implement the abstract method from the base
    //     * class.  If you remove this method you will get a compile error.*/
    //    override public void sendIP()
    //    {
    //        Console.WriteLine("IP address {0}/{1} sent.", base.IP, netmask);
    //    }

    //    // Main method - entry point
    //    public static void Main()
    //    {
    //        /* Note: I cannot instantiate the 'Request' class now because
    //         * it has been made 'abstract'.  Only derived classes can now 
    //         * be instantiated.*/
    //        //Request request = new Request("131.170.24.40");

    //        HTTPRequest httpReq = new HTTPRequest("131.170.24.40", 24);
    //        httpReq.sendIP();
    //    }
    //}
}
