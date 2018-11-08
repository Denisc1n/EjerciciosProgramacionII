using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio64
{
    class Caja
    {
        List<string> filaClientes;

        public List<string> GetClientes
        {
            get
            {
                return this.filaClientes;
            }
        }

        public Caja()
        {
            this.filaClientes = new List<string>();
        }

        public void AtenderClientes()
        {
            foreach (var item in this.GetClientes)
            {
                Console.WriteLine("Atendiendo Cliente " + item );
                Thread.Sleep(2000);
            }
        }
    }
}
