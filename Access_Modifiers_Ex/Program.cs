using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers_Ex
{
    public class Car
    {
        // Public field - can be accessed from anywhere
        public string Make;
        // Private field - only accessible within the Car class
        private string Mode;
        // Protected field - accessible in the Car class and derived classes
        protected int Year;
        // Internal field - can only be accessed within the same assembly
        internal string Color;
        // Private protected field - accessible within the Car class and derived classes in the same assembly
        private protected double Price;

        public Car(string make, string mode, int year, string color, double price)
        {
            Make = make;
            Mode = mode;
            Year = year;
            Color = color;
            Price = price;
        }
        // Public method - can be accessed from anywhere
        public void DisplayCarInfo()
        {
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Mode: {Mode}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Price: {Price}");
        }
        // Private method - can only be accessed within the Car class
        private void SetDiscount()
        {
            Console.WriteLine("Setting a discount for the car.");
        }
        // Protected method - accessible in the Car class and derived classes
        protected void ApplyWarranty()
        {
            Console.WriteLine("Warranty applied to the car.");
        }
        // Internal method - can only be accessed within the same assembly
        internal void PaintCar()
        {
            Console.WriteLine("The car is being painted.");
        }
    }

        public class ElectricCar : Car
        {
            public string BatteryType;
            // Constructor for ElectricCar

        public ElectricCar(string make, string mode, int year, string color, double price,string batterytype) :  
                          base(make, mode, year, color, price)
        {
            BatteryType = batterytype;
        }
        public void ShowElectricCarInfo()
        {
            // Access public field from base class
            Console.WriteLine($"Electric Car Make: {Make}");

            // Access protected field from base class
            Console.WriteLine($"Year of Manufacture: {Year}");

            // Access protected method from base class
            ApplyWarranty();
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Toyota", "Corolla", 2020, "Blue", 20000);

            // Access public field
            Console.WriteLine($"Car Make: {car.Make}");

            // Access public method
            car.DisplayCarInfo();
            //Console.WriteLine(car.year);
            //Console.WriteLine(car.color);
            ElectricCar electricCar = new ElectricCar("Tesla", "Model 3", 2023, "Red", 40000, "Lithium-ion");

            // Access public field from the base class
            Console.WriteLine($"Electric Car Make: {electricCar.Make}");

            // Access protected field and method from the base class
            electricCar.ShowElectricCarInfo();

            // Access internal method (this works because ElectricCar and Car are in the same assembly)
            electricCar.PaintCar();

            Console.ReadKey();
        }
    }


    
}
