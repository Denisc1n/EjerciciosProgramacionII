using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio31
{
    public enum EPuesto
    {
        Caja1 = 1,
        Caja2
    }


    public class PuestoAtencion
    {
        private static int _numeroActual;
        private EPuesto puesto;

        #region Properties

        public static int NumeroActual
        {
            get
            {
                _numeroActual++;
                return _numeroActual;
            }
        }

        #endregion

        #region Constructors

        static PuestoAtencion()
        {
            _numeroActual = 0;
        }

        public PuestoAtencion( EPuesto puesto)
        {
            this.puesto = puesto;
        }

        #endregion

        #region Methods

        public bool Atender( Cliente cli )
        {
            Thread.Sleep(500);
            return true;
        }

        #endregion


    }
}
