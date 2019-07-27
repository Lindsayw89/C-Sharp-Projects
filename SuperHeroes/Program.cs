using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person human1 = new Person("William", "Bobby");
            Person human2 = new Person("Elizabeth", "Liz");

            Superhero hero1 = new Superhero("super person", " ", "Tony", "flying");
            Superhero hero2 = new Superhero("awesome person", " ", "Jessica", "Invisibility");

            Villian evil1 = new Villian("Doctor Evil", " ", "Austin Powers");
            Villian evil2 = new Villian("Joker", " ", "Batman");

            List<Person> HumanList = new List<Person>();
            HumanList.Add(human1);
            HumanList.Add(human2);
            HumanList.Add(hero1);
            HumanList.Add(hero2);
            HumanList.Add(evil1);
            HumanList.Add(evil2);
   

            foreach (Person i in HumanList)
                i.PrintGreeting();

                Console.ReadKey();
        }
    }
    public class Person
    {
        public string Name {get; set;}
        public string Nickname { get; set; }

        public Person(string name, string nname )
        {
            Name = name;
            Nickname = nname;
        }
      
        public virtual void PrintGreeting()
        {
            Console.WriteLine("hi my name is {0}, but you can call me {1}", Name, Nickname);
        }
    }

    public class Superhero : Person
    {
        public string RealName { get; set; }
        public string SuperPower { get; set; }

        public Superhero(string name, string nname, string rname, string sPower) : base( name, null)
     {
            RealName = rname;
            SuperPower = sPower;
     }


        public override void PrintGreeting()
        {
            Console.WriteLine("I am {0}. When I am {1}, my super power is {2}", RealName, Name, SuperPower );
        }

    }
    public class Villian :  Person
    {
        public string Nemesis;

    public Villian(string name, string nname, string enemy) : base (name, null)
        {
            Nemesis = enemy;
        }
        public override void PrintGreeting()
        {
            Console.WriteLine("I am the {0}! Have you seen {1}?", Name, Nemesis);
        }
           

    }


}
