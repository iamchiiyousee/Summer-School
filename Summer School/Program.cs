using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summer_School
{
    class Program
    {
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
                
            }

            else
            {
                Console.WriteLine("Please select a valid opton.");
                MainMenu();
            }

 
        }

        static void MainMenu()
        {
            Console.WriteLine("Please type the number of your selection.");
            Console.WriteLine("1: Enroll a student.");
            Console.WriteLine("2: Unenroll a student.");
            Console.WriteLine("3: View list of students.");
            Console.WriteLine("Exit.");
        }

        
    }
}
