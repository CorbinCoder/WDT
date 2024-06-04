// Split and join strings. 
 
using System;
namespace Strings
{
    class SplitAndJoin
    {
        public static void Main()
        {
            string str = "One if by land, two if by sea.";
            Console.WriteLine("Original string: " + str);

            // Split the string into parts based on a set of delimeters
            // supplied in an array.
            char[] seps = { ' ', '.', ',' };
            string[] parts = str.Split(seps);

            Console.WriteLine("Pieces from split: ");
            for (int i = 0; i < parts.Length; i++)
            {
                Console.WriteLine(parts[i]);
            }

            // Now, join the parts using a delimeter 
            string whole = String.Join(" ", parts);
            Console.WriteLine("Result of join: ");
            Console.WriteLine(whole);
        }
    }
}