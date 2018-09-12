using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private double _cantidad;
        private static float _cotizacionRespectoDolar;


        #region Constructors

        static Dolar()
        {
            _cotizacionRespectoDolar = 5;
        }

        public Dolar() { }

        public Dolar( double cant )
        {
            this._cantidad = cant;
        }
        
        public Dolar( double cant, float cotiz ):this( cant ) 
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


        public static explicit operator Euro ( Dolar d )
        {
            return new Euro( ( d._cantidad / Euro.GetCotizacion() ) );
        }


        public static explicit operator Peso( Dolar d )
        {
            return new Peso( ( d._cantidad * Peso.GetCotizacion() ) );
        }


        public static implicit operator Dolar( double cant )
        {
            return new Dolar( cant );
        }

        #endregion

        #region Overloads - Comparators
        //Dolar Euro
        public static bool operator == ( Dolar dollar, Euro euro )
        {
            var auxEuro = euro.GetCantidad();

            if ( dollar._cantidad == ( euro.GetCantidad() * Euro.GetCotizacion() ) )
                return true;
            

            return false;
        }

        public static bool operator !=( Dolar dollar, Euro euro )
        {
            return !( dollar == euro );
        }

        //Dolar Peso
        public static bool operator == ( Dolar dollar, Peso peso )
        {
            if ( dollar._cantidad == ( peso.GetCantidad() * Peso.GetCotizacion() ) )
                return true;
            
            return false;
        }

        public static bool operator !=( Dolar dollar, Peso peso )
        {
            return !( dollar == peso );
        }

        //Dolar dolar
        public static bool operator ==( Dolar dollar, Dolar otherDollar )
        {
            if ( dollar._cantidad == otherDollar._cantidad  )
                return true;

            return false;
        }

        public static bool operator !=( Dolar dollar, Dolar otherDollar )
        {
            return !( dollar == otherDollar );
        }
        #endregion

        #region Overloads - Operators

        public static Dolar operator +( Dolar d, Euro e )
        {
            var auxDolar = new Dolar( e.GetCantidad() * Euro.GetCotizacion() );

            auxDolar._cantidad += d._cantidad;
            return auxDolar;
        }

        public static Dolar operator +( Dolar d, Peso p )
        {
            var auxDolar = new Dolar( p.GetCantidad() / Peso.GetCotizacion() );

            auxDolar._cantidad += d._cantidad;
            return auxDolar;
        }

        public static Dolar operator -( Dolar d, Euro e )
        {
            var auxDolar = new Dolar( e.GetCantidad() * Euro.GetCotizacion() );

            auxDolar._cantidad -= d._cantidad;
            return auxDolar;
        }

        public static Dolar operator -( Dolar d, Peso p )
        {
            var auxDolar = new Dolar( p.GetCantidad() / Peso.GetCotizacion() );

            auxDolar._cantidad -= d._cantidad;
            return auxDolar;
        }


        #endregion

    }
}
