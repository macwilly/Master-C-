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
        private string _brand;
        //Constructor
        public Car(String model, string brand)
        {
            _model = model;
            _brand = brand;
            Console.WriteLine($"A {_brand} {_model} has been created.");
            _brand = brand;
        }
    }
}
