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
            while (true)
                {
                MainMenu();
                string menuChoice = Console.ReadLine();

                
               // int menuNumber = Convert.ToInt32(menuChoice);

                    if (menuChoice == "1")
                    {

                        EnrollStudent();
                    }

                    else if (menuChoice == "2")
                    {
                        UnenrollStudent();
                    }

                    else if (menuChoice == "3")
                    {
                        PrintMenu();
                    }

                    else if (menuChoice == "4")
                    {
                        Exit();
                        break;
                    }
                

                    else
                    {
                        Console.WriteLine("\n Please select a valid opton.");

                    }


            }
 
        }

        static void MainMenu()
        {
            Console.WriteLine("\nPlease type the number of your selection.");
            Console.WriteLine("1: Enroll a student.");
            Console.WriteLine("2: Unenroll a student.");
            Console.WriteLine("3: View list of students.");
            Console.WriteLine("4: Exit.");
        }

        static void EnrollStudent()
        {
            
            Console.WriteLine("Please enter name of student.");
            string studentName = Console.ReadLine();

           int spot = FindSpot();
            if (spot >= 0)
            {
                Students[spot] = studentName;

                Console.WriteLine("{0} has been added!", studentName);
                Console.WriteLine("Press Enter to continue.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\n No spots available! Please select an option.");
            }

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
            Console.ReadKey();
          
        }

        static int FindSpot()
        {
             for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i] == null)
                {
                    return i;
                }


            }



            return -1;
        }
    }
}
