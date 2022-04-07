namespace Ejercicio2_Registrate
{
    partial class FrmRegistro
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
            this.gpbDetallesDelUsuario = new System.Windows.Forms.GroupBox();
            this.nupEdad = new System.Windows.Forms.NumericUpDown();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbGenero = new System.Windows.Forms.GroupBox();
            this.rdbNoDecirlo = new System.Windows.Forms.RadioButton();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.gpbCursos = new System.Windows.Forms.GroupBox();
            this.chkbJavaScript = new System.Windows.Forms.CheckBox();
            this.chkbCPlusPlus = new System.Windows.Forms.CheckBox();
            this.chkbCSharp = new System.Windows.Forms.CheckBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lbxPais = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gpbDetallesDelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupEdad)).BeginInit();
            this.gpbGenero.SuspendLayout();
            this.gpbCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDetallesDelUsuario
            // 
            this.gpbDetallesDelUsuario.Controls.Add(this.nupEdad);
            this.gpbDetallesDelUsuario.Controls.Add(this.txtDireccion);
            this.gpbDetallesDelUsuario.Controls.Add(this.txtNombre);
            this.gpbDetallesDelUsuario.Controls.Add(this.label3);
            this.gpbDetallesDelUsuario.Controls.Add(this.label2);
            this.gpbDetallesDelUsuario.Controls.Add(this.label1);
            this.gpbDetallesDelUsuario.Location = new System.Drawing.Point(12, 12);
            this.gpbDetallesDelUsuario.Name = "gpbDetallesDelUsuario";
            this.gpbDetallesDelUsuario.Size = new System.Drawing.Size(200, 136);
            this.gpbDetallesDelUsuario.TabIndex = 0;
            this.gpbDetallesDelUsuario.TabStop = false;
            this.gpbDetallesDelUsuario.Text = "Detalles del Usuario";
            // 
            // nupEdad
            // 
            this.nupEdad.Location = new System.Drawing.Point(81, 103);
            this.nupEdad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupEdad.Name = "nupEdad";
            this.nupEdad.Size = new System.Drawing.Size(100, 23);
            this.nupEdad.TabIndex = 5;
            this.nupEdad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(81, 64);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 23);
            this.txtDireccion.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(81, 24);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Direccion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // gpbGenero
            // 
            this.gpbGenero.Controls.Add(this.rdbNoDecirlo);
            this.gpbGenero.Controls.Add(this.rdbFemenino);
            this.gpbGenero.Controls.Add(this.rdbMasculino);
            this.gpbGenero.Location = new System.Drawing.Point(262, 12);
            this.gpbGenero.Name = "gpbGenero";
            this.gpbGenero.Size = new System.Drawing.Size(153, 100);
            this.gpbGenero.TabIndex = 1;
            this.gpbGenero.TabStop = false;
            this.gpbGenero.Text = "Género";
            // 
            // rdbNoDecirlo
            // 
            this.rdbNoDecirlo.AutoSize = true;
            this.rdbNoDecirlo.Location = new System.Drawing.Point(15, 72);
            this.rdbNoDecirlo.Name = "rdbNoDecirlo";
            this.rdbNoDecirlo.Size = new System.Drawing.Size(122, 19);
            this.rdbNoDecirlo.TabIndex = 2;
            this.rdbNoDecirlo.TabStop = true;
            this.rdbNoDecirlo.Text = "Prefiero no decirlo";
            this.rdbNoDecirlo.UseVisualStyleBackColor = true;
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Location = new System.Drawing.Point(15, 47);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(78, 19);
            this.rdbFemenino.TabIndex = 1;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(15, 22);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(80, 19);
            this.rdbMasculino.TabIndex = 0;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // gpbCursos
            // 
            this.gpbCursos.Controls.Add(this.chkbJavaScript);
            this.gpbCursos.Controls.Add(this.chkbCPlusPlus);
            this.gpbCursos.Controls.Add(this.chkbCSharp);
            this.gpbCursos.Location = new System.Drawing.Point(262, 132);
            this.gpbCursos.Name = "gpbCursos";
            this.gpbCursos.Size = new System.Drawing.Size(153, 100);
            this.gpbCursos.TabIndex = 2;
            this.gpbCursos.TabStop = false;
            this.gpbCursos.Text = "Cursos";
            // 
            // chkbJavaScript
            // 
            this.chkbJavaScript.AutoSize = true;
            this.chkbJavaScript.Location = new System.Drawing.Point(12, 72);
            this.chkbJavaScript.Name = "chkbJavaScript";
            this.chkbJavaScript.Size = new System.Drawing.Size(78, 19);
            this.chkbJavaScript.TabIndex = 2;
            this.chkbJavaScript.Text = "JavaScript";
            this.chkbJavaScript.UseVisualStyleBackColor = true;
            // 
            // chkbCPlusPlus
            // 
            this.chkbCPlusPlus.AutoSize = true;
            this.chkbCPlusPlus.Location = new System.Drawing.Point(12, 47);
            this.chkbCPlusPlus.Name = "chkbCPlusPlus";
            this.chkbCPlusPlus.Size = new System.Drawing.Size(50, 19);
            this.chkbCPlusPlus.TabIndex = 1;
            this.chkbCPlusPlus.Text = "C++";
            this.chkbCPlusPlus.UseVisualStyleBackColor = true;
            // 
            // chkbCSharp
            // 
            this.chkbCSharp.AutoSize = true;
            this.chkbCSharp.Location = new System.Drawing.Point(12, 22);
            this.chkbCSharp.Name = "chkbCSharp";
            this.chkbCSharp.Size = new System.Drawing.Size(41, 19);
            this.chkbCSharp.TabIndex = 0;
            this.chkbCSharp.Text = "C#";
            this.chkbCSharp.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(337, 253);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(78, 27);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lbxPais
            // 
            this.lbxPais.FormattingEnabled = true;
            this.lbxPais.ItemHeight = 15;
            this.lbxPais.Items.AddRange(new object[] {
            "Argentina ",
            "Chile",
            "Uruguay"});
            this.lbxPais.Location = new System.Drawing.Point(12, 179);
            this.lbxPais.Name = "lbxPais";
            this.lbxPais.Size = new System.Drawing.Size(200, 109);
            this.lbxPais.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "País";
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 301);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbxPais);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.gpbCursos);
            this.Controls.Add(this.gpbGenero);
            this.Controls.Add(this.gpbDetallesDelUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.gpbDetallesDelUsuario.ResumeLayout(false);
            this.gpbDetallesDelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupEdad)).EndInit();
            this.gpbGenero.ResumeLayout(false);
            this.gpbGenero.PerformLayout();
            this.gpbCursos.ResumeLayout(false);
            this.gpbCursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDetallesDelUsuario;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupEdad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.GroupBox gpbGenero;
        private System.Windows.Forms.RadioButton rdbNoDecirlo;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.GroupBox gpbCursos;
        private System.Windows.Forms.CheckBox chkbJavaScript;
        private System.Windows.Forms.CheckBox chkbCPlusPlus;
        private System.Windows.Forms.CheckBox chkbCSharp;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.ListBox lbxPais;
        private System.Windows.Forms.Label label4;
    }
}
