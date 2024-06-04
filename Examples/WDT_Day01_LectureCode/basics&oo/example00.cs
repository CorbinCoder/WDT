// C# Program to demonstrate 
// the Object class 
using System; 
using System.Text; 

class Geeks { 

	// Main Method 
	static void Main(string[] args) 
	{ 

		// taking object type 
		Object obj1 = new Object(); 

		// taking integer 
		int i = 10; 

		// taking Type type and assigning 
		// the value as type of above 
		// defined types using GetType 
		// method 
		Type t1 = obj1.GetType(); 
		Type t2 = i.GetType(); 

		// Displaying result 

		Console.WriteLine("For Object obj1 = new Object();"); 

		// BaseType is used to display 
		// the base class of current type 
		// it will return nothing as Object 
		// class is on top of hierarchy 
		Console.WriteLine(t1.BaseType); 

		// It will return the name class 
		Console.WriteLine(t1.Name); 

		// It will return the 
		// fully qualified name 
		Console.WriteLine(t1.FullName); 

		// It will return the Namespace 
		// By default Namespace is System 
		Console.WriteLine(t1.Namespace); 

		Console.WriteLine(); 

		Console.WriteLine("For String str"); 

		// BaseType is used to display 
		// the base class of current type 
		// it will return System.Object 
		// as Object class is on top 
		// of hierarchy 
		Console.WriteLine(t2.BaseType); 

		// It will return the name class 
		Console.WriteLine(t2.Name); 

		// It will return the 
		// fully qualified name 
		Console.WriteLine(t2.FullName); 

		// It will return the Namespace 
		// By default Namespace is System 
		Console.WriteLine(t2.Namespace); 
	} 
} 
