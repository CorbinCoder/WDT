// Using custom formats. 

using System;
namespace Strings
{
    class FormatCustom
    {
        public static void Main()
        {
            double num = 64354.2345;

            Console.WriteLine("\nDefault format: " + num);

            // Display with 2 decimal places. 
            Console.WriteLine("\nValue with two decimal places: " +
                              "{0:#.##}", num);

            // Display with commas and 2 decimal places. 
            Console.WriteLine("\nAdd commas: {0:#,###.##}", num);

            // Display using scientific notation. 
            Console.WriteLine("\nUse scientific notation: " +
                              "{0:#.###e+00}", num);

            // Scale the value by 1000. 
            Console.WriteLine("\nValue in 1,000s: " +
                              "{0:#0,}", num);

            /* Display positive, negative, and zero 
               values differently. */
            Console.WriteLine("\nDisplay positive, negative, " +
                              "and zero values differently.");
            Console.WriteLine("\n{0:#.#;(#.##);0.00}", num);
            num = -num;
            Console.WriteLine("\n{0:#.##;(#.##);0.00}", num);
            num = 0.0;
            Console.WriteLine("\n{0:#.##;(#.##);0.00}", num);

            // Display a percentage. 
            num = 0.17;
            Console.WriteLine("\nDisplay a pecentage: {0:#%}\n", num);
        }
    }
}