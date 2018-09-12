namespace Ejercicio23
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbEuro = new System.Windows.Forms.Label();
            this.lbDolar = new System.Windows.Forms.Label();
            this.lbPeso = new System.Windows.Forms.Label();
            this.lbEuroResultado = new System.Windows.Forms.Label();
            this.lbDolarResultado = new System.Windows.Forms.Label();
            this.lbPesoResultado = new System.Windows.Forms.Label();
            this.txtInputEuro = new System.Windows.Forms.TextBox();
            this.txtInputDolar = new System.Windows.Forms.TextBox();
            this.txtInputPeso = new System.Windows.Forms.TextBox();
            this.txtEuroAEuro = new System.Windows.Forms.TextBox();
            this.txtDolarAeuro = new System.Windows.Forms.TextBox();
            this.txtPesoAeuro = new System.Windows.Forms.TextBox();
            this.txtEuroADolar = new System.Windows.Forms.TextBox();
            this.txtDolarAdolar = new System.Windows.Forms.TextBox();
            this.txtPesoAdolar = new System.Windows.Forms.TextBox();
            this.txtEuroAPeso = new System.Windows.Forms.TextBox();
            this.txtDolarApeso = new System.Windows.Forms.TextBox();
            this.txtPesoApeso = new System.Windows.Forms.TextBox();
            this.btnConvEuro = new System.Windows.Forms.Button();
            this.btnConvDolar = new System.Windows.Forms.Button();
            this.btnConvPeso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbEuro
            // 
            this.lbEuro.AutoSize = true;
            this.lbEuro.Location = new System.Drawing.Point(26, 65);
            this.lbEuro.Name = "lbEuro";
            this.lbEuro.Size = new System.Drawing.Size(29, 13);
            this.lbEuro.TabIndex = 0;
            this.lbEuro.Text = "Euro";
            // 
            // lbDolar
            // 
            this.lbDolar.AutoSize = true;
            this.lbDolar.Location = new System.Drawing.Point(26, 100);
            this.lbDolar.Name = "lbDolar";
            this.lbDolar.Size = new System.Drawing.Size(32, 13);
            this.lbDolar.TabIndex = 1;
            this.lbDolar.Text = "Dolar";
            // 
            // lbPeso
            // 
            this.lbPeso.AutoSize = true;
            this.lbPeso.Location = new System.Drawing.Point(26, 134);
            this.lbPeso.Name = "lbPeso";
            this.lbPeso.Size = new System.Drawing.Size(31, 13);
            this.lbPeso.TabIndex = 2;
            this.lbPeso.Text = "Peso";
            // 
            // lbEuroResultado
            // 
            this.lbEuroResultado.AutoSize = true;
            this.lbEuroResultado.Location = new System.Drawing.Point(371, 36);
            this.lbEuroResultado.Name = "lbEuroResultado";
            this.lbEuroResultado.Size = new System.Drawing.Size(29, 13);
            this.lbEuroResultado.TabIndex = 3;
            this.lbEuroResultado.Text = "Euro";
            // 
            // lbDolarResultado
            // 
            this.lbDolarResultado.AutoSize = true;
            this.lbDolarResultado.Location = new System.Drawing.Point(470, 36);
            this.lbDolarResultado.Name = "lbDolarResultado";
            this.lbDolarResultado.Size = new System.Drawing.Size(32, 13);
            this.lbDolarResultado.TabIndex = 4;
            this.lbDolarResultado.Text = "Dolar";
            // 
            // lbPesoResultado
            // 
            this.lbPesoResultado.AutoSize = true;
            this.lbPesoResultado.Location = new System.Drawing.Point(587, 36);
            this.lbPesoResultado.Name = "lbPesoResultado";
            this.lbPesoResultado.Size = new System.Drawing.Size(31, 13);
            this.lbPesoResultado.TabIndex = 5;
            this.lbPesoResultado.Text = "Peso";
            // 
            // txtInputEuro
            // 
            this.txtInputEuro.Location = new System.Drawing.Point(114, 65);
            this.txtInputEuro.Name = "txtInputEuro";
            this.txtInputEuro.Size = new System.Drawing.Size(100, 20);
            this.txtInputEuro.TabIndex = 6;
            this.txtInputEuro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInputEuro_KeyPress);
            // 
            // txtInputDolar
            // 
            this.txtInputDolar.Location = new System.Drawing.Point(114, 97);
            this.txtInputDolar.Name = "txtInputDolar";
            this.txtInputDolar.Size = new System.Drawing.Size(100, 20);
            this.txtInputDolar.TabIndex = 7;
            this.txtInputDolar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInputDolar_KeyPress);
            // 
            // txtInputPeso
            // 
            this.txtInputPeso.Location = new System.Drawing.Point(114, 127);
            this.txtInputPeso.Name = "txtInputPeso";
            this.txtInputPeso.Size = new System.Drawing.Size(100, 20);
            this.txtInputPeso.TabIndex = 8;
            this.txtInputPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInputPeso_KeyPress);
            // 
            // txtEuroAEuro
            // 
            this.txtEuroAEuro.Location = new System.Drawing.Point(346, 65);
            this.txtEuroAEuro.Name = "txtEuroAEuro";
            this.txtEuroAEuro.Size = new System.Drawing.Size(100, 20);
            this.txtEuroAEuro.TabIndex = 9;
            // 
            // txtDolarAeuro
            // 
            this.txtDolarAeuro.Location = new System.Drawing.Point(346, 97);
            this.txtDolarAeuro.Name = "txtDolarAeuro";
            this.txtDolarAeuro.Size = new System.Drawing.Size(100, 20);
            this.txtDolarAeuro.TabIndex = 10;
            // 
            // txtPesoAeuro
            // 
            this.txtPesoAeuro.Location = new System.Drawing.Point(346, 127);
            this.txtPesoAeuro.Name = "txtPesoAeuro";
            this.txtPesoAeuro.Size = new System.Drawing.Size(100, 20);
            this.txtPesoAeuro.TabIndex = 11;
            // 
            // txtEuroADolar
            // 
            this.txtEuroADolar.Location = new System.Drawing.Point(452, 65);
            this.txtEuroADolar.Name = "txtEuroADolar";
            this.txtEuroADolar.Size = new System.Drawing.Size(100, 20);
            this.txtEuroADolar.TabIndex = 12;
            // 
            // txtDolarAdolar
            // 
            this.txtDolarAdolar.Location = new System.Drawing.Point(452, 97);
            this.txtDolarAdolar.Name = "txtDolarAdolar";
            this.txtDolarAdolar.Size = new System.Drawing.Size(100, 20);
            this.txtDolarAdolar.TabIndex = 13;
            // 
            // txtPesoAdolar
            // 
            this.txtPesoAdolar.Location = new System.Drawing.Point(452, 127);
            this.txtPesoAdolar.Name = "txtPesoAdolar";
            this.txtPesoAdolar.Size = new System.Drawing.Size(100, 20);
            this.txtPesoAdolar.TabIndex = 14;
            // 
            // txtEuroAPeso
            // 
            this.txtEuroAPeso.Location = new System.Drawing.Point(558, 65);
            this.txtEuroAPeso.Name = "txtEuroAPeso";
            this.txtEuroAPeso.Size = new System.Drawing.Size(100, 20);
            this.txtEuroAPeso.TabIndex = 15;
            // 
            // txtDolarApeso
            // 
            this.txtDolarApeso.Location = new System.Drawing.Point(558, 97);
            this.txtDolarApeso.Name = "txtDolarApeso";
            this.txtDolarApeso.Size = new System.Drawing.Size(100, 20);
            this.txtDolarApeso.TabIndex = 16;
            // 
            // txtPesoApeso
            // 
            this.txtPesoApeso.Location = new System.Drawing.Point(558, 127);
            this.txtPesoApeso.Name = "txtPesoApeso";
            this.txtPesoApeso.Size = new System.Drawing.Size(100, 20);
            this.txtPesoApeso.TabIndex = 17;
            // 
            // btnConvEuro
            // 
            this.btnConvEuro.Location = new System.Drawing.Point(228, 63);
            this.btnConvEuro.Name = "btnConvEuro";
            this.btnConvEuro.Size = new System.Drawing.Size(97, 23);
            this.btnConvEuro.TabIndex = 18;
            this.btnConvEuro.Text = "-->";
            this.btnConvEuro.UseVisualStyleBackColor = true;
            this.btnConvEuro.Click += new System.EventHandler(this.btnConvEuro_Click);
            // 
            // btnConvDolar
            // 
            this.btnConvDolar.Location = new System.Drawing.Point(228, 95);
            this.btnConvDolar.Name = "btnConvDolar";
            this.btnConvDolar.Size = new System.Drawing.Size(97, 23);
            this.btnConvDolar.TabIndex = 19;
            this.btnConvDolar.Text = "-->";
            this.btnConvDolar.UseVisualStyleBackColor = true;
            this.btnConvDolar.Click += new System.EventHandler(this.btnConvDolar_Click);
            // 
            // btnConvPeso
            // 
            this.btnConvPeso.Location = new System.Drawing.Point(228, 129);
            this.btnConvPeso.Name = "btnConvPeso";
            this.btnConvPeso.Size = new System.Drawing.Size(97, 23);
            this.btnConvPeso.TabIndex = 20;
            this.btnConvPeso.Text = "-->";
            this.btnConvPeso.UseVisualStyleBackColor = true;
            this.btnConvPeso.Click += new System.EventHandler(this.btnConvPeso_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 167);
            this.Controls.Add(this.btnConvPeso);
            this.Controls.Add(this.btnConvDolar);
            this.Controls.Add(this.btnConvEuro);
            this.Controls.Add(this.txtPesoApeso);
            this.Controls.Add(this.txtDolarApeso);
            this.Controls.Add(this.txtEuroAPeso);
            this.Controls.Add(this.txtPesoAdolar);
            this.Controls.Add(this.txtDolarAdolar);
            this.Controls.Add(this.txtEuroADolar);
            this.Controls.Add(this.txtPesoAeuro);
            this.Controls.Add(this.txtDolarAeuro);
            this.Controls.Add(this.txtEuroAEuro);
            this.Controls.Add(this.txtInputPeso);
            this.Controls.Add(this.txtInputDolar);
            this.Controls.Add(this.txtInputEuro);
            this.Controls.Add(this.lbPesoResultado);
            this.Controls.Add(this.lbDolarResultado);
            this.Controls.Add(this.lbEuroResultado);
            this.Controls.Add(this.lbPeso);
            this.Controls.Add(this.lbDolar);
            this.Controls.Add(this.lbEuro);
            this.Name = "Form1";
            this.Text = "Conversor de Moneda";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEuro;
        private System.Windows.Forms.Label lbDolar;
        private System.Windows.Forms.Label lbPeso;
        private System.Windows.Forms.Label lbEuroResultado;
        private System.Windows.Forms.Label lbDolarResultado;
        private System.Windows.Forms.Label lbPesoResultado;
        private System.Windows.Forms.TextBox txtInputEuro;
        private System.Windows.Forms.TextBox txtInputDolar;
        private System.Windows.Forms.TextBox txtInputPeso;
        private System.Windows.Forms.TextBox txtEuroAEuro;
        private System.Windows.Forms.TextBox txtDolarAeuro;
        private System.Windows.Forms.TextBox txtPesoAeuro;
        private System.Windows.Forms.TextBox txtEuroADolar;
        private System.Windows.Forms.TextBox txtDolarAdolar;
        private System.Windows.Forms.TextBox txtPesoAdolar;
        private System.Windows.Forms.TextBox txtEuroAPeso;
        private System.Windows.Forms.TextBox txtDolarApeso;
        private System.Windows.Forms.TextBox txtPesoApeso;
        private System.Windows.Forms.Button btnConvEuro;
        private System.Windows.Forms.Button btnConvDolar;
        private System.Windows.Forms.Button btnConvPeso;
    }
}

