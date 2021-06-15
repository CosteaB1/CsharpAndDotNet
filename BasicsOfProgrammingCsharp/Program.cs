//using directive that references the System namespace. Namespaces provide a hierarchical means of organizing C# programs and libraries
// Namespaces contain types and other namespaces—for example, the System namespace contains a number of types, such as the Console 
//class referenced in the program, and a number of other namespaces, such as IO and Collections.
using System;

namespace BasicsOfProgrammingCsharp
{
    // Documentation:  https://docs.microsoft.com/en-us/dotnet/csharp/   and https://metanit.com/sharp/tutorial/
    //C# is a modern, object-oriented, and type-safe programming language. C# enables developers to
    //build many types of secure and robust applications that run in the .NET ecosystem. C# has its roots in the C family of 
    //languages and will be immediately familiar to C, C++, Java, and JavaScript programmers.

    //class
    class Program
    {
        //method with static modifier
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        // {} -> this is block of code
    }
}
