using System;

namespace MulticastDelegateDemo2
{
    public delegate void SampleDelegate(out int Integer);
    internal class Program
    {
        static void Main(string[] args)
        {
            SampleDelegate del = new SampleDelegate(MethodOne);
            del += MethodTwo;
            // The ValueFromOutPutParameter will be 2, initialized by MethodTwo(),
            // as it is the last method in the invocation list.
            int ValueFromOutPutParameter = -1;
            del(out ValueFromOutPutParameter);
            Console.WriteLine($"Returned Value = {ValueFromOutPutParameter}");
            Console.ReadKey();
        }
        // This method sets ouput parameter Number to 1
        public static void MethodOne(out int Number)
        {
            Console.WriteLine("MethodOne is Executed");
            Number = 1;
        }
        // This method sets ouput parameter Number to 2
        public static void MethodTwo(out int Number)
        {
            Console.WriteLine("MethodTwo is Executed");
            Number = 2;
        }
    }
}
