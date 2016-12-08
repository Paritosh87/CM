using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    public static class TriangleArea
    {
        static int a;
        static int b;
        static int c;
        
        internal static bool VerifyTriangleCreation(int a, int b, int c)
        {
            if ((a + b > c) && (b + c > a) && (c + a > b)) return true;
            else return false;
        }

        public static double CalculateAreaofTriangle(List<int> _input)
        {
            GetSides(_input, out a, out b, out c);
            
            if (VerifyTriangleCreation(a, b, c))
            {
                double s = (a + b + c) / 2;
                double intermediate = s * (s - a) * (s - b) * (s - c);
                return Math.Sqrt(intermediate);
            }
            else throw (new Exception("InvalidTriangleException"));
        }

        private static void GetSides(List<int> _input, out int a, out int b, out int c)
        {
            try
            {
                a = _input[0];
                b = _input[1];
                c = _input[2];
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        internal static void AreaOfTriangle(List<int> _input)
        {
            var area = CalculateAreaofTriangle(_input);
            Console.WriteLine(String.Format("\r\nArea of triangle for sides {0}, {1}, {2} is {3}", a, b, c, area));
        }
    }
}
