using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Ejercicio57
{
    public class Persona
    {
        private string nombre;
        private string apellido;

        public Persona() { }

        public Persona( string inputNombre, string inputApellido)
        {
            this.nombre = inputNombre;
            this.apellido = inputApellido;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        public static void Guardar( Persona persona)
        {
           
            XmlTextWriter xmlWriter = new XmlTextWriter(ConfigurationManager.AppSettings["RutaArchivo"], Encoding.UTF8);
            XmlSerializer serializer = new XmlSerializer(typeof(Persona));
            xmlWriter.Close();

        }

        public static Persona Leer (string ruta)
        {
            XmlTextReader xmlReader = new XmlTextReader(ruta);
            XmlSerializer serializer = new XmlSerializer(typeof(Persona));
            Persona personaAux;
            personaAux = (Persona)serializer.Deserialize(xmlReader);
            xmlReader.Close();
            return personaAux;
        }
    }
}
