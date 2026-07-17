using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LearnLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  For Loop

            //double sum = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //Console.WriteLine("The number is: " + i);
            //sum += i;
            //}

            //Console.WriteLine("The sum of the numbers is: " + sum);

         //   Console.Read();
            #endregion

            #region While Loop

            int i =1;
            int sum=0;
            while(i< 10)
            {
                i++;
                sum += i;
                Console.WriteLine("The number is: " + i);
            }
            Console.WriteLine("The sum of the numbers is: " + sum);


            Console.Read();
            #endregion

        }
    }
}
