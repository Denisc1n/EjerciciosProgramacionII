using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
    public class Cliente
    {
        private string _nombre;
        private int _numero;

        #region Constructors

        public string GetNombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                this._nombre = value;
            }
        }

        public int GetNumero
        {
            get
            {
                return this._numero;
            }
        }


        #endregion

        #region Methods

        public Cliente() { }

        public Cliente( int numero )
        {
            this._numero = numero;
        }

        public Cliente( string nombre, int numero ):this( numero )
        {
            this._nombre = nombre;
        }

        #endregion

        #region Overrides

        public static bool operator == ( Cliente clientOne, Cliente clientTwo)
        {
            if (clientOne._numero == clientTwo._numero )
                return true;

            return false;
        }

        public static bool operator != ( Cliente clientOne, Cliente clientTwo)
        {
            return !(clientOne == clientTwo);
        }


        #endregion
    }
}
