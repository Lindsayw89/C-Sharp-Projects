using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLot
{
    public abstract class Vehicle
    {
        public string LicenseNumber;
        public string Make;
        public string Model;
        public double Price;
        public Vehicle(string licnumber, string make, string model, double price)
        {
            LicenseNumber= licnumber;
            Make = make;
            Model = model;
            Price = price;

        }
        public virtual void GiveDescription()
        {
            Console.WriteLine("the license number is {0}, the make and model is {1} {2}, and the price of this car is {3}", LicenseNumber, Make, Model, Price);

        }
       
    }
}
