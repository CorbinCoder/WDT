// Tokenize strings. 

using System;
namespace Strings
{
    class Tokenize
    {
        public static void Main()
        {
            // Declare an array of String values
            string[] input = {"100 + 19",  "100 / 3.3",  "-3 * 9", "100 - 87"};

            // Specify the delimeter
            char[] delimeter = { ' ' };
            
            // Outer loop for accessing each of the four items in the array
            for (int i = 0; i < input.Length; i++)
            {
                // split string into parts 
                string[] parts = input[i].Split(delimeter);
                Console.Write("Command: ");

                // Inner loop to deal with the tokenised string
                for (int j = 0; j < parts.Length; j++)
                {
                    Console.Write(parts[j] + " ");
                }

                Console.Write(", Result: ");

                // Convert the values to numbers
                double firstNumber = Double.Parse(parts[0]);
                double secondNumber = Double.Parse(parts[2]);

                // Determine the operation to be performed
                switch (parts[1])
                {
                    case "+":
                        Console.WriteLine(firstNumber + secondNumber);
                        break;
                    case "-":
                        Console.WriteLine(firstNumber - secondNumber);
                        break;
                    case "*":
                        Console.WriteLine(firstNumber * secondNumber);
                        break;
                    case "/":
                        Console.WriteLine(firstNumber / secondNumber);
                        break;
                }
            }
        }
    }
}