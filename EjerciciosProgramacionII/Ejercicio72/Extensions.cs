using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio72
{
    public static class NumberExtension
    {
        public static int DigitCount(this long input)
        {
            string stringToNum = input.ToString();

            return stringToNum.ToCharArray().Length;
        }
    }
}
