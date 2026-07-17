using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_LearnIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else
            Console.WriteLine("Where are you from? ");
            string nationality = Console.ReadLine();
            nationality = nationality.ToUpper();

            if (nationality == "TURKEY")
            {
                Console.WriteLine("Hello, Turkish!");
            }
            else if (nationality == "GERMANY")
            {
                Console.WriteLine("Hello, German!");
            }
            else if (nationality == "USA")
            {
                Console.WriteLine("Hello, American!");
            }
            else if (nationality == "FRANCE")
            {
                Console.WriteLine("Hello, French!");
            }
            else if (nationality == "SPAIN")
            {
                Console.WriteLine("Hello, Spanish!");
            }
            else
            {
                Console.WriteLine("Hello, stranger!");
            }
            #endregion


        }
    }
}
