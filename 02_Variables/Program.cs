using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Girdi Alma
            double exam1,exam2,exam3, average;

            Console.Write("Enter your first exam score: ");
            exam1=double.Parse(Console.ReadLine());

            Console.Write("Enter your second exam score: ");
            exam2=double.Parse(Console.ReadLine());

            Console.Write("Enter your third exam score: ");
            exam3=double.Parse(Console.ReadLine());

            average = (exam1 + exam2 + exam3) / 3;

            Console.Write("Your average score is: "+average);

            Console.Read();

            #endregion
        }
    }
}
