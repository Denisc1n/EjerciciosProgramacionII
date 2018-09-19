using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string _nombre;

        #region Properties

        public Cliente Cliente
        {
            get
            {
                return clientes.Peek();
            }
        }

        #endregion

        #region Constructors

        private Negocio()
        {
            clientes = new Queue<Cliente>();
            caja = new PuestoAtencion(EPuesto.Caja1);
        }

        public Negocio(string nombre) : this()
        {
            this._nombre = nombre;
        }


        #endregion

        #region Overrides

        public static bool operator +(Cliente cli, Negocio n)
        {
            foreach (Cliente item in n.clientes)
            {
                if (cli == item)
                {
                    return false;
                }
            }
            n.clientes.Enqueue(cli);
            return true;
        }

        public static bool operator ==(Cliente cli, Negocio n)
        {
            foreach (Cliente item in n.clientes)
            {
                if (cli == item)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Cliente cli, Negocio n)
        {
            return !(cli == n);
        }

        public static bool operator ~( Negocio n )
        {
            Cliente cliente = n.Cliente;
            n.clientes.Dequeue();
            n.caja.Atender(cliente);
            Console.WriteLine($"Cliente Atendido: {cliente.GetNombre} - Restantes: {n.clientes.Count()}");
            
            return true;
        }
        #endregion

    }
}
