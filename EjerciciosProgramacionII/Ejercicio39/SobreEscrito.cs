using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio39
{
    abstract class SobreEscrito
    {
        protected string miAtributo;

        public SobreEscrito()
        {
            this.miAtributo = "Probar Abstractos.";
        }

        public abstract string GetAtributo
        {
            get;
        }

        public override string ToString()
        {
            return "Este es mi metodo ToString()";
        }
        public override bool Equals(object obj)
        {
            if (this.GetType().Equals(obj.GetType()))
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
