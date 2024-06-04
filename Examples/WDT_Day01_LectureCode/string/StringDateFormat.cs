// Format time and date information. 

using System;
namespace Strings
{
    class DateFormats
    {
        public static void Main()
        {
            DateTime dt = DateTime.Now;

            Console.WriteLine("\nTime is {0:hh:mm tt}", dt);
            Console.WriteLine("\n24 hour time is {0:hh:mm}", dt);
            Console.WriteLine("\nDate is {0:ddd MMM dd, yyyy}", dt);

            Console.WriteLine("\nEra: {0:gg}", dt);

            Console.WriteLine("\nTime with seconds: " +
                              "{0:HH:mm:ss tt}", dt);

            Console.WriteLine("\nUse m for day of month: {0:m}", dt);
            Console.WriteLine("\nuse m for minutes: {0:%m}\n", dt);
        }
    }
}