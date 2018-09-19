using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Denis", 12131415);
            Cliente clienteDos = new Cliente("Leonel", 01020304);

            Console.WriteLine("Clientes Cargados.");
            Console.WriteLine($"Se cargaron:");
            Console.WriteLine($"{cliente.GetNombre}, {cliente.GetNumero}");
            Console.WriteLine($"{clienteDos.GetNombre}, {clienteDos.GetNumero}");

            Negocio negocio = new Negocio("PrimerNegocio");

            Console.WriteLine($"Se creo Negocio");
            bool res =  cliente + negocio;
            Console.WriteLine($"Se intento agregar al Cliente: {cliente.GetNombre} al negocio. Resultado:{res}");
            res = clienteDos + negocio;
            Console.WriteLine($"Se intento agregar al Cliente: {clienteDos.GetNombre} al negocio. Resultado:{res}");
            
            res = cliente + negocio;
            Console.WriteLine($"Se intento agregar Nuevamente sal Cliente: {cliente.GetNombre} al negocio. Resultado:{res}");

            bool att = ~negocio;
            Console.ReadLine();
            

            
        }
    }
}
