// Demonstrate exception handling. 

using System;
namespace Exceptions
{
    class Unhandled_1
    {
        public static void Main()
        {
            int[] nums = new int[4];

            try
            {
                Console.WriteLine("Before exception is generated.");

                // Generate an index out-of-bounds exception. 
                for (int i = 0; i < 10; i++)
                {
                    nums[i] = i;
                    Console.WriteLine("nums[{0}]: {1}", i, nums[i]);
                }

                Console.WriteLine("this won't be displayed");
            }
            catch (IndexOutOfRangeException)
            {
                // catch the exception 
                Console.WriteLine("Index out-of-bounds!");
            }
            Console.WriteLine("After catch statement.");
        }
    }
}