using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_and_Foreach_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>
            {"Johannesbug", "Cape Town", "Durban",
                "Pumalanga", "Eastern Cape",
                "Port Elizabirth", "East London",
                "Cencurion", "Midrand", "Malvin", "Sandton",
                "Kwazulu Natal", "Emazi", "Filiphy",
                "Emdeni", "Empangeni"};
            int countCities = cities.Count;
              for (int i = 0; i < countCities; i++)
              {
                  if(cities[i] == "Sandton")
                  {
                      cities[i] = "JozVagus";
                  }
                  Console.WriteLine(cities[i]);
              }

            // only allows Read access while enuerating
            foreach (var city in cities) 
             {
                 Console.WriteLine(cities);
             }

            // When staping over we use the continue
            for (int i = 0; i < countCities; i++) 
            {
                if (cities[i].Substring(0,1).ToUpper()== "M")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(cities[i]);
                }
            } 

            //When Seticfied break

            for (int i = 0; i < countCities; i++)
            {
                if (cities[i].Substring(0, 1).ToUpper() == "M")
                {
                    break;
                }
                Console.WriteLine(cities[i]);
            }

        }
    }
}
