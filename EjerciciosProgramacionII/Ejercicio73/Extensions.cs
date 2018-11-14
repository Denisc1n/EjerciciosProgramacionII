using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio73
{
    public static class StringExtensions
    {
        public static Dictionary<string, int> PunctuationCount ( this string input)
        {
            char[] array = input.ToCharArray();
            int dots = 0;
            int commas = 0;
            int semiColons = 0;
            foreach ( var item in array )
            {
                if (item == '.')
                    dots++;
                else if (item == ',')
                    commas++;
                else if (item == ';')
                    semiColons++;
                else
                    continue;
            }

            return new Dictionary<string, int> { { "Puntos:", dots }, { "Comas:", commas }, { "Puntos Comas:", semiColons } };

            }
        } 
    }

