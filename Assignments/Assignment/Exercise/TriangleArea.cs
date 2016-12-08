using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    public static class TriangleArea
    {

        
        internal static bool VerifyTriangleCreation(int a, int b, int c)
        {
            if ((a + b > c) && (b + c > a) && (c + a > b)) return true;
            else return false;
        }

        public static double CalculateAreaofTriangle(List<int> _input)
        {
            int a = _input[0];
            int b = _input[1];
            int c = _input[2];

            if (VerifyTriangleCreation(a, b, c))
            {
                double s = (a + b + c) / 2;
                double intermediate = s * (s - a) * (s - b) * (s - c);
                return Math.Sqrt(intermediate);
            }
            else throw (new Exception("InvalidTriangleException"));
        }

        internal static void AreaOfTriangle(Sides _input)
        {
            Console.WriteLine(String.Format("\r\nArea of triangle for sides {0}, {1}, {2} is {3}", _input.side1, _input.side2, _input.side3, CalculateAreaofTriangle(_input.Input)));
        }
    }

    public static class Sides 
    {
        public int side1 { get; set; }
        public int side2 { get; set; }
        public int side3 { get; set; }

        private List<int> _input;

        public List<int> Input
        {
            get { return _input; }
            set
            {
                _input = value;
                side1 = _input[0];
                side2 = _input[1];
                side3 = _input[2];
            }
        }
    
    }
}
