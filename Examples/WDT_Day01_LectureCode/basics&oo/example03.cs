using System;

public class OutTest
{
    public static int TestOut(out int iVal1, out int iVal2)
    {
        iVal1 = 10;
        iVal2 = 20;
        return 0;
    }

    public static void Main()
    {
        /* variable need not be initialized
         * when using out, other than that
         * they are the same */
        int i, j;

        Console.WriteLine(TestOut(out i, out j));
        Console.WriteLine(i);
        Console.WriteLine(j);
        Console.ReadLine();
    }
}