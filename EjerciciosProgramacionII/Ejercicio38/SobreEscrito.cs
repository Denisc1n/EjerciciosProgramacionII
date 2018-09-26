using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio38
{
    class SobreEscrito
    {
        public override string ToString()
        {
            return "Este es mi metodo ToString()";
        }
        public override bool Equals(object obj)
        {
            if ( this.GetType().Equals(obj.GetType()) )
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return 1142017893;
        }
    }
}
