using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Producto
    {
        private string _codigoDeBarra;
        private string _marca;
        private float _precio;

        #region Constructors
        public Producto( string marca, string codigo, float precio)
        {
            this._codigoDeBarra = codigo;
            this._marca = marca;
            this._precio = precio;
        }
        #endregion


        #region Methods

        public string GetMarca()
        {
            return this._marca;
        }
        
        public float GetPrecio()
        {
            return this._precio;
        }

        public static string MostrarProducto(Producto prod)
        {
            StringBuilder retValue = new StringBuilder();
            retValue.AppendLine($"Marca:{prod._marca} - Precio:{prod._precio} - Codigo de Barras:{prod._codigoDeBarra}" );

            return retValue.ToString();
        }


        #endregion


        #region Operator Overrides

        public static explicit operator string( Producto p)
        {
            return p._codigoDeBarra;
        }

        public static bool operator ==(Producto prodOne, Producto prodTwo)
        {
            if ( prodOne._codigoDeBarra.Equals(prodTwo._codigoDeBarra ) && prodOne._marca.Equals( prodTwo._marca ) )
                return true;

            return false;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            if (!p1._codigoDeBarra.Equals(p2._codigoDeBarra) && !p1._marca.Equals(p2._marca))
                return true;

            return false;
        }

        public static bool operator ==(Producto p1, string marca)
        {
            if ( p1._marca.Equals( marca ) )
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Producto p1, string marca)
        {
            if ( !p1._marca.Equals( marca ) )
            {
                return true;
            }
            return false;
        }





        #endregion






    }
}
