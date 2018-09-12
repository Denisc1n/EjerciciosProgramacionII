using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Euro
    {
        private double _cantidad;
        private static float _cotizacionRespectoDolar;

        #region Constructors

        static Euro()
        {
            _cotizacionRespectoDolar = 5;
        }

        public Euro() { }

        public Euro( double cant )
        {
            this._cantidad = cant;
        }

        public Euro( double cant, float cotiz ) : this( cant )
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


        public static explicit operator Dolar( Euro e )
        {
            return new Dolar( ( e._cantidad * Euro.GetCotizacion() ) );
        }


        public static explicit operator Peso( Euro e )
        {
            var auxEuroToDolar = ( Dolar ) e;
            return new Peso( ( auxEuroToDolar.GetCantidad() * Peso.GetCotizacion() ) );
        }


        public static implicit operator Euro( double cant )
        {
            return new Euro( cant );
        }

        #endregion

        #region Overloads - Comparators
        //Dolar Euro
        public static bool operator ==( Euro euro, Dolar dollar )
        {
            return dollar == euro;
        }

        public static bool operator !=( Euro euro, Dolar dollar )
        {
            return !( dollar == euro );
        }

        //Euro Peso
        public static bool operator ==( Euro euro, Peso peso )
        {
            var auxDolar = ( Dolar ) peso;
            if ( euro._cantidad == ( auxDolar.GetCantidad() / Euro.GetCotizacion() ) ) 
                return true;

            return false;
        }

        public static bool operator !=( Euro euro, Peso peso )
        {
            return !( euro == peso );
        }

        //Euro Euro
        public static bool operator ==( Euro euro, Euro otherEuro )
        {
            if ( euro._cantidad == otherEuro._cantidad )
                return true;

            return false;
        }

        public static bool operator !=( Euro euro, Euro otherEuro )
        {
            return !( euro == otherEuro );
        }
        #endregion

        #region Overloads - Operators

        public static Euro operator +( Euro e, Dolar d )
        {
            return ( Euro ) ( d + e );
        }

        public static Euro operator +( Euro e, Peso p )
        {
            return e + (Dolar) p;
        }

        public static Euro operator -( Euro e, Dolar d )
        {
            return e - d;
        }

        public static Euro operator -( Euro e, Peso p )
        {
            return e - ( Dolar ) p;
        }
        #endregion


    }
}

