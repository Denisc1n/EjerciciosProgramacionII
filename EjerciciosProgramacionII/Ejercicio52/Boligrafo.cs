using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio52
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        #region Properties
        public ConsoleColor Color
        {
            get
            {
                return this.colorTinta;
            }
            set
            {
                this.colorTinta = value;
            }
        }

        public float UnidadesDeEscritura
        {
            get
            {
                return this.tinta;
            }
            set
            {
                this.tinta = value;
            }
        }
        #endregion

        #region Constructores

        public Boligrafo() { }

        public Boligrafo( ConsoleColor color, float unidades)
        {
            this.tinta = unidades;
            this.colorTinta = color;
        }


        #endregion

        #region Metodos

        public EscrituraWrapper Escribir (string texto)
        {
            int cantCaracteres = texto.Length;
            this.tinta -= (float)(cantCaracteres*0.1);
            return new EscrituraWrapper( this.Color, texto );
        }

        public bool Recargar( int recarga)
        {
            this.tinta += recarga;
            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("LAPICERA:");
            sb.AppendLine("Nivel de Tinta Actual: "+ this.UnidadesDeEscritura);
            sb.AppendLine("Color de Tinta: " + this.Color);

            return sb.ToString();
        }

        #endregion
    }
}
