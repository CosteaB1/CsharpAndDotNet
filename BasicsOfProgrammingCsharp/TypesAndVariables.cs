using System;

namespace BasicsOfProgrammingCsharp
{
    public class TypesAndVariables
    {
        //There are two kinds of types in C#: value types and reference types. Variables of value types directly contain their data.
        //Variables of reference types store references to their data, the latter being known as objects. With reference types, it's 
        //possible for two variables to reference the same object and possible for operations on one variable to affect the object 
        //referenced by the other variable. With value types, the variables each have their own copy of the data, and it isn't possible 
        //for operations on one to affect the other (except for ref and out parameter variables).

        //C#'s value types are further divided into simple types, enum types, struct types, nullable value types, and tuple value types.
        //C#'s reference types are further divided into class types, interface types, array types, and delegate types.


        //Value Type 
        public static void ValueTypes() //or Primitive types
        {
            // bool , byte, char, decimal, double, enum, float, int, long, sbyte, short, struct, uint, ulong, ushort
            int i = 100;
            //When you pass a value-type variable from one method to another, the system creates a separate copy of 
            //a variable in another method. If value got changed in the one method, it wouldn't affect the variable in another method.
            static void ChangeValue(int x)
            {
                x = 200;

                Console.WriteLine(x);
            }
            Console.WriteLine(i);
            ChangeValue(i);
        }
        public static void ReferenceType(string name, Student std1) // or Reference types
        {
            //string, arrays, class, delegate

            //Unlike value types, a reference type doesn't store its value directly. Instead, it stores the address where 
            //the value is being stored. In other words, a reference type contains a pointer to another memory location that holds the data.

            //When you pass a reference type variable from one method to another, it doesn't create a new copy; instead, it passes the variable's address. 
            //So, If we change the value of a variable in a method, it will also be reflected in the calling method.
            Console.WriteLine("Console from method " + name + " " + std1.StudentName);

            std1.StudentName = "Steve";

            //String is a reference type, but it is immutable.It means once we assigned a value, it cannot be changed. 
            //If we change a string value, then the compiler creates a new string object in the memory and point a variable to the new memory location.
            //So, passing a string value to a function will create a new variable in the memory, and any change in the value in the function will not be 
            //reflected in the original value, as shown below.
            name = "Steve";
        }

        public static void NullValue()
        {
            //The default value of a reference type variable is null when they are not initialized.Null means not refering to any object.
            //A value type variable cannot be null because it holds value, not a memory address.C# 2.0 introduced nullable types, using which 
            //you can assign null to a value type variable or declare a value type variable without assigning a value to it.
            Student std2 = new Student(); // default value = null 
            std2.StudentName = null;

            //int a = null; -> incorrect syntax, it is not a non-nullable type
        }
    }
    public class Student
    {
        public string StudentName { get; set; }
    }

}
