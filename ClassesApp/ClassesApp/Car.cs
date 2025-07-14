using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    internal class Car
    {
        // member variable
        private string _model = "";
        private string _brand = "";

        //Properties
        public string Model { get; set; }
        public string Brand
        {
            get => _brand;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You entered nothing!");
                    _brand = "DEFAULT";
                }
                else
                {
                    _brand = value;
                }
            }
        }

        //Constructor
        public Car(string model, string brand)
        {
            Model = model;
            Brand = brand;
            Console.WriteLine($"A {Brand} {Model} has been created.");
            Brand = brand;
        }

        public string AboutCar()
        {
            return $"Your Car is now a {Brand} {Model}";
        }
    }
}
