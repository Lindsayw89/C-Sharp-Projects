using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLot
{
    class Truck : Vehicle
    {
        public string BedSize;

        public Truck(string licnumber, string make, string model, double price, string bedsize) : base ( licnumber, make, model, price)
        {
            BedSize = bedsize;
        }
        public override void GiveDescription()
        {
            Console.WriteLine("This is a truck and the  license number is {0}, the make and model is {1} {2}, and the price of this truck is {3}. The bedsize is {4}", LicenseNumber, Make, Model, Price, BedSize);

        }
    }
}
