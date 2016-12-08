using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMenuCard();
        }

        private static void ShowMenuCard()
        {
            Console.Clear();

            for (; ; )
            {
                Console.WriteLine("*******************Menu*************");
                Console.WriteLine("1. Verify Extension StringIsEmptyOrNull");
                Console.WriteLine("2. GetDivisors for 60, 42.");
                Console.WriteLine("3. Area of Triangle");
                Console.WriteLine("0. Quit");
                Console.WriteLine("************************************");

                switch (Console.ReadKey().KeyChar)
                {
                    case '1': ExtensionMethods.ExtensionStringEmptyOrNull(Inputs.ExtensionStringEmptyOrNull()); break;
                    case '2': Divisors.GetDivisors(Inputs.GetDivisors()); break;
                    case '3': TriangleArea.AreaOfTriangle(Inputs.GetSides()); break;
                    case '0': return;
                    default: Console.WriteLine("Please enter a valid input"); break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
