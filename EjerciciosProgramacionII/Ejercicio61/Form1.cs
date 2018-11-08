using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio61.Clases;


namespace Ejercicio61
{
    public partial class Form1 : Form
    {
        PersonaDAO personaDAO = new PersonaDAO();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load( object sender, EventArgs e )
        {
            
        }

        private void btnLeer_Click( object sender, EventArgs e )
        {
            
            var result = personaDAO.Leer();

            this.lstBox.DataSource = result;
        }

        private void btnGuardar_Click( object sender, EventArgs e )
        {
            Persona persona = new Persona( this.txtNombre.Text, this.txtApellido.Text );

            bool result = personaDAO.Guardar( persona );

            if ( result )
                MessageBox.Show( "Usuario Guardado con Exito.", "Resultado de la Operacion", MessageBoxButtons.OK, MessageBoxIcon.Information );

            MessageBox.Show( "Usuario no guardado.", "Resultado de la Operacion", MessageBoxButtons.OK, MessageBoxIcon.Error );
        }
    }
}
