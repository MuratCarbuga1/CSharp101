using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_LearnArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Basic Array1 Operations

            //Değişken türü [] Diziadı = new Değişken türü[boyut];

           // int[] arr = new int[] { 1, 2, 3, 4, 5 };

            //Console.WriteLine(arr[0]);
            //Console.WriteLine(arr[1]);
            //Console.WriteLine(arr[2]);
            //Console.WriteLine(arr[3]);
            //Console.WriteLine(arr[4]);

            //Console.Read();
            #endregion

            #region Basic Array2 Operations

           /* int[] arr2 = new int[5];

            Console.WriteLine("Enter first value of array: ");
            arr2[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second value of array: ");
            arr2[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third value of array: ");
            arr2[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter fourth value of array: ");
            arr2[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter fifth value of array: ");
            arr2[4] = int.Parse(Console.ReadLine());
            double average = 0;
            for(int i=0; i<arr2.Length; i++) {
                Console.WriteLine("Value at index {0}: {1}", i, arr2[i]);
                 average = arr2.Average();
            }
            
            Console.WriteLine("Average: {0}", average);

            Console.Read(); */
            #endregion

            #region Basic Array3 Operations

            string[] cities = new string[5];

            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine($"Lütfen {i + 1}. şehri giriniz: ");
                cities[i] = Console.ReadLine();
            }

            Console.WriteLine("Girdiğiniz şehirler: ");

            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine($"{i + 1}. şehir: {cities[i]}");
            }

            Console.Read();  
            #endregion
        }
    }
}
