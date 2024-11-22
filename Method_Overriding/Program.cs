using System;
namespace Method_Overriding
{
    class WhatsApp
    {
        //Overridable Method
        public virtual void SingleTick()
        {
            Console.WriteLine("Single Tick Supported");
        }
    }

    class WhatsApp2: WhatsApp
    {
        //Overriding method
        public override void SingleTick()
        {
            Console.WriteLine("Double Tick Supported");
        }

        public void Show()
        {
            Console.WriteLine("Display Message");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Upcasting
            WhatsApp w1 = new WhatsApp2();
            w1.SingleTick();
            Console.ReadKey();
        }
    }


}

