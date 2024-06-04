// Demonstrate various format specifiers. 

using System;
namespace Strings
{
    class NumericFormat
    {
        public static void Main()
        {

            // Format specifiers reference
            // https://msdn.microsoft.com/en-us/library/dwhawy9k(v=vs.110).aspx

            double v = 17688.65849;
            double v2 = 0.15;
            int x = 21;

            Console.WriteLine("\nWithout format:" + v);

            // F is for fixed point
            // The number refers to the data or variable (zero indexed)
            Console.WriteLine("\nFormat (2 decimals): {1:F2} {0:F2}", 17.56894, 22.2147512);

            // N is for numeric format and includes , seperator for thousands
            // Must include the ordered placeholder, even if there is only one value.
            Console.WriteLine("\nFormat (numeric) {0:N5}", v);

            // E is for exponential
            Console.WriteLine("\nFormat (exponential) {0:e}", v);

            // P is for percent
            Console.WriteLine("\nFormat (percent) {0:p}", v2);

            // X is for hexedecimal
            Console.WriteLine("\nFormat (hexadecimal) {0:X}", 255);

            // D is for decimal
            Console.WriteLine("\nFormat (decimal) {0:D12}", x);

            // C is for currency
            Console.WriteLine("\nFormat (currency) {0:C}\n", 189.99);
        }
    }
}