using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio73
{
    class Program
    {
        static void Main(string[] args)
        {
            char cont = 'y';
            while ( cont.Equals('y') )
            {
                Console.WriteLine("Ingrese cadena a analizar");
                string inputText = Console.ReadLine();

                Dictionary<string, int> result = inputText.PunctuationCount();

                Console.WriteLine("Resultados:");

                foreach (var item in result)
                {
                    Console.WriteLine("{0} -> {1}", item.Key, item.Value);
                }
                Console.Write("¿Continuar? y/n    ");
                cont = Console.ReadKey().KeyChar;
                Console.Clear();

            }


        }
    }
}
