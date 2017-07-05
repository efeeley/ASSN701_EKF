using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASSN701_EKF
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            int num;
            string numstring;
            

            //User Input
            Console.WriteLine("Please input the number 1, 2 or 3:");
            numstring = Console.ReadLine();
            num = Convert.ToInt32(numstring);
           
            //If statement        
            if (num == 1)
            {
                Console.WriteLine("Yes");
                Console.ReadLine();
            }
            else if (num == 2)
            {
                Console.WriteLine("No");
                Console.ReadLine();
            }
            else if (num == 3)
            {
                Console.WriteLine("Maybe");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You have not entered a valid number");
                Console.ReadLine();
            }//end if
        
        }//end main
    }//end class
}//end program
