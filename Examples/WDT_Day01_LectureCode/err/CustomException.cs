using System;

namespace TestApp
{
    class CustomException
    {
        static void Main(string[] args)
        {

            string name = null;

            if (string.IsNullOrEmpty(name))
            {
                throw new NameNotFoundException("Name is Empty");
            }
            else
            {
                Console.WriteLine("Name: " + name);
            }

            Console.ReadLine();
        }
    }
    public class NameNotFoundException : Exception
    {

        public NameNotFoundException()
        {

        }
        public NameNotFoundException(string message) : base(message)
        {

        }

        public NameNotFoundException(string message, Exception innerexception) : base(message, innerexception)
        {

        }

    }
}
