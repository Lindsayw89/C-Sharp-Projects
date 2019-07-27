using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLot
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot Lot1 = new CarLot();
            CarLot Lot2 = new CarLot();
            Vehicle car1 = new Car("GHY548","Honda", "Civic", 24000.50, "hatchback", 4);
            Vehicle car2 = new Car("GHY548", "kia", "Civic", 19000.80, "coupe", 4);

            car1.GiveDescription();

            Lot1.AddVehicle(car1);

            Vehicle truck1 = new Truck("ghys564", "ford", "f150", 40000.5, "8 feet");
            truck1.GiveDescription();
            Console.ReadKey();
        }
    }
    public class CarLot
    {
        string Name;
        static List<Vehicle> ListOfVehicles =new List<Vehicle>();

        public  void AddVehicle(Vehicle automobile)
        {

            ListOfVehicles.Add(automobile);
        }
        public  void PrintInventory()
        {
            //foreach (Vehicle v in ListOfVehicles)
               //Console.WriteLine(v.GiveDescription());
        }
    }
}
