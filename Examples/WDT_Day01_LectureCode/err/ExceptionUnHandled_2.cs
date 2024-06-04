// Let the C# runtime system handle the error. 
// No try catch
using System;
namespace Exceptions
{
    class Unhandled_2
    {
        public static void Main()
        {
            int[] nums = new int[4];

            Console.WriteLine("Before exception is generated.");

            // Generate an index out-of-bounds exception. 
            for (int i = 0; i < 10; i++)
            {
                nums[i] = i;
                Console.WriteLine("nums[{0}]: {1}", i, nums[i]);
            }

            Console.WriteLine("This line never executes, program has crashed.");

        }
    }
}