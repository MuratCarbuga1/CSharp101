using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_LearnMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Method Example

            /*  void PrintMessage(string message)
              {
                  Console.WriteLine(message);
              }

              PrintMessage("Hello, World!");
              Console.Read();*/
            #endregion

            #region Return Method Example
            int AddNumbers(int a, int b)
            {
                return a + b;
            }

            int result = AddNumbers(5, 10);
            Console.WriteLine($"The sum is: {result}");
            Console.Read();
            #endregion
        }
    }
}
