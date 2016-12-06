using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMenuCard();
            //Console.Read();
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
                    case '1': ExtensionStringEmptyOrNull(); break;
                    case '2': GetDivisors(); break;
                    case '3': AreaOfTriangle(); break;
                    case '0': return;
                    default: Console.WriteLine("Please enter a valid input"); break;
                }
                Console.ReadKey();
                Console.Clear();
            }


        }

        private static void ExtensionStringEmptyOrNull()
        {
            List<string> _input = new List<string>
            {
                {null},
                {"a"},
                {""},
                "\"null\""
            };

            foreach (var input in _input)
            {
                Console.WriteLine(string.Format("\r\nInput:{0}, Output:{1}", input == null ? "null" : input, input.IsNullOrEmpty()));

            }
        }

        static void GetDivisors()
        {
            List<int> _input = new List<int>
            {
                60, 42
            };

            foreach (var input in _input)
            {
                Console.WriteLine("\r\nDivisors for " + input + ":");
                Console.WriteLine(GetDivisors(input));
                Console.WriteLine("******************************");
            }
        }

        /// <summary>
        /// Range would be from 1..half of the number.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static string GetDivisors(int num)
        {
            var enumerator = Enumerable.Range(1, num / 2).Where(x => num % x == 0).Select(x => x.ToString()).ToList();
            enumerator.Add(num.ToString() + "}");

            return String.Join(",", enumerator.ToArray()).Insert(0, "{");
        }

        static bool VerifyTriangleCreation(int a, int b, int c)
        {
            if ((a + b > c) && (b + c > a) && (c + a > b)) return true;
            else return false;
        }

        static void AreaOfTriangle(int a=3, int b=4, int c=5)
        {

            List<int> _input = new List<int>
            {
                3,4,5
            };

            a = _input[0];
            b = _input[1];
            c = _input[2];

            if (VerifyTriangleCreation(a, b, c))
            {
                double s = (a + b + c) / 2;
                double intermediate = s * (s - a) * (s - b) * (s - c);

                Console.WriteLine(String.Format("\r\nArea of triangle for sides {0}, {1}, {2} is {3}", a,b,c, Math.Sqrt(intermediate)));
            }
            else throw (new Exception("InvalidTriangleException"));
        }
    }

    static class ExtensionMethod
    {
        public static bool IsNullOrEmpty(this string value)
        {
            return (value == "" || value == null) ? true : false;
        }
    }
}
