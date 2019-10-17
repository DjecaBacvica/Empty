/*
C# Access modifiers or specifiers are the keywords that are used to specify accessibility 
or scope of variables and functions in the C# application.

C# provides five types of access specifiers.

Public
Protected
Internal
Protected internal
Private

We can choose any of these to protect our data. 
Public is not restricted and Private is most restricted. 
The following table describes about the accessibility of each.
*/

using System;  
namespace AccessSpecifiers  
{  
	class InternalTest  
	{  
		internal string name = "Shantosh Kumar";  
		internal void Msg(string msg)  
		{  
			Console.WriteLine("Hello " + msg);  
		}  
	}  
	class Program  
	{  
		static void Main(string[] args)  
		{  
			InternalTest internalTest = new InternalTest();  
			// Accessing internal variable  
			Console.WriteLine("Hello " + internalTest.name);  
			// Accessing internal function  
			internalTest.Msg("Peter Decosta");  
		}  
	}  
}
