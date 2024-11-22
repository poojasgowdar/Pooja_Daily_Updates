using System;
namespace Enacapsulation_Ex
{
    class Student
    {
        private int age;
        private string name;

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }
        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        static void Main(String[] args)
        {
            Student s = new Student();
            s.SetAge(30);
            s.SetName("Meena");
            Console.WriteLine(s.GetName());
            Console.WriteLine(s.GetAge());
            Console.ReadKey();
        }
        
    }
}
