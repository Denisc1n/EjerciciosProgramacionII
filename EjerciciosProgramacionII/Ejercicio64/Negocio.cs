using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio64
{
    class Negocio
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
        }


        public Negocio(Caja cajaPrimera, Caja cajaSegunda)
        {
            this.cajaUno = cajaPrimera;
            this.cajaDos = cajaSegunda;
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
            }
        }

    }
}
