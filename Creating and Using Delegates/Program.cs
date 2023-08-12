using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating_and_Using_Delegates
{
    class Program
    {
        delegate decimal MathDelegate(int first, int second);

        //Creating an instance of the delegate
        private static MathDelegate aMathDelegateInstance = null;

        //Attached Methods to be called
        static void DelegateBasics()
        {
            aMathDelegateInstance += new MathDelegate(AddAndGoForward);
            aMathDelegateInstance += SubtractAndBePositive;


            //Calling the Methods
            int operator1 = 100;
            int operator2 = 200;
            decimal returnValues = aMathDelegateInstance.Invoke(operator1, operator2);
            Console.WriteLine("Invoke with (100, 200) produced scalor results:{0}", returnValues);

            //when the is a retun value call this way
            ResetConsole(string.Format("Now we're talking results for Everyone(First Person {0}, secont param: {1}",
                aMathDelegateInstance.Method.Name, returnValues)));
            foreach (MathDelegate instance in aMathDelegateInstance)
            {
                Console.WriteLine("", returnValues);   
            }

        }
        static void Main(string[] args)
        {
            
        }
    }
            
        
}
