using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio61.Clases
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string apellido;

        #region Properties

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        #endregion

        public Persona() { }

        public Persona( string inputNombre, string inputApellido, int inputId )
        {
            this.nombre = inputNombre;
            this.apellido = inputApellido;
            this.id = inputId;
        }

        public Persona( string inputNombre, string inputApellido )
        {
            this.nombre = inputNombre;
            this.apellido = inputApellido;
        }

    }
}
