using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio72
{
    class Program
    {
        static void Main(string[] args)
        {
            while( true )
            { 
                long value;
                Console.Write($"Ingrese Numero: ");
                long.TryParse(Console.ReadLine(), out value);

                if ( value != 0 )
                {
                    string result = value.DigitCount().ToString();
                    Console.WriteLine($"Numero de:       " + value.DigitCount().ToString());
                    continue;
                }

                break;
            }
        }
    }
}
