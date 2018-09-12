using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billetes;

namespace Ejercicio23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            foreach ( var item in this.Controls )
            {
                if (item.GetType() == typeof(TextBox) )
                {
                   TextBox aux =  item as TextBox;
                    if (!(aux.Name.Contains("Input")) )
                    {
                        aux.ReadOnly = true;
                    }
                }
            }
        }

        private void btnConvEuro_Click(object sender, EventArgs e)
        {
            double inputEuro = 0;
            double.TryParse(this.txtInputEuro.Text, out inputEuro);
            
            if (inputEuro == 0) return;

            Euro auxEuro = new Euro(inputEuro);
            this.txtEuroAEuro.Text = inputEuro.ToString();
            this.txtEuroADolar.Text = ((Dolar)auxEuro).GetCantidad().ToString();
            this.txtEuroAPeso.Text = ((Peso)auxEuro).GetCantidad().ToString();
        }

        private void btnConvDolar_Click(object sender, EventArgs e)
        {
            double inputDolar = 0;
            double.TryParse(this.txtInputDolar.Text, out inputDolar);

            if (inputDolar == 0) return;

            Dolar auxDolar = new Dolar(inputDolar);

            this.txtDolarAdolar.Text = auxDolar.GetCantidad().ToString();
            this.txtDolarAeuro.Text = ((Euro)auxDolar).GetCantidad().ToString();
            this.txtDolarApeso.Text = ((Peso)auxDolar).GetCantidad().ToString();
      
        }

        private void btnConvPeso_Click(object sender, EventArgs e)
        {
            double inputPeso = 0;
            double.TryParse(this.txtInputPeso.Text, out inputPeso);

            if (inputPeso == 0) return;

            Peso auxPeso = new Peso(inputPeso);

            this.txtPesoApeso.Text = auxPeso.GetCantidad().ToString();
            this.txtPesoAdolar.Text = ((Dolar)auxPeso).GetCantidad().ToString();
            this.txtPesoAeuro.Text = ((Euro)auxPeso).GetCantidad().ToString();
        }

        private void txtInputEuro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtInputDolar_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtInputEuro_KeyPress(sender, e);
        }

        private void txtInputPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtInputEuro_KeyPress(sender, e);
        }
    }
}
