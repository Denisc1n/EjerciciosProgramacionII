using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "ABCD";
            char[] array = cadena.ToCharArray();
            string reverse = "";
            for (int i = array.Length-1; i > -1; i--)
            {
                reverse += array[i];
            }

            Array.Reverse(array);

            Console.Write(reverse);
            Console.ReadLine();
        }
    }
}
