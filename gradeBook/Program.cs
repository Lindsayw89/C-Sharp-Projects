using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradeBook
{
    class Program
    {
        static bool userWantsToEnter = true;
        static void Main(string[] args)
        {


            while(userWantsToEnter) {
                Dictionary<string, string> gradeAverage = new Dictionary<string, string>();

                Console.WriteLine("enter a student name or type quit to quit");
                string studentName = Console.ReadLine();
                Console.WriteLine("enter the student's grades");
                string studentGrade = Console.ReadLine();
                
                


                gradeAverage.Add(studentName, studentGrade);

                foreach (string item in gradeAverage.Keys)
                {
                    Console.WriteLine(item);
                    Console.WriteLine(gradeAverage[item]);

                }
                getAverage(studentGrade);
                getLowestGrade(studentGrade);
                getHighestGrade(studentGrade);

              
                
            } 

            Console.ReadKey();


        }
        public static void getAverage(string studentGrade)
        { 
            string[] studentGradeArray = studentGrade.Split(' ');

            double[] studentGrades = new double[studentGradeArray.Length];
            
            for (int i = 0; i<studentGradeArray.Length; i++)
            {
                // assign each converted of the string array to each integer
                studentGrades[i] = Convert.ToDouble(studentGradeArray[i]);

            }
        
            double averageGrade = studentGrades.Average();
            Console.WriteLine("student average: " + averageGrade);

        }

        public static void quitProgram()
        {
            string quit = Console.ReadLine();
            if(quit=="quit")
            {
                userWantsToEnter = false;

            }
            else
            {
                userWantsToEnter = true;
            }
        }



public static void getLowestGrade(string studentGrade)
        {
            string[] studentGradeArray = studentGrade.Split(' ');

            double[] studentGrades = new double[studentGradeArray.Length];

            for (int i = 0; i < studentGradeArray.Length; i++)
            {
                // assign each converted of the string array to each integer
                studentGrades[i] = Convert.ToDouble(studentGradeArray[i]);

            }

            double lowGrade = studentGrades.Min();
            Console.WriteLine("lowest grade: "+ lowGrade);



        }

        public static void getHighestGrade(string studentGrade)
        {
            string[] studentGradeArray = studentGrade.Split(' ');

            double[] studentGrades = new double[studentGradeArray.Length];

            for (int i = 0; i < studentGradeArray.Length; i++)
            {
                // assign each converted of the string array to each integer
                studentGrades[i] = Convert.ToDouble(studentGradeArray[i]);

            }

            double highGrade = studentGrades.Max();
            Console.WriteLine("highest grade: " + highGrade);




        }

    }
}
