using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio64
{
    public class Negocio
    {
        Caja cajaUno;
        Caja cajaDos;

        List<string> clientes;


        public Caja GetCajaUno
        {
            get
            {
                return this.cajaUno;
            }
        }

        public Caja GetCajaDos
        {
            get
            {
                return this.cajaDos;
            }
        }

        public List<string> GetClientes
        {
            get
            {
                return this.clientes;
            }
            set
            {
                this.clientes = value;
            }
        }


        public Negocio(Caja cajaPrimera, Caja cajaSegunda)
        {
            this.cajaUno = cajaPrimera;
            this.cajaDos = cajaSegunda;
            this.clientes = new List<string>();
        }

        public void AsignarClientes()
        {
            Console.WriteLine("Asignando Clientes...");

            foreach (var item in this.clientes)
            {
                if (cajaUno.GetClientes.Count > cajaDos.GetClientes.Count)
                    cajaDos.GetClientes.Add(item);

                else
                    cajaUno.GetClientes.Add(item);

                Thread.Sleep( 1000 );
            }
        }

    }
}
