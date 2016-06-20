using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summer_School
{
    class Program
    {
        static string[] Students = new string[15];

        static void Main(string[] args)
        {
            MainMenu();
            string menuChoice = Console.ReadLine();
            int menuNumber = Convert.ToInt32(menuChoice);

            if (menuNumber == 1)
            {
                EnrollStudent();
            }

            else if (menuNumber == 2)
            {
                UnenrollStudent();
            }

            else if (menuNumber == 3)
            {
                PrintMenu();
            }

            else if (menuNumber == 4)
            {
                Exit();
            }

            else
            {
                Console.WriteLine("Please select a valid opton.");
                MainMenu();
            }

            Console.ReadKey();

 
        }

        static void MainMenu()
        {
            Console.WriteLine("Please type the number of your selection.");
            Console.WriteLine("1: Enroll a student.");
            Console.WriteLine("2: Unenroll a student.");
            Console.WriteLine("3: View list of students.");
            Console.WriteLine("4: Exit.");
        }

        static void EnrollStudent()
        {

        }

        static void UnenrollStudent()
        {

        }

        static void PrintMenu()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine(Students);
            }
        }

        static void Exit()
        {
            Console.WriteLine("Goodbye! Press Enter to exit.");
        }
    }
}
