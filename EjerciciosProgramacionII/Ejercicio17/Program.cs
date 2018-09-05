using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            string d = "";
            Boligrafo boligrafo = new Boligrafo( ConsoleColor.Blue, 100 );
            Console.WriteLine( "Boligrafo Cargado: {0} Unidades", boligrafo.GetTinta );
            boligrafo.Pintar( 2, out d );
            Console.WriteLine( "Escritura - Tinta Restante {0}", boligrafo.GetTinta );
            Console.ForegroundColor = boligrafo.GetColor;
            Console.WriteLine( d );
            Console.ResetColor();

            d = "";
            boligrafo = new Boligrafo( ConsoleColor.Red, 10 );
            Console.WriteLine( "Boligrafo Cargado: {0} Unidades", boligrafo.GetTinta );
            bool resultado = boligrafo.Pintar( 11, out d );
            Console.WriteLine( "Escritura: Tinta Restante {0}", boligrafo.GetTinta );
            Console.ForegroundColor = boligrafo.GetColor;
            Console.WriteLine( d );

            d = "";
            boligrafo = new Boligrafo( ConsoleColor.Red, 150 );
      

            Console.ReadKey();
        }
            
    }

}
  