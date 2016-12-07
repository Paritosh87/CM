using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    static class Divisors
    {
        public static void GetDivisors()
        {
            List<int> _input = Inputs.GetDivisors();

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
        public static string GetDivisors(int num)
        {
            var enumerator = Enumerable.Range(1, num / 2).Where(x => num % x == 0).Select(x => x.ToString()).ToList();
            enumerator.Add(num.ToString() + "}");

            return String.Join(",", enumerator.ToArray()).Insert(0, "{");
        }
    }
}
