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
            string[]Students = [15];
         
                Console.WriteLine("Please type the number of your selection:");
                Console.WriteLine("1: Enroll a student");
                Console.WriteLine("2: Unenroll a student");
                Console.WriteLine("3: Print out the list of enrolled students");

            double MainMenuSelection = Convert.ToInt32 (Console.ReadKey());
            if (MainMenuSelection == 1)
            {

                Console.WriteLine("Please type the name of the student you wish to enroll.");
            }

            
            else if (MainMenuSelection == 2)
            {

            
            }
                
            
        }
    }
}
