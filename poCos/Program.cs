using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poCos
{
    class Program
    {
        static void Main(string[] args)
        {
            
                DriverLicense firstLicense = new DriverLicense("Sam", "Smith", "Male", 56483564);
            Console.WriteLine("my name is {0} {1}, and I am {2}. My driver's license number is{3}", firstLicense.firstName,firstLicense.lastName, firstLicense.gender, firstLicense.licenseNumber);

            firstLicense.GetFullName();
            Console.ReadKey();
        }
        
    }
    class DriverLicense
    {
        // the names here in fields, are what will be used in the main method
        public String firstName;
        public String lastName;
        public string gender;
        public int licenseNumber;
                                    // the names in the arguments () can be the same as the fields, but will only be used in the 2 spots below
        public DriverLicense(string fName, string lName, string Agender, int lNumber)
        {
            firstName = fName;
            lastName = lName;
            gender = Agender;
            licenseNumber = lNumber;
           
        }

        public DriverLicense(string fName)
        {
            firstName = fName;
        }
        public DriverLicense(string fName, string lName)
        {
            firstName = lName;
        }
                // in argument you dont have to name 'first name or lastname')
        public String GetFullName()
        {
           string FullName = firstName + lastName;
            return FullName;
        }

    }

    class Book
    {
        public string title;
        public string[] authors; //(list)
        public int numberOfPages;
        public int sku;
        public string publisher;
        public double price;

        public Book(string atitle,  string [] aauthors, int anumberOfPages, int asku, string apublisher, double aprice)
        {
            title = atitle;
            authors = aauthors;
            numberOfPages = anumberOfPages;
            sku = asku;
            publisher = apublisher;
            price = aprice;

        }

        public String GetBookPublisher()
        {
            string bookPublisher = 
        }
    }
    class Airplane
    {
        public string manufacturer;
        public string model;
        public string variant;
        public int capacity;
        public int engines;


    }
 }

