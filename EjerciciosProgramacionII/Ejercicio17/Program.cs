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
            Boligrafo boligrafo = new Boligrafo(ConsoleColor.White, 100);
            boligrafo.Pintar( 2, out d );
        }
            
    }

}
  