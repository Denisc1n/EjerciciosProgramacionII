using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;
namespace Ejercicio20
{
    class Program
    {
        static void Main( string[] args )
        {
            Dolar miDolar = new Dolar( 100 );
            Euro miEuro = new Euro( 500 );
            Peso miPeso = new Peso( 1000 );

            Console.WriteLine( "Billetes Generados" );

            Console.WriteLine( "Peso: " + miPeso.GetCantidad() );
            Console.WriteLine( "Dolar: " + miDolar.GetCantidad() );
            Console.WriteLine( "miEuro: " + miDolar.GetCantidad() );


            Console.WriteLine( "Cotizaciones:" );

            Console.WriteLine( "Peso: " + Peso.GetCotizacion() );
            Console.WriteLine( "Dolar: " + Dolar.GetCotizacion() );
            Console.WriteLine( "Euro: " + Euro.GetCotizacion() );

            Console.WriteLine( "Conversion de Pesos a Dolares" );
            Console.WriteLine( miPeso.GetCantidad() + " Equivale a: " + ( ( Dolar ) miPeso).GetCantidad() );

            Console.WriteLine( "Conversion de Dolares a Pesos" );
            Console.WriteLine( miDolar.GetCantidad() + " Equivale a: " + ( ( Peso ) miDolar ).GetCantidad() );

            Console.WriteLine( "Conversion de Pesos a Euros" );
            Console.WriteLine( miPeso.GetCantidad() + " Equivale a: " + ( ( Euro ) miPeso ).GetCantidad() );

            Console.WriteLine( "Conversion de Euros a Pesos" );
            Console.WriteLine( miEuro.GetCantidad() + " Equivale a: " + ( ( Peso ) miEuro ).GetCantidad() );

            Console.WriteLine( "Conversion de Dolares a Euros" );
            Console.WriteLine( miDolar.GetCantidad() + " Equivale a: " + ( ( Euro ) miDolar ).GetCantidad() );

            Console.WriteLine( "Conversion de Euros a Dolares" );
            Console.WriteLine( miEuro.GetCantidad() + " Equivale a: " + ( ( Dolar ) miEuro ).GetCantidad() );

            Console.ReadLine();

        }
    }
}
