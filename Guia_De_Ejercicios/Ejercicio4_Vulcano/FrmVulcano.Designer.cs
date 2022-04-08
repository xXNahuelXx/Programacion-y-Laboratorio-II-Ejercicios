namespace Ejercicio4_Vulcano
{
    partial class FrmVulcano
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
            this.txtFahrTemp = new System.Windows.Forms.TextBox();
            this.txtCelsiusTemp = new System.Windows.Forms.TextBox();
            this.txtKelvinTemp = new System.Windows.Forms.TextBox();
            this.btnFahrConversor = new System.Windows.Forms.Button();
            this.btnCelsiusConversor = new System.Windows.Forms.Button();
            this.btnKelvinConversor = new System.Windows.Forms.Button();
            this.txtFahrFahr = new System.Windows.Forms.TextBox();
            this.txtFahrCelsius = new System.Windows.Forms.TextBox();
            this.txtFahrKelvin = new System.Windows.Forms.TextBox();
            this.txtCelsiusFahr = new System.Windows.Forms.TextBox();
            this.txtCelsiusCelsius = new System.Windows.Forms.TextBox();
            this.txtCelsiusKelvin = new System.Windows.Forms.TextBox();
            this.txtKelvinFahr = new System.Windows.Forms.TextBox();
            this.txtKelvinCelsius = new System.Windows.Forms.TextBox();
            this.txtKelvinKelvin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fahrenheit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Celsius";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kelvin";
            // 
            // txtFahrTemp
            // 
            this.txtFahrTemp.Location = new System.Drawing.Point(152, 41);
            this.txtFahrTemp.Name = "txtFahrTemp";
            this.txtFahrTemp.Size = new System.Drawing.Size(100, 23);
            this.txtFahrTemp.TabIndex = 3;
            // 
            // txtCelsiusTemp
            // 
            this.txtCelsiusTemp.Location = new System.Drawing.Point(152, 87);
            this.txtCelsiusTemp.Name = "txtCelsiusTemp";
            this.txtCelsiusTemp.Size = new System.Drawing.Size(100, 23);
            this.txtCelsiusTemp.TabIndex = 4;
            // 
            // txtKelvinTemp
            // 
            this.txtKelvinTemp.Location = new System.Drawing.Point(152, 127);
            this.txtKelvinTemp.Name = "txtKelvinTemp";
            this.txtKelvinTemp.Size = new System.Drawing.Size(100, 23);
            this.txtKelvinTemp.TabIndex = 5;
            // 
            // btnFahrConversor
            // 
            this.btnFahrConversor.Location = new System.Drawing.Point(258, 41);
            this.btnFahrConversor.Name = "btnFahrConversor";
            this.btnFahrConversor.Size = new System.Drawing.Size(87, 23);
            this.btnFahrConversor.TabIndex = 6;
            this.btnFahrConversor.Text = "->";
            this.btnFahrConversor.UseVisualStyleBackColor = true;
            this.btnFahrConversor.Click += new System.EventHandler(this.btnFahrConversor_Click);
            // 
            // btnCelsiusConversor
            // 
            this.btnCelsiusConversor.Location = new System.Drawing.Point(258, 85);
            this.btnCelsiusConversor.Name = "btnCelsiusConversor";
            this.btnCelsiusConversor.Size = new System.Drawing.Size(87, 25);
            this.btnCelsiusConversor.TabIndex = 7;
            this.btnCelsiusConversor.Text = "->";
            this.btnCelsiusConversor.UseVisualStyleBackColor = true;
            this.btnCelsiusConversor.Click += new System.EventHandler(this.btnCelsiusConversor_Click);
            // 
            // btnKelvinConversor
            // 
            this.btnKelvinConversor.Location = new System.Drawing.Point(258, 127);
            this.btnKelvinConversor.Name = "btnKelvinConversor";
            this.btnKelvinConversor.Size = new System.Drawing.Size(87, 23);
            this.btnKelvinConversor.TabIndex = 8;
            this.btnKelvinConversor.Text = "->";
            this.btnKelvinConversor.UseVisualStyleBackColor = true;
            this.btnKelvinConversor.Click += new System.EventHandler(this.btnKelvinConversor_Click);
            // 
            // txtFahrFahr
            // 
            this.txtFahrFahr.Enabled = false;
            this.txtFahrFahr.Location = new System.Drawing.Point(351, 40);
            this.txtFahrFahr.Name = "txtFahrFahr";
            this.txtFahrFahr.Size = new System.Drawing.Size(100, 23);
            this.txtFahrFahr.TabIndex = 9;
            // 
            // txtFahrCelsius
            // 
            this.txtFahrCelsius.Enabled = false;
            this.txtFahrCelsius.Location = new System.Drawing.Point(457, 40);
            this.txtFahrCelsius.Name = "txtFahrCelsius";
            this.txtFahrCelsius.Size = new System.Drawing.Size(100, 23);
            this.txtFahrCelsius.TabIndex = 10;
            // 
            // txtFahrKelvin
            // 
            this.txtFahrKelvin.Enabled = false;
            this.txtFahrKelvin.Location = new System.Drawing.Point(563, 40);
            this.txtFahrKelvin.Name = "txtFahrKelvin";
            this.txtFahrKelvin.Size = new System.Drawing.Size(100, 23);
            this.txtFahrKelvin.TabIndex = 11;
            // 
            // txtCelsiusFahr
            // 
            this.txtCelsiusFahr.Enabled = false;
            this.txtCelsiusFahr.Location = new System.Drawing.Point(351, 87);
            this.txtCelsiusFahr.Name = "txtCelsiusFahr";
            this.txtCelsiusFahr.Size = new System.Drawing.Size(100, 23);
            this.txtCelsiusFahr.TabIndex = 12;
            // 
            // txtCelsiusCelsius
            // 
            this.txtCelsiusCelsius.Enabled = false;
            this.txtCelsiusCelsius.Location = new System.Drawing.Point(457, 87);
            this.txtCelsiusCelsius.Name = "txtCelsiusCelsius";
            this.txtCelsiusCelsius.Size = new System.Drawing.Size(100, 23);
            this.txtCelsiusCelsius.TabIndex = 13;
            // 
            // txtCelsiusKelvin
            // 
            this.txtCelsiusKelvin.Enabled = false;
            this.txtCelsiusKelvin.Location = new System.Drawing.Point(563, 87);
            this.txtCelsiusKelvin.Name = "txtCelsiusKelvin";
            this.txtCelsiusKelvin.Size = new System.Drawing.Size(100, 23);
            this.txtCelsiusKelvin.TabIndex = 14;
            // 
            // txtKelvinFahr
            // 
            this.txtKelvinFahr.Enabled = false;
            this.txtKelvinFahr.Location = new System.Drawing.Point(351, 127);
            this.txtKelvinFahr.Name = "txtKelvinFahr";
            this.txtKelvinFahr.Size = new System.Drawing.Size(100, 23);
            this.txtKelvinFahr.TabIndex = 15;
            // 
            // txtKelvinCelsius
            // 
            this.txtKelvinCelsius.Enabled = false;
            this.txtKelvinCelsius.Location = new System.Drawing.Point(457, 127);
            this.txtKelvinCelsius.Name = "txtKelvinCelsius";
            this.txtKelvinCelsius.Size = new System.Drawing.Size(100, 23);
            this.txtKelvinCelsius.TabIndex = 16;
            // 
            // txtKelvinKelvin
            // 
            this.txtKelvinKelvin.Enabled = false;
            this.txtKelvinKelvin.Location = new System.Drawing.Point(563, 127);
            this.txtKelvinKelvin.Name = "txtKelvinKelvin";
            this.txtKelvinKelvin.Size = new System.Drawing.Size(100, 23);
            this.txtKelvinKelvin.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(351, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Fahrenheit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(474, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "Celsius";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(581, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "Kelvin";
            // 
            // FrmVulcano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 165);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKelvinKelvin);
            this.Controls.Add(this.txtKelvinCelsius);
            this.Controls.Add(this.txtKelvinFahr);
            this.Controls.Add(this.txtCelsiusKelvin);
            this.Controls.Add(this.txtCelsiusCelsius);
            this.Controls.Add(this.txtCelsiusFahr);
            this.Controls.Add(this.txtFahrKelvin);
            this.Controls.Add(this.txtFahrCelsius);
            this.Controls.Add(this.txtFahrFahr);
            this.Controls.Add(this.btnKelvinConversor);
            this.Controls.Add(this.btnCelsiusConversor);
            this.Controls.Add(this.btnFahrConversor);
            this.Controls.Add(this.txtKelvinTemp);
            this.Controls.Add(this.txtCelsiusTemp);
            this.Controls.Add(this.txtFahrTemp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVulcano";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor Temperaturas ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFahrTemp;
        private System.Windows.Forms.TextBox txtCelsiusTemp;
        private System.Windows.Forms.TextBox txtKelvinTemp;
        private System.Windows.Forms.Button btnFahrConversor;
        private System.Windows.Forms.Button btnCelsiusConversor;
        private System.Windows.Forms.Button btnKelvinConversor;
        private System.Windows.Forms.TextBox txtFahrFahr;
        private System.Windows.Forms.TextBox txtFahrCelsius;
        private System.Windows.Forms.TextBox txtFahrKelvin;
        private System.Windows.Forms.TextBox txtCelsiusFahr;
        private System.Windows.Forms.TextBox txtCelsiusCelsius;
        private System.Windows.Forms.TextBox txtCelsiusKelvin;
        private System.Windows.Forms.TextBox txtKelvinFahr;
        private System.Windows.Forms.TextBox txtKelvinCelsius;
        private System.Windows.Forms.TextBox txtKelvinKelvin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
