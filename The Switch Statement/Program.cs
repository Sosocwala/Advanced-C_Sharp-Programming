using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Switch_Statement
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How much do you like .Net");
            short loveIt;
            bool numeric = short.TryParse(Console.ReadLine().ToString(), out loveIt);
            if (numeric && loveIt >= 0 && loveIt <= 10)
            {
                string howMuchYouLoveIt = "";
                switch (loveIt)
                {
                    case 1:
                    case 2:
                    case 3:
                        howMuchYouLoveIt = "im sensing you still a new bee in the language";
                        break;
                    case 4:
                    case 5:
                    case 6:
                        howMuchYouLoveIt = "it seems like the is a relationship burden here";
                        break;
                    case 7:
                    case 8:
                    case 9:
                        howMuchYouLoveIt = "if thats the case put a ring in it";
                        break;
                    case 10:
                        howMuchYouLoveIt = "You going overbord now hey";
                        break;  
                    default:
                        howMuchYouLoveIt = "Lets try again ";
                        break;
                }
                Console.WriteLine(howMuchYouLoveIt);
            }
            else
            {
                Console.WriteLine("Please Try Again and Enter the numbers between 1 - 10 ");
            }

        }
    }
}
