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
            CarLot LotA = new CarLot();
            CarLot LotB = new CarLot();
            Vehicle car1 = new Car("GHY546","Honda", "Civic", 24000.50, "hatchback", 4);
            Vehicle car2 = new Car("KHV848", "kia", "Civic", 19000.80, "coupe", 4);
            Vehicle truck1 = new Truck("ghys564", "ford", "f150", 40000.5, "short");
            Vehicle truck2 = new Truck("ghys564", "GMC", "Canyon", 50000.5, "Standard");
            //car1.GiveDescription();

            LotA.AddVehicle(car1);
            LotA.AddVehicle(car2);
            LotA.AddVehicle(truck1);
            LotA.AddVehicle(truck2);


            //truck1.GiveDescription();

            LotA.PrintInventory();
            
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
        public void PrintInventory()
        {
            foreach (Vehicle v in ListOfVehicles)
                //Console.WriteLine(v.GiveDescription());
                v.GiveDescription();
                
                       
            
           // for( i=0; i<3; i++)
           // {
          //      Console.WriteLine(i.GiveDescription());
          //  }
        }
    }
}
