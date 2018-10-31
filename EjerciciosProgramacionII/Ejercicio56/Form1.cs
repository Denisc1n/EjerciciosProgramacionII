using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio56
{
    public partial class Form1 : Form
    {
        public string lastPath;
        public Form1()
        {
            InitializeComponent();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofg = new OpenFileDialog();
            if (lastPath == null)
            {
                guardarComoToolStripMenuItem_Click(sender, e);
                return;
            }
            StreamWriter writer = new StreamWriter( lastPath, false );
            writer.Write(this.richTextBox1.Text);
            writer.Close();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfg = new SaveFileDialog();
            sfg.Filter = "Archivos de texto(*.txt)|*.txt| Todos los archivos(*.*)|*.*";
            sfg.FilterIndex = 1;
            sfg.FileName = "Default.txt";

            if (sfg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(sfg.FileName);

                writer.Write(this.richTextBox1.Text);
                writer.Close();
            }
            else
            {
                return;
            }

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt| Todos los archivos(*.*)|*.*";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(openFileDialog.FileName);

                this.richTextBox1.Text = reader.ReadToEnd();
                reader.Close();
                this.lastPath = openFileDialog.FileName;
            }
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Caracteres: " + this.richTextBox1.Text.Length.ToString() ;
        }
     }
}
