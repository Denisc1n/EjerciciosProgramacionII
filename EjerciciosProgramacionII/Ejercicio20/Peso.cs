using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{

    class Peso
    {
        private double _cantidad;
        private static float _cotizacionRespectoDolar;


        #region Constructors

        static Peso()
        {
            _cotizacionRespectoDolar = 40;
        }

        public Peso() { }

        public Peso( double cant )
        {
            this._cantidad = cant;
        }

        public Peso( double cant, float cotiz ) : this( cant )
        {
            _cotizacionRespectoDolar = cotiz;
        }


        #endregion

        #region Methods


        public double GetCantidad()
        {
            return this._cantidad;
        }

        public static float GetCotizacion()
        {
            return _cotizacionRespectoDolar;
        }

        #endregion

        #region Overloads - Converters


        public static explicit operator Dolar( Peso p )
        {
            return new Dolar( ( p.GetCantidad() / Peso.GetCotizacion() ) );
        }


        public static explicit operator Euro( Peso p )
        {
            var auxDolar = ( Dolar ) p;
            return new Euro( ( auxDolar.GetCantidad() * Euro.GetCotizacion() ) );
        }


        public static implicit operator Peso( double cant )
        {
            return new Peso( cant );
        }

        #endregion

        #region Overloads - Comparators
        //Peso Euro
        public static bool operator ==( Peso peso, Euro euro )
        {
            return (euro == peso);
        }

        public static bool operator !=( Peso peso, Euro euro )
        {
            return !( euro == peso );
        }

        //Peso Dolar
        public static bool operator ==( Peso peso, Dolar dolar)
        {
            return dolar == peso;
        }

        public static bool operator !=( Peso peso, Dolar dolar )
        {
            return !( dolar == peso );
        }

        //Peso Peso
        public static bool operator ==( Peso peso, Peso otherPeso )
        {
            if ( peso._cantidad == otherPeso._cantidad )
                return true;

            return false;
        }

        public static bool operator !=( Peso peso, Peso otherPeso )
        {
            return !( peso == otherPeso );
        }
        #endregion

        #region Overloads - Operators

        public static Peso operator +( Peso p, Dolar d )
        {
            return  ( Peso )( d + p );
        }

        public static Peso operator +( Peso p, Euro e )
        {
            return ( Peso ) ( e + p );
        }

        public static Peso operator -( Peso p, Dolar d )
        {
            return ( Peso ) ( d - p );
        }

        public static Peso operator -( Peso p, Euro e )
        {
            return p - (Dolar) e;
        }
        #endregion
    }
}
