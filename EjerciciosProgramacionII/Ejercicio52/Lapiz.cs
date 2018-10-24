using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio52
{
    public class Lapiz : IAcciones
    {
        private float leadAmount; 

        #region Properties
        ConsoleColor IAcciones.Color
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        float IAcciones.UnidadesDeEscritura
        {
            get
            {
                return this.leadAmount;
            }
            set
            {
                this.leadAmount = value;
            }
        }
        #endregion

        #region Constructores

        public Lapiz() { }

        public Lapiz(float unidades)
        {
            this.leadAmount = unidades;
        }
        #endregion

        #region Metodos

        public EscrituraWrapper Escribir(string texto)
        {
            int cantCaracteres = texto.Length;
            this.leadAmount -= cantCaracteres;
            return new EscrituraWrapper(((IAcciones)this).Color, texto);
        }

        public bool Recargar(int recarga)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("LAPIZ:");
            sb.AppendLine("Nivel de Minas Actual: "+ ((IAcciones)this).UnidadesDeEscritura );
            sb.AppendLine("Color: "+ ((IAcciones)this).Color);

            return sb.ToString();
        }

        #endregion
    }
}
