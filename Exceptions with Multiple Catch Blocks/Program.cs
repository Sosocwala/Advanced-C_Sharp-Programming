using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_with_Multiple_Catch_Blocks
{
    class Program
    {
        static void Main(string[] args)
        {  
        }
        static void UsingMultipleCatchBlock()
        {
            Console.Write("Enter a path to a file:");
            string pathName = Console.ReadLine();

            try
            {
                 File.Open(pathName, FileMode.Create);
                Random r = new Random();
                int excToThrow = r.Next(1, 5);
                switch (excToThrow)
                {
                    //These are exceptions that could happen with File.Open
                    case 1: throw new FileNotFoundException("File not Found", pathName);
                    case 2: throw new UnauthorizedAccessException();
                    case 3: throw new PathTooLongException();
                    case 4: throw new DirectoryNotFoundException();
                    case 5: throw new ArgumentException();
                    default:
                        break;
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch  (UnauthorizedAccessException ex)
            {
                Console.Write("You are not permited to access this file. Your request is belongd to us.");
                Console.WriteLine(ex.Message);
            }
            catch  (IOException ex)
            {
                if (ex.GetType() == typeof(PathTooLongException))
                {
                    Console.WriteLine("The File Path is Too Long. Try again without the Verbosity");
                }
                else if (ex.GetType() == typeof(DirectoryNotFoundException))
                {
                    Console.WriteLine("We cant find that folder");
                }
                else
                {
                    Console.WriteLine("The file system cant handle your request for some reason. Try Later");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something happened. Were not sure what quite yet. {0}", ex.ToString()); 

            }
        }
    }
}
