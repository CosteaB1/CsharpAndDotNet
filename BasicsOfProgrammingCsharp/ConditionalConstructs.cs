using System;

namespace BasicsOfProgrammingCsharp
{
    public class ConditionalConstructs
    {
        public void IfElseStatement(int firstNumber, int secondNumber)
        {

            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"Число {firstNumber} больше числа {secondNumber}");
            }

        }
        public void switchStatement()
        {
            Console.WriteLine("Нажмите Y или N");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "Y":
                    Console.WriteLine("Вы нажали букву Y");
                    break;
                case "N":
                    Console.WriteLine("Вы нажали букву N");
                    break;
                default:
                    Console.WriteLine("Вы нажали неизвестную букву");
                    break;
            }
        }
        public void TernaryOperation()
        {
            // [первый операнд - условие] ? [второй операнд] : [третий операнд]
            int x = 3;
            int y = 2;
            Console.WriteLine("Нажмите + или -");
            string selection = Console.ReadLine();

            var z = selection == "+" ? (x + y) : (x - y);
            Console.WriteLine(z);
        }
    }
}
