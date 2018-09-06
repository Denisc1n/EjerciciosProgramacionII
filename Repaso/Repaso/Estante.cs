using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Estante
    {
        private Producto[] _productos;
        private int _ubicacionEstante;

        #region Constructors
        private Estante( int capacidad )
        {
            this._productos = new Producto[capacidad];
        }

        public Estante( int capacidad, int ubicacion ):this( capacidad )
        {
            this._ubicacionEstante = ubicacion;     
        }

        #endregion

        #region Methods

        public Producto[] GetProductos()
        {
            return this._productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder retValue = new StringBuilder();
            retValue.AppendLine("Productos en el estante ubicado en:" + e._ubicacionEstante);
            foreach ( var item in e._productos )
            {
                retValue.AppendLine(Producto.MostrarProducto(item));
            }

            return retValue.ToString();
        }

        #endregion

        #region Operator Overrides

        public static bool operator == ( Estante e, Producto p )
        {
            foreach (Producto aux in e._productos)
            {
                
                if (!object.ReferenceEquals(aux, null))
                {
                    if (p == aux)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e==p) ;
        }

        public static bool operator +( Estante e, Producto p )
        {

            if (e != p)
            {
                
                for (int i = 0; i < e._productos.Length; i++)
                {
                   
                    if (object.ReferenceEquals(e._productos[i], null))
                    {
                        e._productos[i] = p;
                        
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator -(Estante e, Producto p)
        {
            for (int i = 0; i < e._productos.Length; i++)
            {
                
                if (!object.ReferenceEquals(e._productos[i], null))
                {
                    
                    if (p == e._productos[i])
                    {
                        
                        e._productos[i] = null;
                        break;
                    }
                }
            }

            return false;
        }

        #endregion

    }
}
