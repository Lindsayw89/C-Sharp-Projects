using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint2_ToDo
{
    class ConsoleUtils
    {
        //global app vairable
        App CallApp = new App();

        public static string AskForToDo()
        {
           

            Console.WriteLine("what do you want to do");
            Console.WriteLine("type 'delete' to delete an item, 'add' to add an item");
            Console.WriteLine("type 'done list', to list all completed items, 'pending list' to list all pending items','all' to list all");
            string Task = Console.ReadLine();

            return Task;

           
        }
        public static string[] MethodAdding()
        {
            string[] newList = new string[2];

            Console.WriteLine("Describe your task");
            newList[0]  = Console.ReadLine();
            Console.WriteLine("is this task done? write 'done' for done, and 'pending' if not");
            newList [1] = Console.ReadLine().ToLower();

            return newList;

           
        }
        public static int MethodDeleting()
        {

            Console.WriteLine(  "what Id do you want to delete?");
            int ID = Convert.ToInt32(Console.ReadLine());

            return ID;

        }


        public static void PrintList(List<ToDoItem> ListItems) // took out string task argument  string Description, List<ToDoItem> ListItems, ItemContext context, string done
        {

            foreach (ToDoItem T in ListItems)
            {
                Console.WriteLine("{0} {1} {2} ", T.Id, T.Description, T.Done);
            }
        }
        
        


        // handle printing to console and reading from console ( could be done in app class, but no)

    }
}
