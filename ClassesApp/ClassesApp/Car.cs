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
        //private bool _isLuxury = false;

        //Properties
        public string Model { get; set; }
        public string Brand
        {
            get {
                if (IsLuxury)
                {
                    return _brand + " - Luxury Edition";
                }
                else
                {
                    return _brand;
                }
            }
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

        //public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }
        public bool IsLuxury { get; set; }

        //Constructor
        public Car(string model, string brand, bool isLuxury)
        {
            Model = model;
            Brand = brand;
            IsLuxury = isLuxury;
            Console.WriteLine($"A {Brand} {Model} has been created.");
            
        }

        public string AboutCar()
        {
            return $"Your Car is now a {Brand} {Model}";
        }
    }
}
