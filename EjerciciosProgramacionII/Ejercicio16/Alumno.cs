using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Alumno
    {
        private byte _notaUno;
        private byte _notaDos;
        private float _notaFinal;
        public int legajo;
        public string apellido, nombre;
      
        public Alumno() { }
        public Alumno( string nombre, string apellido, int legajo )
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }


        public void CalcularFinal()
        {
            if (this._notaUno >= 4 && this._notaDos >= 4)
            {
                this._notaFinal = new Random().Next(4, 10);
            }
            else
                this._notaFinal = -1;
        }

        public void Estudiar( byte notaUno, byte notaDos )
        {
            this._notaUno = notaUno;
            this._notaDos = notaDos;
        }

        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Nombre: {this.nombre}");
            stringBuilder.AppendLine($"Apellido: {this.apellido}");
            stringBuilder.AppendLine($"Legajo: {this.legajo}");
            stringBuilder.AppendLine($"Primer Nota: {this._notaUno}");
            stringBuilder.AppendLine($"Segunda Nota: {this._notaDos}");
            
            if (this._notaFinal.Equals(-1))
                stringBuilder.AppendLine("ALUMNO NO APROBADO");
            else
                stringBuilder.AppendLine($"Nota Final: {this._notaFinal}");

            return stringBuilder.ToString();
        }
    }

  
}
