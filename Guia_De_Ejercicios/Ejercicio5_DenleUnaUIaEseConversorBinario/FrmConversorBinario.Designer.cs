namespace Ejercicio5_DenleUnaUIaEseConversorBinario
{
    partial class FrmConversorBinario
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
            this.txtBinNum = new System.Windows.Forms.TextBox();
            this.txtDecNum = new System.Windows.Forms.TextBox();
            this.btnBinaDec = new System.Windows.Forms.Button();
            this.btnDecBin = new System.Windows.Forms.Button();
            this.txtResultadoDec = new System.Windows.Forms.TextBox();
            this.txtResultadoBin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Binario a Decimal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Decimal a Binario";
            // 
            // txtBinNum
            // 
            this.txtBinNum.Location = new System.Drawing.Point(163, 34);
            this.txtBinNum.Name = "txtBinNum";
            this.txtBinNum.Size = new System.Drawing.Size(125, 23);
            this.txtBinNum.TabIndex = 2;
            // 
            // txtDecNum
            // 
            this.txtDecNum.Location = new System.Drawing.Point(163, 64);
            this.txtDecNum.Name = "txtDecNum";
            this.txtDecNum.Size = new System.Drawing.Size(125, 23);
            this.txtDecNum.TabIndex = 3;
            // 
            // btnBinaDec
            // 
            this.btnBinaDec.Location = new System.Drawing.Point(304, 34);
            this.btnBinaDec.Name = "btnBinaDec";
            this.btnBinaDec.Size = new System.Drawing.Size(101, 23);
            this.btnBinaDec.TabIndex = 4;
            this.btnBinaDec.Text = "->";
            this.btnBinaDec.UseVisualStyleBackColor = true;
            this.btnBinaDec.Click += new System.EventHandler(this.btnBinaDec_Click);
            // 
            // btnDecBin
            // 
            this.btnDecBin.Location = new System.Drawing.Point(304, 63);
            this.btnDecBin.Name = "btnDecBin";
            this.btnDecBin.Size = new System.Drawing.Size(101, 23);
            this.btnDecBin.TabIndex = 5;
            this.btnDecBin.Text = "->";
            this.btnDecBin.UseVisualStyleBackColor = true;
            this.btnDecBin.Click += new System.EventHandler(this.btnDecBin_Click);
            // 
            // txtResultadoDec
            // 
            this.txtResultadoDec.Location = new System.Drawing.Point(421, 34);
            this.txtResultadoDec.Name = "txtResultadoDec";
            this.txtResultadoDec.Size = new System.Drawing.Size(125, 23);
            this.txtResultadoDec.TabIndex = 6;
            // 
            // txtResultadoBin
            // 
            this.txtResultadoBin.Location = new System.Drawing.Point(421, 63);
            this.txtResultadoBin.Name = "txtResultadoBin";
            this.txtResultadoBin.Size = new System.Drawing.Size(125, 23);
            this.txtResultadoBin.TabIndex = 7;
            // 
            // FrmConversorBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 111);
            this.Controls.Add(this.txtResultadoBin);
            this.Controls.Add(this.txtResultadoDec);
            this.Controls.Add(this.btnDecBin);
            this.Controls.Add(this.btnBinaDec);
            this.Controls.Add(this.txtDecNum);
            this.Controls.Add(this.txtBinNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConversorBinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor Numérico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBinNum;
        private System.Windows.Forms.TextBox txtDecNum;
        private System.Windows.Forms.Button btnBinaDec;
        private System.Windows.Forms.Button btnDecBin;
        private System.Windows.Forms.TextBox txtResultadoDec;
        private System.Windows.Forms.TextBox txtResultadoBin;
    }
}
