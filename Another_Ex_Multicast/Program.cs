using System;
namespace Another_Ex_Multicast
{
    internal class Program
    {
        public delegate void Calc(double width, double height);

        public void GetArea(double width, double height)
        {
            Console.WriteLine(width * height);
        }

        public void GetPerimeter(double width,double height)
        {
            Console.WriteLine($"Perimeter is {2 * (width + height)}");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            //Calc c = new Calc(p.GetArea); ;
            //Calc c1 = new Calc(p.GetPerimeter);
            //Calc c3 = c + c1;
            //c3(5, 7);

            Calc c = new Calc(p.GetArea);
            c += p.GetPerimeter;
            c(5, 7);
            Console.ReadKey();








        }
    }
}
