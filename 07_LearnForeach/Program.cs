using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_LearnForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Loop Example

            /* string[] cities = {"İstanbul", "Ankara", "İzmir", "Bursa", "Antalya"};

             foreach (string city in cities)
             {
                 Console.WriteLine(city);
             }


             Console.Read();*/
            #endregion

            #region List Example

            List<string> cities = new List<string>();
            cities.Add("İstanbul");
            cities.Add("Ankara");
            cities.Add("İzmir");
            cities.Add("Bursa");
            cities.Add("Antalya");

            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }

            Console.Read();
            #endregion
        }
    }
}
