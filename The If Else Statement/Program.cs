using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_If_Else_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number X");
            int numX = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number Y");
            int numY = int.Parse(Console.ReadLine());
            if (numX == numY)
            {
                Console.WriteLine("X is equal to Y");
                if ((numX % 2)== 0)
                {
                    Console.WriteLine("X is an Even number");  
                }
                else { Console.WriteLine("X is an Even number"); }
            }
            else if (numX > numY)
            {
                Console.WriteLine("X is greater than Y"); 
            }
            else
            {
                Console.WriteLine("X is less than Y");
            }
        }
    }
}
