using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    static class TriangleArea
    {
        public static bool VerifyTriangleCreation(int a, int b, int c)
        {
            if ((a + b > c) && (b + c > a) && (c + a > b)) return true;
            else return false;
        }

        public static void AreaOfTriangle(int a = 3, int b = 4, int c = 5)
        {

            List<int> _input = Inputs.GetSides();

            a = _input[0];
            b = _input[1];
            c = _input[2];

            if (VerifyTriangleCreation(a, b, c))
            {
                double s = (a + b + c) / 2;
                double intermediate = s * (s - a) * (s - b) * (s - c);

                Console.WriteLine(String.Format("\r\nArea of triangle for sides {0}, {1}, {2} is {3}", a, b, c, Math.Sqrt(intermediate)));
            }
            else throw (new Exception("InvalidTriangleException"));
        }
    }
}
