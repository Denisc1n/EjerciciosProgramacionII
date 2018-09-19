using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random randomizer = new Random();
            int auxCheck = 0;
            for (int i = 0; i < 20; i++)
            {
                auxCheck = randomizer.Next(-200,200);
                while ( auxCheck == 0 )
                {
                    auxCheck = randomizer.Next(-200,200);
                }
                array[i] = auxCheck;
            }

            Console.WriteLine("Vector Ingresado:");

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(array[i]);
            }

            

            Console.WriteLine("Ordenando Positivos de forma Decreciente");

            int[] posArray = new int[20];

            for (int i = 0; i < 20; i++)
            {
                if (array[i]>0)
                {
                    posArray[i] = array[i];
                }
            }
            Array.Sort(posArray);
            Array.Reverse(posArray);

            for (int i = 0; i < 20; i++)
            {
                if (posArray[i] == 0) continue;

                Console.WriteLine(posArray[i]);
            }

            Console.WriteLine("Ordenando Negativos de forma Creciente");

            int[] negArray = new int[20];

            for (int i = 0; i < 20; i++)
            {
                if (array[i] < 0)
                {
                    negArray[i] = array[i];
                }
            }

            Array.Sort(negArray);
           


            for (int i = 0; i < 20; i++)
            {
                if (negArray[i] == 0) continue;

                Console.WriteLine(negArray[i]);
            }

            Console.ReadKey();
        }
    }
}
