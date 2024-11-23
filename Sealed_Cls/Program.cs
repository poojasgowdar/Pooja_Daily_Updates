using System;
namespace Sealed_Cls
{
    class University
    {
        public void Exams()
        {
            Console.WriteLine("Exams conducted");
        }
    }
    class sealed class College : University
    {
        public void Internals()
    {
        Console.WriteLine("Internals");
    }
    static void Main(string[] args)
    {

    }
}

       

}
