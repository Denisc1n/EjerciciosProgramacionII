using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio52
{
    public class EscrituraWrapper
    {
        public ConsoleColor color;
        public string text;

        public EscrituraWrapper( ConsoleColor inputColor, string texto)
        {
            this.color = inputColor;
            this.text = texto;
        }
    }
}
