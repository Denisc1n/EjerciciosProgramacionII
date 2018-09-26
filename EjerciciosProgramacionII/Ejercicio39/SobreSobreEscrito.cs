using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio39
{
    class SobreSobreEscrito : SobreEscrito
    {
        public override string GetAtributo
        {
            get
            {
                return this.miAtributo;
            }
        }
    }
}
