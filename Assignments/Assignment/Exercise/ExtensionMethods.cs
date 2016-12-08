using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    public static class ExtensionMethods
    {
        public static bool IsNullOrEmpty(this string value)
        {
            return (value == "" || value == null) ? true : false;
        }

        internal static void ExtensionStringEmptyOrNull(List<string> _input)
        {
            foreach (var input in _input)
            {
                input.IsNullOrEmpty();
                Console.WriteLine(string.Format("\r\nInput:{0}, Output:{1}", input == null ? "null" : input, input.IsNullOrEmpty()));

            }
        }
    }
}
