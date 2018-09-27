using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio37
{
    public abstract class Llamada
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

        public abstract float CostoLlamada
        {
            get;
        }

        #endregion

        #region Methods

        public Llamada( float duracion, string origen, string destino)
        {
            this.duracion = duracion;
            this.numOrigen = origen;
            this.numDestino = destino;
        }

        protected virtual string Mostrar()
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

        #region Overrides

        public static bool operator ==( Llamada llamadaUno, Llamada llamadaDos)
        {
            if ( llamadaUno.Equals(llamadaDos) && llamadaUno.numDestino == llamadaDos.numDestino && llamadaUno.numOrigen == llamadaDos.numOrigen )
                return true;

            return false;
     
        }

        public static bool operator !=(Llamada llamadaUno, Llamada llamadaDos)
        {
            return !(llamadaUno == llamadaDos);
        }

        #endregion
    }
}
