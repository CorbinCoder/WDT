// Use ToString() to format values. 

using System;
namespace Strings
{
    class ToStringFormat
    {
        public static void Main()
        {
            // Format specifiers reference
            // https://msdn.microsoft.com/en-us/library/dwhawy9k(v=vs.110).aspx

            double v = 17688.65849;
            double v2 = 0.15;
            int x = 21;

            // F is for fixed point
            string str = v.ToString("F2");
            Console.WriteLine("\nFormat (2 decimals): " + str);

            // N is for numeric format and includes , seperator for thousands
            str = v.ToString("N5");
            Console.WriteLine("\nFormat (numeric): " + str);

            // E is for exponential
            str = v.ToString("e");
            Console.WriteLine("\nFormat (exponential): " + str);

            // P is for percent
            str = v2.ToString("p");
            Console.WriteLine("\nFormat (percent): " + str);

            // X is for hexedecimal
            str = x.ToString("X");
            Console.WriteLine("\nFormat (hexadecimal): " + str);

            // D is for decimal
            str = x.ToString("D12");
            Console.WriteLine("\nFormat (decimal): " + str);

            // C is for currency
            str = 189.99.ToString("C");
            Console.WriteLine("\nFormat (currency): " + str + "\n");
        }
    }
}