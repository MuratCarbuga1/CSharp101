using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_LearnSwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which month were you born in? ");
            string month = Console.ReadLine();

            switch(month.ToLower())
            {
                case "january":
                    Console.WriteLine("You were born in January.");
                    break;
                case "february":
                    Console.WriteLine("You were born in February.");
                    break;
                case "march":
                    Console.WriteLine("You were born in March.");
                    break;
                case "april":
                    Console.WriteLine("You were born in April.");
                    break;
                case "may":
                    Console.WriteLine("You were born in May.");
                    break;
                case "june":
                    Console.WriteLine("You were born in June.");
                    break;
                case "july":
                    Console.WriteLine("You were born in July.");
                    break;
                case "august":
                    Console.WriteLine("You were born in August.");
                    break;
                case "september":
                    Console.WriteLine("You were born in September.");
                    break;
                case "october":
                    Console.WriteLine("You were born in October.");
                    break;
                case "november":
                    Console.WriteLine("You were born in November.");
                    break;
                case "december":
                    Console.WriteLine("You were born in December.");
                    break;
                default:
                    Console.WriteLine("Invalid month entered.");
                    break;
            }
        }
    }
}
