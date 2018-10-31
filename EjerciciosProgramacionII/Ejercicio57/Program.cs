using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio57
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Denis", "Pedemonte");
            Console.WriteLine($"Guardando:{persona.Nombre} {persona.Apellido} ");
            Persona.Guardar(persona);
            Console.WriteLine($"Guardado Correcto, Procediendo a Leer...");


            Persona nuevaPersona = Persona.Leer(Environment.CurrentDirectory + "\\MiArchivo.xml");

            Console.WriteLine($"Persona Leida:{persona.Nombre} {persona.Apellido} ");
            Console.ReadLine();
        }
    }
}
