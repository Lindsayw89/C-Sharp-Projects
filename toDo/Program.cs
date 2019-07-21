using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toDo
{
    class Program
    {
        static List<ToDoItem> listOfItems = new List<ToDoItem>();
        public static string answer;
        static void Main(string[] args)
        {
           
            ToDoItem firstItem = new ToDoItem("homework", "8-1-19", "high");
            firstItem.DueDate = "8-1";
          

            ToDoItem.AskQuestion(answer, listOfItems);
           ToDoItem.PrintOutList(listOfItems);
            Console.ReadKey();
        }
        

        


    }

    class ToDoItem
    {
        public string Description;
        public string DueDate;
        public String Priority;


        public ToDoItem()
        {

        }

    public ToDoItem( string describe, string date, string importance)
        {
            Description = describe;
            DueDate = date;
            Priority = importance;

        }



        public static void AskQuestion(string answer, List <ToDoItem> listOfItems)
        {
          

            Console.WriteLine("Do you wan to add an item to your to do list? type 'y' for yes and 'n' for no");
             answer = Console.ReadLine();
            while(answer=="y") {
                

                Console.WriteLine("describe your task");
                string describe = Console.ReadLine();

                Console.WriteLine("when is this due?");
                string date = Console.ReadLine();

                Console.WriteLine("is this a high, medium, or low priority?");
                string importance = Console.ReadLine();

                listOfItems.Add(new ToDoItem(describe, date, importance)); //example of instantiatiation 'new'

                Console.WriteLine("Do you wan to add an item to your to do list? type 'y' for yes and 'n' for no");
                answer = Console.ReadLine();
                
            }
    

        }
        public static void PrintOutList(List<ToDoItem> listOfItems)
        {
           
                foreach (ToDoItem item in listOfItems)
                {
                    Console.WriteLine("task: " + item.Description + " Due by: " + item.DueDate + " Priority: " + item.Priority);
                }
            
            

        }




    }



}
