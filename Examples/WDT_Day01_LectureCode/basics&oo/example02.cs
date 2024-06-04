namespace TestWithRefP 
{ 
    using System; 

    public class ReferenceTest 
    { 
      
    	public static void RefTest(ref int iVal1 ) 
    	{ 
    		iVal1 += 2; 
    	} 

    	public static void Main() 
    	{
            /* variable need to be initialized
             * this is the safest, because it must
             * be initialised */
    		int i;
            i = 3; 
      
    		RefTest(ref i ); 
    		Console.WriteLine(i); 
    	} 
    } 
} 