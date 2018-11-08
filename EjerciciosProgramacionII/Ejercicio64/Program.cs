using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio64
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja cajaUno = new Caja();
            Caja cajaDos = new Caja();

            Negocio negocioUno = new Negocio( cajaUno, cajaDos );
            negocioUno.GetClientes = new List<string> { "Juan","Pedro","Daniel","Maria","Raquel","Gonzalo","Juan" };
            Thread negocioThread = new Thread( negocioUno.AsignarClientes );

            negocioThread.Start();
            negocioThread.Join();

            Thread threadCajaUno = new Thread( cajaUno.AtenderClientes )
            {
                Name = "Caja Uno"
            };

            Thread threadCajaDos = new Thread( cajaDos.AtenderClientes )
            {
                Name = "Caja Dos",
            };
            
            threadCajaUno.Start();
            threadCajaDos.Start();

            Console.ReadKey();

        }
    }
}
  