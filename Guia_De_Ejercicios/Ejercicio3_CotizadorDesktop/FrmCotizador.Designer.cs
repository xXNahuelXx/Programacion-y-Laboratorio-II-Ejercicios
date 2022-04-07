namespace Ejercicio3_CotizadorDesktop
{
    partial class FrmCotizador
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEuroCant = new System.Windows.Forms.TextBox();
            this.txtDolarCant = new System.Windows.Forms.TextBox();
            this.txtPesoCant = new System.Windows.Forms.TextBox();
            this.btnBlockCotiz = new System.Windows.Forms.Button();
            this.btnEuroConvertir = new System.Windows.Forms.Button();
            this.btnDolarConvertir = new System.Windows.Forms.Button();
            this.btnPesoConvertir = new System.Windows.Forms.Button();
            this.txtEuroCotiz = new System.Windows.Forms.TextBox();
            this.txtDolarCotiz = new System.Windows.Forms.TextBox();
            this.txtPesoCotiz = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEuroEuro = new System.Windows.Forms.TextBox();
            this.txtDolarEuro = new System.Windows.Forms.TextBox();
            this.txtPesoEuro = new System.Windows.Forms.TextBox();
            this.txtEuroDolar = new System.Windows.Forms.TextBox();
            this.txtDolarDolar = new System.Windows.Forms.TextBox();
            this.txtPesoDolar = new System.Windows.Forms.TextBox();
            this.txtEuroPeso = new System.Windows.Forms.TextBox();
            this.txtDolarPeso = new System.Windows.Forms.TextBox();
            this.txtPesoPeso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(84, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cotización";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Euro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dolar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Peso";
            // 
            // txtEuroCant
            // 
            this.txtEuroCant.Location = new System.Drawing.Point(84, 75);
            this.txtEuroCant.Name = "txtEuroCant";
            this.txtEuroCant.Size = new System.Drawing.Size(100, 23);
            this.txtEuroCant.TabIndex = 4;
            // 
            // txtDolarCant
            // 
            this.txtDolarCant.Location = new System.Drawing.Point(84, 112);
            this.txtDolarCant.Name = "txtDolarCant";
            this.txtDolarCant.Size = new System.Drawing.Size(100, 23);
            this.txtDolarCant.TabIndex = 5;
            // 
            // txtPesoCant
            // 
            this.txtPesoCant.Location = new System.Drawing.Point(84, 150);
            this.txtPesoCant.Name = "txtPesoCant";
            this.txtPesoCant.Size = new System.Drawing.Size(100, 23);
            this.txtPesoCant.TabIndex = 6;
            // 
            // btnBlockCotiz
            // 
            this.btnBlockCotiz.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBlockCotiz.BackgroundImage = global::Ejercicio3_CotizadorDesktop.Properties.Resources.Candado_Abierto;
            this.btnBlockCotiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBlockCotiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlockCotiz.Location = new System.Drawing.Point(190, 6);
            this.btnBlockCotiz.Name = "btnBlockCotiz";
            this.btnBlockCotiz.Size = new System.Drawing.Size(84, 35);
            this.btnBlockCotiz.TabIndex = 7;
            this.btnBlockCotiz.UseVisualStyleBackColor = false;
            this.btnBlockCotiz.Click += new System.EventHandler(this.btnBlockCotiz_Click);
            // 
            // btnEuroConvertir
            // 
            this.btnEuroConvertir.Location = new System.Drawing.Point(190, 74);
            this.btnEuroConvertir.Name = "btnEuroConvertir";
            this.btnEuroConvertir.Size = new System.Drawing.Size(84, 23);
            this.btnEuroConvertir.TabIndex = 8;
            this.btnEuroConvertir.Text = "->";
            this.btnEuroConvertir.UseVisualStyleBackColor = true;
            this.btnEuroConvertir.Click += new System.EventHandler(this.btnEuroConvertir_Click);
            // 
            // btnDolarConvertir
            // 
            this.btnDolarConvertir.Location = new System.Drawing.Point(190, 111);
            this.btnDolarConvertir.Name = "btnDolarConvertir";
            this.btnDolarConvertir.Size = new System.Drawing.Size(84, 24);
            this.btnDolarConvertir.TabIndex = 9;
            this.btnDolarConvertir.Text = "->";
            this.btnDolarConvertir.UseVisualStyleBackColor = true;
            this.btnDolarConvertir.Click += new System.EventHandler(this.btnDolarConvertir_Click);
            // 
            // btnPesoConvertir
            // 
            this.btnPesoConvertir.Location = new System.Drawing.Point(190, 150);
            this.btnPesoConvertir.Name = "btnPesoConvertir";
            this.btnPesoConvertir.Size = new System.Drawing.Size(84, 23);
            this.btnPesoConvertir.TabIndex = 10;
            this.btnPesoConvertir.Text = "->";
            this.btnPesoConvertir.UseVisualStyleBackColor = true;
            this.btnPesoConvertir.Click += new System.EventHandler(this.btnPesoConvertir_Click);
            // 
            // txtEuroCotiz
            // 
            this.txtEuroCotiz.Location = new System.Drawing.Point(296, 13);
            this.txtEuroCotiz.Name = "txtEuroCotiz";
            this.txtEuroCotiz.Size = new System.Drawing.Size(100, 23);
            this.txtEuroCotiz.TabIndex = 11;
            // 
            // txtDolarCotiz
            // 
            this.txtDolarCotiz.Location = new System.Drawing.Point(402, 13);
            this.txtDolarCotiz.Name = "txtDolarCotiz";
            this.txtDolarCotiz.Size = new System.Drawing.Size(100, 23);
            this.txtDolarCotiz.TabIndex = 12;
            this.txtDolarCotiz.Text = "1";
            // 
            // txtPesoCotiz
            // 
            this.txtPesoCotiz.Location = new System.Drawing.Point(508, 13);
            this.txtPesoCotiz.Name = "txtPesoCotiz";
            this.txtPesoCotiz.Size = new System.Drawing.Size(100, 23);
            this.txtPesoCotiz.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(321, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Euro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(429, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Dolar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(539, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "Peso";
            // 
            // txtEuroEuro
            // 
            this.txtEuroEuro.Enabled = false;
            this.txtEuroEuro.Location = new System.Drawing.Point(296, 75);
            this.txtEuroEuro.Name = "txtEuroEuro";
            this.txtEuroEuro.Size = new System.Drawing.Size(100, 23);
            this.txtEuroEuro.TabIndex = 17;
            // 
            // txtDolarEuro
            // 
            this.txtDolarEuro.Enabled = false;
            this.txtDolarEuro.Location = new System.Drawing.Point(296, 111);
            this.txtDolarEuro.Name = "txtDolarEuro";
            this.txtDolarEuro.Size = new System.Drawing.Size(100, 23);
            this.txtDolarEuro.TabIndex = 18;
            // 
            // txtPesoEuro
            // 
            this.txtPesoEuro.Enabled = false;
            this.txtPesoEuro.Location = new System.Drawing.Point(296, 150);
            this.txtPesoEuro.Name = "txtPesoEuro";
            this.txtPesoEuro.Size = new System.Drawing.Size(100, 23);
            this.txtPesoEuro.TabIndex = 19;
            // 
            // txtEuroDolar
            // 
            this.txtEuroDolar.Enabled = false;
            this.txtEuroDolar.Location = new System.Drawing.Point(402, 75);
            this.txtEuroDolar.Name = "txtEuroDolar";
            this.txtEuroDolar.Size = new System.Drawing.Size(100, 23);
            this.txtEuroDolar.TabIndex = 20;
            // 
            // txtDolarDolar
            // 
            this.txtDolarDolar.Enabled = false;
            this.txtDolarDolar.Location = new System.Drawing.Point(402, 111);
            this.txtDolarDolar.Name = "txtDolarDolar";
            this.txtDolarDolar.Size = new System.Drawing.Size(100, 23);
            this.txtDolarDolar.TabIndex = 21;
            // 
            // txtPesoDolar
            // 
            this.txtPesoDolar.Enabled = false;
            this.txtPesoDolar.Location = new System.Drawing.Point(402, 150);
            this.txtPesoDolar.Name = "txtPesoDolar";
            this.txtPesoDolar.Size = new System.Drawing.Size(100, 23);
            this.txtPesoDolar.TabIndex = 22;
            // 
            // txtEuroPeso
            // 
            this.txtEuroPeso.Enabled = false;
            this.txtEuroPeso.Location = new System.Drawing.Point(508, 75);
            this.txtEuroPeso.Name = "txtEuroPeso";
            this.txtEuroPeso.Size = new System.Drawing.Size(100, 23);
            this.txtEuroPeso.TabIndex = 23;
            // 
            // txtDolarPeso
            // 
            this.txtDolarPeso.Enabled = false;
            this.txtDolarPeso.Location = new System.Drawing.Point(508, 111);
            this.txtDolarPeso.Name = "txtDolarPeso";
            this.txtDolarPeso.Size = new System.Drawing.Size(100, 23);
            this.txtDolarPeso.TabIndex = 24;
            // 
            // txtPesoPeso
            // 
            this.txtPesoPeso.Enabled = false;
            this.txtPesoPeso.Location = new System.Drawing.Point(508, 150);
            this.txtPesoPeso.Name = "txtPesoPeso";
            this.txtPesoPeso.Size = new System.Drawing.Size(100, 23);
            this.txtPesoPeso.TabIndex = 25;
            // 
            // FrmCotizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 191);
            this.Controls.Add(this.txtPesoPeso);
            this.Controls.Add(this.txtDolarPeso);
            this.Controls.Add(this.txtEuroPeso);
            this.Controls.Add(this.txtPesoDolar);
            this.Controls.Add(this.txtDolarDolar);
            this.Controls.Add(this.txtEuroDolar);
            this.Controls.Add(this.txtPesoEuro);
            this.Controls.Add(this.txtDolarEuro);
            this.Controls.Add(this.txtEuroEuro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPesoCotiz);
            this.Controls.Add(this.txtDolarCotiz);
            this.Controls.Add(this.txtEuroCotiz);
            this.Controls.Add(this.btnPesoConvertir);
            this.Controls.Add(this.btnDolarConvertir);
            this.Controls.Add(this.btnEuroConvertir);
            this.Controls.Add(this.btnBlockCotiz);
            this.Controls.Add(this.txtPesoCant);
            this.Controls.Add(this.txtDolarCant);
            this.Controls.Add(this.txtEuroCant);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCotizador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEuroCant;
        private System.Windows.Forms.TextBox txtDolarCant;
        private System.Windows.Forms.TextBox txtPesoCant;
        private System.Windows.Forms.Button btnBlockCotiz;
        private System.Windows.Forms.Button btnEuroConvertir;
        private System.Windows.Forms.Button btnDolarConvertir;
        private System.Windows.Forms.Button btnPesoConvertir;
        private System.Windows.Forms.TextBox txtEuroCotiz;
        private System.Windows.Forms.TextBox txtDolarCotiz;
        private System.Windows.Forms.TextBox txtPesoCotiz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEuroEuro;
        private System.Windows.Forms.TextBox txtDolarEuro;
        private System.Windows.Forms.TextBox txtPesoEuro;
        private System.Windows.Forms.TextBox txtEuroDolar;
        private System.Windows.Forms.TextBox txtDolarDolar;
        private System.Windows.Forms.TextBox txtPesoDolar;
        private System.Windows.Forms.TextBox txtEuroPeso;
        private System.Windows.Forms.TextBox txtDolarPeso;
        private System.Windows.Forms.TextBox txtPesoPeso;
    }
}
