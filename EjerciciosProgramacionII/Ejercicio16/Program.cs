using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alUno = new Alumno("Denis", "Pedemonte", 103322 );
            Alumno alDos = new Alumno("Leonel", "Pedemonte", 103323);
            Alumno alTres = new Alumno("Gustavo", "Suarez", 103324);

            alUno.Estudiar(8, 8);
            alDos.Estudiar(9, 9);
            alTres.Estudiar(2, 2);

            alUno.CalcularFinal();
            alDos.CalcularFinal();
            alTres.CalcularFinal();

            Console.WriteLine(alUno.Mostrar());
            Console.WriteLine(alDos.Mostrar());
            Console.WriteLine(alTres.Mostrar());
            Console.ReadKey();
        }
    }
}
