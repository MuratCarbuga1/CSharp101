using System;
using System.Collections.Generic;
using System.Text;

namespace _01_MainSubjests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            # region Strings 
            //string name = "Murat Carbuga";
           // Console.WriteLine(name);
            #endregion

            #region Menü

            int hamburgerPrice = 400;
            int cokePrice = 150;
            float frenchfriesPrice = 200.5f;
            double waterPrice = 10.99;

            Console.WriteLine("****The Price of Menu Items: ****");
            Console.WriteLine();
            Console.WriteLine("Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("Coke: " + cokePrice + " TL");
            Console.WriteLine("French Fries: " + frenchfriesPrice + " TL");
            Console.WriteLine("Water: " + waterPrice + " TL");
            #endregion

            Console.Read();
        }
    }
}
