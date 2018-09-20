using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio33
{
    class Libro
    {
        private List<string> paginas = new List<string>();

        public string this[int i]
        {
            get {
                if (i > 0 && i < this.paginas.Count)
                    return paginas[i];
                else
                    return $"Pagina {i} No encontrada.";
                }
            set
            {
                if (i> 0 && i< paginas.Count)
                {
                    paginas[i] = value;
                }
                else
                {
                    paginas.Add(value);
                }
            }
        }

    }
}
