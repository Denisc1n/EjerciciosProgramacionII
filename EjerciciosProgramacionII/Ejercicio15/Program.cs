using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal inputOne = 0, inputTwo = 0;
            string operation = "";
            bool exit = false;

            while ( exit == false )
            {
                Console.WriteLine("Ingrese primer valor:");
                decimal.TryParse(Console.ReadLine(), out inputOne);

                Console.WriteLine("Ingrese segundo valor:");
                decimal.TryParse(Console.ReadLine(), out inputTwo);

                Console.WriteLine("Ingrese Operacion");
                operation = Console.ReadLine();

                Console.WriteLine("Resultado de la Operacion: {0}", Calculadora.Calcular(inputOne, inputTwo, operation) );
                Console.WriteLine("Presione S si desea continuar o N para salir ");
                if (Console.ReadLine().ToLower() == "n")
                {
                    exit = true;
                }
            }

        }
    }
}
