using System;
using System.IO;
using System.Xml.Serialization;
namespace Abstraction_Ex2
{
    interface Bank1
    {
        void Deposit();
        void Withdraw();
    }

    class StateBank: Bank1
    {
        public void Deposit()
        {
            Console.WriteLine("Amount Deposited Successfully");
        }
        public void Withdraw()
        {
            Console.WriteLine("Withdrawn Amount Successfully");
        }
    }

    class Hdfc : Bank1
    {
        public void Deposit()
        {
            Console.WriteLine("Amount Deposited Successfully");
        }
        public void Withdraw()
        {
            Console.WriteLine("Withdrawn Amount Successfully");
        }

    }

    class Display
    {
        static void Main(string[] args)
        {
            Bank1 b1 = new StateBank();
            b1.Deposit();
            b1.Withdraw();

            Bank1 b2 = new Hdfc();
            b2.Deposit();
            b2.Withdraw();

            Console.ReadKey();

        }
    }

}

//Abstract class or Interface
//Inheritance  *
//Method Overiding
//Upcasting -->genera
