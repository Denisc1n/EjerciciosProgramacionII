using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio37
{
    public class Llamada
    {
        protected float duracion;
        protected string numOrigen;
        protected string numDestino;

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }

        #region Properties
        public float GetDuracion
        {
            get
            {
                return this.duracion;
            }
        }

        public string GetNumDestino
        {
            get
            {
                return this.numDestino;
            }
        }

        public string GetNumOrigen
        {
            get
            {
                return this.numOrigen;
            }
        }

        #endregion

        #region Methods

        public Llamada( float duracion, string origen, string destino)
        {
            this.duracion = duracion;
            this.numOrigen = origen;
            this.numDestino = destino;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Datos de Llamada: ");
            sb.Append($"Numero Origen:{this.numOrigen} - Numero Destino:{this.numDestino} - Duracion:{this.duracion}");

            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return llamada1.GetDuracion.CompareTo(llamada2.GetDuracion);
        }

        #endregion
    }
}
