using System;
namespace User_Defined_Constructor
{
    internal class Program
    {
        int age;
        string name;
        string gender;

        public Program()
        {
            age = 20;
            name = "pooja";
            gender = "Female";
        }

        void DisplayDetails()
        {
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Gender: " + gender);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.DisplayDetails();
            Console.ReadKey();
        }
    }
}
