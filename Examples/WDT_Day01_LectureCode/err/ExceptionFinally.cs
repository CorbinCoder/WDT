// Use finally. 

using System;
namespace Exceptions
{
    class GeneralException
    {
        public static void genException(int what)
        {
            int t;
            int[] nums = new int[2];

            Console.WriteLine("Receiving " + what);
            try
            {
                switch (what)
                {
                    case 0:
                        t = 10 / what; // generate div-by-zero error 
                        break;
                    case 1:
                        nums[4] = 4; // generate array index error. 
                        break;
                    case 2:
                        return; // return from try block 
                }
            }
            catch (DivideByZeroException)
            {
                // catch the exception 
                Console.WriteLine("Can't divide by Zero!");
                return; // return from catch, the finally statement will still run
            }
            catch (IndexOutOfRangeException)
            {
                // catch the exception 
                Console.WriteLine("No matching element found.");
            }
            finally
            {
                Console.WriteLine("Leaving try.");
            }
        }
    }

    class Finally
    {
        public static void Main()
        {

            for (int i = 0; i < 3; i++)
            {
                // Calling a static method 3 times on the UseFinally class
                GeneralException.genException(i);
                Console.WriteLine();
            }
        }
    }
}