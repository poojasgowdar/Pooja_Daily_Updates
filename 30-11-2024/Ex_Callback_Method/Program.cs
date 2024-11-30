using System;
using System.Threading;
namespace Ex_Callback_Method
{
    //Creating the callback delegates with the same signature of actual callback method
    public delegate void ResultCallbackDelegate(int Results);

    public class NumberHelper
    { 
       //create two private variables to hold the number and ResultCallback instance
        private int _Number;
        private ResultCallbackDelegate _resultCallbackDelegate;

        //Initializing the private variables through constructor
        //So while creating the instance you need to pass the value for Number and callback delegate
        public NumberHelper(int Number, ResultCallbackDelegate resultCallbackDelegate)
        {
            _Number = Number;
            _resultCallbackDelegate = resultCallbackDelegate;
        }

        public void CalculateSum()
        {
            int Sum = 0;
            for(int i = 0; i <=_Number; i++)
            {
                Sum += i;
            }
            //Before the end of the thread function call the callback method
            if (_resultCallbackDelegate != null)
            {
                _resultCallbackDelegate(Sum);
            }
        }

        public class Program
        {
            static void Main(string[] args)
            {
                ResultCallbackDelegate resultCallbackDelegate = new ResultCallbackDelegate(ResultCallbackDelegate);
                int Number = 10;
                //Creating the instance of NumberHelper class by passing the Number
                //the callback delegate instance
                NumberHelper obj = new NumberHelper(Number, resultCallbackDelegate);
                //Creating the Thread using ThreadStart delegate
                Thread T1 = new Thread(new ThreadStart(obj.CalculateSum));
                T1.Start();
                Console.ReadKey();
               
            }
            public static void ResultCallbackDelegate(int Result)
            {
                Console.WriteLine("The Result is:" + Result);
            }
        }


    }
}
