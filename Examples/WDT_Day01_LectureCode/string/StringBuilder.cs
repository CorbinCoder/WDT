using System;
using System.Text;
namespace Strings
{
    public sealed class Builder
    {
        static void Main()
        {
            // Create a StringBuilder that expects to hold 50 characters.
            // Initialize the StringBuilder with "ABC".
            StringBuilder sb = new StringBuilder("ABC", 50);

            // Append three characters (D, E, and F) to the end of the StringBuilder.
            sb.Append(new char[] { 'D', 'E', 'F' });

            // Append a string using placeholders.
            sb.AppendFormat("GHI{1}{0}", 'k', 'J');

            // Display the number of characters in the StringBuilder and its string.
            Console.WriteLine("\n{0} chars: {1}", sb.Length, sb.ToString());

            // Insert a string at the beginning of the StringBuilder.
            sb.Insert(0, "Alphabet: ");

            // Replace all lowercase k's with uppercase K's.
            sb.Replace('k', 'K');

            // Display the number of characters in the StringBuilder and its string.
            Console.WriteLine("\n{0} chars: {1}\n", sb.Length, sb.ToString());
        }
    }
}