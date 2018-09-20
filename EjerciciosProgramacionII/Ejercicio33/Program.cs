using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio33
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro();
            libro[0] = "Pagina con Datos";
            libro[1] = "Pagina con Datos en Indice 1";
            libro[2] = "Pagina con datos en Indice 2";

            Console.WriteLine("Resultado: " + libro[3]);
            libro[3] = "Pagina con datos en Indice 3";
            Console.WriteLine("Resultado: " + libro[3]);
            Console.ReadLine();


        }
    }
}
