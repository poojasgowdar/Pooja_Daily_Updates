using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Encapsulation
{
    internal class Program
    {
        private double balance;
        public double GetBalance()
        {
            return balance;
        }
        public void SetBalance(double balance)
        {
            this.balance = balance;
        }
        

        static void Main(string[] args)
        {
            Program p = new Program();
            p.SetBalance(100.0);
            double bal=p.GetBalance();
            Console.WriteLine(bal);
            Console.ReadKey();
            

        }
    }
}
