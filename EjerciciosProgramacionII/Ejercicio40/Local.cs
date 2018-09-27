using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio37
{
    public class Local:Llamada
    {
        
        protected float costo;
        
        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        

        public Local(Llamada llamada, float costo)
            : base(llamada.GetDuracion, llamada.GetNumDestino, llamada.GetNumOrigen)
        {
            this.costo = costo;
        }

        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion, destino, origen)  
        {
            this.costo = costo;
        }
       
        protected override string Mostrar()
        {
            StringBuilder s = new StringBuilder();
            s.AppendLine(base.ToString() + $"Costo:{this.CostoLlamada}");

            return s.ToString();
        }

        private float CalcularCosto()
        {
            return this.GetDuracion * this.costo;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            return obj is Local ? true : false;
        }
    }
}
