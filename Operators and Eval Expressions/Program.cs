using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_and_Eval_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            int evalNum = 6;
            string grades = (evalNum >= 7) ? "Satisfactory" : "Not Satisfactory";
            Console.WriteLine(grades);

            //Avoding using this long code
            /*  string grade = null;
              if (evalNum >= 7)
              {
                  grade = "Satisfactory";
              }
              else
              {
                  grade = "not Satisfactory";
              }
              Console.WriteLine(grade);
            */

            int a = 10;
            int b = 15;
            if (LessTHanZero(a) && LessThanZero(b))
            {
                Console.WriteLine("Both Numbers are less than Zero");
            }
            {
                Console.WriteLine("Someone here is positive, numerically speaking");
            }


            int x = 20;
            int y = ++x;
            Console.WriteLine("POSTFIX: A:{0} B:{1}", x, y);

            int m = 10;
            int n = m++;
            Console.WriteLine("POSTFIX: A:{0} B:{1}", m, n);


            int z = 100;
            z += 10;
            z -= 20;
            z *= 5;
            Console.WriteLine(z);

        }
    }
}
