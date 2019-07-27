using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLot
{
    class Car : Vehicle 
    {
        public string Type;
        public int NumberOfDoors;

        public Car(string licnumber, string make, string model, double price, string type, int numbofdoors) : base(licnumber, make, model, price)
        {
            Type = type;
            NumberOfDoors = numbofdoors;

        }
        public override void GiveDescription()
        {
            Console.WriteLine("This is a car and the license number is {0}, the make and model is {1} {2}, and the price of this car is {3}. It is a {4} and has {5} doors. ", LicenseNumber, Make, Model, Price, Type, NumberOfDoors);

        }
    }
}
