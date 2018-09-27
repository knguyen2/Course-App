/*CourseApp.cs
 * Author: Kim Nguyen, Alexis Richards
 * Assigment 5 and 6
 * This class constructs an object of the Course class
 * This CourseApp is used to tests constructors, properties and method of the class 
 * A static method used in this application is to allow users to input course information
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CourseApp
{
    class CourseApp
    {
        static void Main(string[] args)
        {
          
            int courseID;
            int creditHours;
            string name;
            double courseMax;
            char anotherCourse = 'N';
            DisplayInstructions();

            do
            {

                GetInputValues(out courseID, out creditHours, out name, out courseMax);
                Course object1 = new Course(courseID, name, creditHours, courseMax);
                WriteLine();
                object1.AssgnmtPoints = Points("assignment");
                object1.QuizPoints = Points("quiz");
                object1.ExamPoints = Points("exam");
                object1.ProjectPoints = Points("project");
                Clear();                
                WriteLine();
//                object1.DetermineCourseFinalPoint();
                WriteLine(object1);
                Write("\n Would you like to add another course? (Y or N) ");
                string inValue = ReadLine();
                anotherCourse = Convert.ToChar(inValue);

            }
            while ((anotherCourse == 'Y') || (anotherCourse == 'y'));
           
        }

        // Prompts user for course information
        static void GetInputValues(out int courseID, out int creditHours, out string inValue, out double courseMax)
        {
            Clear();
            courseID = AskForCourseID();
            creditHours = AskForCreditHours();
            inValue = AskForCourseName();
            courseMax = AskForCourseMax();
        }

        public static void DisplayInstructions()
        {
            Console.WriteLine("\n \t \t This application is created for user to store course information. ");
            Console.WriteLine("\n Please follow the instructions below to fill in the following fields. ");
            Console.WriteLine("\n 1. The Course ID");
            Console.WriteLine("\n 2. The Course Name");
            Console.WriteLine("\n 3. Credit Hours" + " the course is worth");
            Console.WriteLine("\n 4. Grade points for each activity, including assigment," + " quiz," + " exam," + " and project");
            Console.WriteLine("\n 5. The number of each activity" + " administered throughout semester");
            Console.ReadLine();
        }

        public static int AskForCourseID()
        {
            string inValue;
            int courseID;
            Console.WriteLine("\n Enter the course ID: ");
            inValue = Console.ReadLine();
            courseID = int.Parse(inValue);
            return courseID;
        }

        public static string AskForCourseName()
        {
            string inValue;
            Console.WriteLine("\n Enter name of the course: ");
            inValue = Console.ReadLine();
            return inValue;
        }        

        public static int AskForCreditHours()
        {
            string inValue;
            int creditHours;
            Console.WriteLine("\n How many creadit hours is this course worth? ");
            inValue = Console.ReadLine();
            creditHours = int.Parse(inValue);
            return creditHours;
            
        }

        public static double AskForCourseMax()
        {
            string inValue;
            double courseMax;
            Console.WriteLine("\n Enter the course maximum grade: ");
            inValue = Console.ReadLine();
            courseMax = double.Parse(inValue);
            return courseMax;
        }

        public static double Points(string activity)
        {
            string inValue;
            int numberOfAssgnmts;
            Console.WriteLine("\n Enter the number of {0} administerred throughout the semester: ", activity);
            inValue = Console.ReadLine();
            numberOfAssgnmts = int.Parse(inValue);

            double sumPoints = 0.0;
            string inValue1;
            for (int i = 1; i < numberOfAssgnmts + 1; i++)
            {
                Console.WriteLine("\n Enter the grade for {0} {1}: ", activity, i);
                inValue1 = Console.ReadLine();
                sumPoints = sumPoints + double.Parse(inValue1);
            }
     
            return sumPoints;
        }
    }
}
