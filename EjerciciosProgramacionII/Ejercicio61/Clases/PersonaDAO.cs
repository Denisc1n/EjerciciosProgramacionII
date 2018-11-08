using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio61.Clases
{
    public class PersonaDAO
    {

        public static SqlCommand CrearConexion()
        {
            String connectionStr = "Data Source=(local); " +
                "Initial Catalog =Persona; Integrated Security = True";
            SqlConnection connection = new SqlConnection( connectionStr );
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = connection;
            return comando;
        }
        
        public bool Guardar( Persona persona )
        {

            SqlCommand comando = CrearConexion();
            comando.CommandText = $"insert into Personas (nombre, apellido) values ({persona.Nombre},{persona.Apellido})";

            comando.Connection.Open();
            int result = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if ( result > 0 ) return true;

            return false;
        }

        public List<Persona> Leer()
        {
            SqlCommand comando = CrearConexion();

            comando.CommandText = $"Select * from Personas";

            comando.Connection.Open();

            var result = comando.ExecuteReader();

            

            List<Persona> personasRecibidas = new List<Persona>();
            
            while ( result.Read() )
            {
                personasRecibidas.Add( new Persona( result["Nombre"].ToString(), result["Apellido"].ToString(), int.Parse( result["Id"].ToString() ) ) );
            }
            comando.Connection.Close();
            return personasRecibidas;
        }

        public Persona LeerPorID( int id )
        {
            SqlCommand comando = CrearConexion();

            comando.CommandText = $"Select * from Personas where ID={ id }";

            comando.Connection.Open();

            var result = comando.ExecuteReader();

            comando.Connection.Close();

            Persona personaRecibida = new Persona();

            while ( result.Read() )
            {
                personaRecibida.Apellido  = result["Apellido"].ToString();
                personaRecibida.Nombre    = result["Nombre"].ToString();
                personaRecibida.Id        = int.Parse( result["Id"].ToString() );
            }

            return personaRecibida;
        }

        public bool Modificar( int id, Persona personaAmodificar )
        {
            SqlCommand comando = CrearConexion();

            Persona persona = this.LeerPorID( id );

            StringBuilder query = new StringBuilder();
            query.Append( "UPDATE Personas SET" );

            if ( persona.Nombre != personaAmodificar.Nombre )
                query.Append( " Nombre="+personaAmodificar.Nombre );
            if ( persona.Apellido != personaAmodificar.Apellido )
                query.Append( " ,Apellido=" + personaAmodificar.Apellido );

            query.Append( " WHERE ID=" + id );

            comando.CommandText = query.ToString();

            comando.Connection.Open();
            int result = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if ( result > 0 )
                return true;

            return false;
        }

        public bool Borrar( int id )
        {
            SqlCommand comando = CrearConexion();

            comando.CommandText = string.Format( "DELETE FROM Personas WHERE ID={0} ", id );

            comando.Connection.Open();
            int result = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if ( result > 0 )
                return true;

            return false;
        }
    }
}
