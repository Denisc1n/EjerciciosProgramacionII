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
        Thread miThread;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AsignarHora(sender, e);
            //System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            //timer.Interval = (1 * 1000);
            //timer.Tick += new EventHandler(AsignarHora);
            //timer.Start();
            miThread = new Thread(AsignarHoraThread);
            miThread.Start();
        }

   
        public void AsignarHora( object  args, EventArgs e )
        {
           this.lblHora.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
        }

        public void AsignarHoraThread()
        {
            while (true)
            {
                if (this.lblHora.InvokeRequired)
                {
                    this.lblHora.BeginInvoke((MethodInvoker)delegate ()
                    {
                        this.lblHora.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
                    });
                }
                Thread.Sleep(500);
            }
           
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            miThread.Abort();
        }
    }
}
