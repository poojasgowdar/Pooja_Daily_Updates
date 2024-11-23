using System;
namespace Copy_Construtor
{
    internal class Program
    {
        string Title;
        string Author;

        public Program(string title,string author)
        {
            Title = title;
            Author = author;
        }
        public Program(Program obj)
        {
            Title = obj.Title;
            Author = obj.Author;
        }

        void Display()
        {
            Console.WriteLine("The Title is:" + Title);
            Console.WriteLine("The Author is:" + Author);
        }
        static void Main(string[] args)
        {
            Program p = new Program("Shakespear","Flower");
            Program p1 = new Program(p);
            p.Display();
            p1.Display();

            Console.ReadKey();
        }
    }
}
