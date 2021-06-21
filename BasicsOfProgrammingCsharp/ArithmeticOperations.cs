using System;

namespace BasicsOfProgrammingCsharp
{
    public class ArithmeticOperations
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int SubStract(int a, int b) => a - b;

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Division(int a, int b)
        {
            return a / b; // exact number
        }

        public static double DivisonP(double a, double b)
        {
            var result = a / b;
            return result;
        }
        public double RemainingOfDivision(double a, double b)
        {
            return a / b;
        }

        public static void IncrementOperation()
        {
            //Инкремент бывает префиксным: ++x - сначала значение переменной x увеличивается на 1, а потом ее значение возвращается в качестве результата операции.

            int x1 = 5;
            int z1 = ++x1; // z1=6; x1=6
            Console.WriteLine($"{x1} - {z1}");

            // И также существует постфиксный инкремент: x++ - сначала значение переменной x возвращается в качестве результата операции, а затем к нему прибавляется 1.
            int x2 = 5;
            int z2 = x2++; // z2=5; x2=6
            Console.WriteLine($"{x2} - {z2}");
        }
        public static void DecrementOperation()
        {
            int x1 = 5;
            int z1 = --x1; // z1=4; x1=4
            Console.WriteLine($"{x1} - {z1}");

            int x2 = 5;
            int z2 = x2--; // z2=5; x2=4
            Console.WriteLine($"{x2} - {z2}");
        }

        public static void AssignmentOperations()
        {
            // A+=B  => A = A+B
            int a = 10;
            Console.WriteLine(a += 5);
        }

        //Тип    -> В какие типы безопасно преобразуется
        //byte -> short, ushort, int, uint, long, ulong, float, double, decimal
        //sbyte  -> short, int, long, float, double, decimal
        //short -> int, long, float, double, decimal
        //ushort -> int, uint, long, ulong, float, double, decimal
        //int -> long, float, double, decimal
        //De la mic la mare :) invers nu merge.

        public static void ConditionalExpressions()
        {
            int a = 10;
            int b = 4;
            bool c = a == b; // false

            int aa = 10;
            int bb = 4;
            bool cc = aa != bb;    // true
            bool dd = aa != 10;     // false
            // >, < , >= , <=

            // | , || (or operator) , & ,&& (and operator), ^ , ! 

            // diferenta dintre | si ||.  || -> daca prima conditie ii true pe restu nu le verifica,  | -> chiar daca prima conditie ii true el le verifica pe toate
        }
    }
}
