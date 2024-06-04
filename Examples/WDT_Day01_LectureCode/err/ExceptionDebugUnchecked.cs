// Using checked and unchecked. 

using System;
namespace Exceptions
{
    class DebugUnChecked
    {
        public static void Main()
        {
            byte a, b;
            byte result;

            a = 127;
            b = 127;

            try
            {
                // This will supress the exception and store what it can
                // An overflow is by default unchecked, so unchecked 
                // keyword is not required.
                result = unchecked((byte)(a * b));
                Console.WriteLine("\nUnchecked result: " + result);

                result = checked((byte)(a * b)); // this causes exception 
                Console.WriteLine("\nChecked result: " + result + "\n"); // won't execute 
            }
            catch (OverflowException exc)
            {
                // catch the exception  
                Console.WriteLine(exc);
            }
        }
    }
}