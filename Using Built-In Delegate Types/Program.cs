using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_Built_In_Delegate_Types
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Here is a way of creating a delegate
            delegate decimal someMathThing(int x, int y);

            static void BuiltInDelegates()
            {
                someMathThing myMathThing = AddTwoNumbers;
                Console.WriteLine("Method: {0} Progress: {1}",
                    myMathThing.Method.Name, myMathThing(33333, 22));
            }

            //here is a way to utalize a builtIn delegate
            Func<int, int, decimal> callSimpleMathDelegate = AddTwoNumbers;
            decimal results = callSimpleMathDelegate(33333, 22);
            Console.WriteLine("Method: {0} Progress: {1}",
                callSimpleMathDelegate.Method.Name, results);

            //THen Calling a method thad doesnt require a return by using the Action
            Action<int> OneParamMethodCall = voidMethodOneParam;
            Action<int, int> TwoParamMethodCall = voidMethodTwoParam;

            //invoking as normarl
            ResetConsole("Using the Action <int>delegates incation:");
            OneParamMethodCall(4);  
            resetConsole("Using the Action <int, string> delegate inovation:");
            TwoParamMethodCall(5, Loopy); 



        }
    }
}
