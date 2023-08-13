using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static void LambdaLambda()
        {
            //Clearing out the Invocation list
            ClearInvocationList();

            //Lambda Expresion 101
            myMathDelegate += ((param1In, param2In) => { return param1In * param2In});

            int x = 55;
            int y = 77;
            Console.WriteLine("With params {0} - {1} the results of {2} is {3}", x, y,
                myMathDelegate.Method.Name,
                myMathDelegate.Invoke(x, y)); 
        }
    }
}
     