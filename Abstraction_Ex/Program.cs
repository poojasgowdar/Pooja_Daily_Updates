using System;
namespace Abstraction_Ex
{
    interface Bank
    {
        void Deposit();
        void Withdraw();
    }

    class Hdfc : Bank
    {
        public void Deposit()
        {
            Console.WriteLine("Amount Deposited");
        }

        public void Withdraw()
        {
            Console.WriteLine("Withdraw Successfully");
        }
    }

    class Canara : Bank
    {
        public void Deposit()
        {
            Console.WriteLine("Amount Deposited");
        }

        public void Withdraw()
        {
            Console.WriteLine("Withdraw Successfully");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bank b = new Hdfc();
            b.Withdraw();
            b.Deposit();

            Bank b1 = new Canara();
            b1.Withdraw();
            b1.Deposit();

            Console.ReadKey();



        }
    }


}
