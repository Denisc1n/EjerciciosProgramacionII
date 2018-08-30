using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosProgramacionII
{
    class Program
    {
        static void Main(string[] args)
        {
            int minVal = 0;
            int maxVal = 0;
            int value = 0;
            double sum = 0;
            bool first = true;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Ingrese Valor nro {i + 1}");
                int.TryParse(Console.ReadLine(), out value);
                if ( !Validacion.Validar(value, -100, 100 ) )
                {
                    i--;
                    continue;
                }
                if ( first )
                {
                    minVal = value;
                    maxVal = value;
                    sum = sum + value;
                    first = false;
                }
                else if ( value > maxVal )
                {
                    maxVal = value;
                    sum = sum + value;
                }
                else
                {
                    minVal = value;
                    sum = sum + value;
                }
            }
            Console.WriteLine("Mayor:{0} - Menor:{1} - Promedio {2:#.##}", maxVal,minVal, (sum/10));
            Console.ReadKey();


            
        }
    }
}
