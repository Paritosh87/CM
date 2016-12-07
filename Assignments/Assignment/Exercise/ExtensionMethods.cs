using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    static class ExtensionMethods
    {
        public static bool IsNullOrEmpty(this string value)
        {
            return (value == "" || value == null) ? true : false;
        }

        public static void ExtensionStringEmptyOrNull()
        {
            List<string> _input = Inputs.ExtensionStringEmptyOrNull();

            foreach (var input in _input)
            {
                input.IsNullOrEmpty();
                Console.WriteLine(string.Format("\r\nInput:{0}, Output:{1}", input == null ? "null" : input, input.IsNullOrEmpty()));

            }
        }
    }
}
