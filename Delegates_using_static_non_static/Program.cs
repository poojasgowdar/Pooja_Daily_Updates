using System;
namespace Delegates_using_static_non_static
{
    class Calculator
    {
        public delegate void CalculatorDelegate(int a, int b);

        public static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
    }

    class Progarm
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            Calculator.CalculatorDelegate addition = Calculator.Add;  // static method
            Calculator.CalculatorDelegate subtraction = c.Sub; // non-static method

            addition(20, 30);
            subtraction(50, 30);
            Console.ReadKey();

        }
    }
}
