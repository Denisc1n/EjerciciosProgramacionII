using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Ejercicio63
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AsignarHora(sender, e);
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(AsignarHora);
            timer.Start();
        }

   
        public void AsignarHora( object  args, EventArgs e )
        {
           this.lblHora.Text =  DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
        }
    }
}
