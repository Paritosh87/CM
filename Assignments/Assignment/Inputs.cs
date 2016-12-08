using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    static class Inputs
    {
        public static List<string> ExtensionStringEmptyOrNull()
        {
            return new List<string>
            {
                {null},
                {"a"},
                {""},
                "\"null\""
            };
        }

        public static List<int> GetDivisors()
        {
            return new List<int>
            {
                60, 42
            };

        }

        public static List<int> GetSides()
        {
            return new List<int>
            {
                3,4,5
            };
        }
    }
}
