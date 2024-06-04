// Trimming and padding. 

using System;
namespace Strings
{
    class TrimPad
    {
        public static void Main()
        {
            string str = "test";

            Console.WriteLine("Original string: " + str);

            // Pad on left with spaces. 
            str = str.PadLeft(10);
            Console.WriteLine("\nPadded (left) string: |" + str + "|");

            // Pad on right with spaces. 
            str = str.PadRight(20);
            Console.WriteLine("\nPadded (right) string: |" + str + "|");

            // Trim leading and trailing spaces. 
            str = str.Trim();
            Console.WriteLine("\nTrimmed |" + str + "|");

            // Pad on left with #. 
            str = str.PadLeft(10, '#');
            Console.WriteLine("\nPadded(left with #) |" + str + "|");

            // Pad on right with #s. 
            str = str.PadRight(20, '#');
            Console.WriteLine("\nPadded(right with #) |" + str + "|");

            // Trim #s. 
            str = str.Trim('#');
            Console.WriteLine("\nTrim leading and trailing characters |" + str + "|\n");
        }
    }
}