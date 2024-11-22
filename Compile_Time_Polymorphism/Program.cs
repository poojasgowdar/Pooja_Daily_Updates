using System;
namespace Compile_Time_Polymorphism
{
    class Myntra
    {
        public void Purchase(int cost)
        {
            Console.WriteLine("The cost of dress is: " + cost);
        }
        public void Purchase(long cost)
        {
            Console.WriteLine("Low Cost dress: " + cost);
        }
        public void Purchase(string paymentName)
        {
            Console.WriteLine("The payment done through " + paymentName);
        }
        public void Purchase(string product, string name)
        {
            Console.WriteLine("Product is: " + product + " Name is:" + name);
        }
        public void Purchase(int cost, string product)
        {
            Console.WriteLine("Cost: " + cost + " Product: " + product);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Myntra m = new Myntra();
            m.Purchase(5000000000);
            m.Purchase(60);
            m.Purchase(71, "MamaEarth");
            m.Purchase("Lipstick", "Dress");
            m.Purchase("GooglePay");
            Console.ReadKey();
        }
        
    }
}
