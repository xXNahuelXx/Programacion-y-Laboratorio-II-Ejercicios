using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades_Clase5;

namespace Ejercicio2_Registrate
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string[] cursosCheckeados = new string[3];
            RadioButton rb = null;

            if(this.chkbCSharp.Checked == true)
            {
                cursosCheckeados[0] = this.chkbCSharp.Text;
            }

            if (this.chkbCPlusPlus.Checked == true)
            {
                cursosCheckeados[1] = this.chkbCPlusPlus.Text;
            }

            if (this.chkbJavaScript.Checked == true)
            {
                cursosCheckeados[2] = this.chkbJavaScript.Text;
            }

            if(this.rdbMasculino.Checked == true)
            {
                rb = this.rdbMasculino;
            }

            if (this.rdbFemenino.Checked == true)
            {
                rb = this.rdbFemenino;
            }

            if (this.rdbNoDecirlo.Checked == true)
            {
                rb = this.rdbNoDecirlo;
            }

            Ingresante ingresante = new Ingresante(this.txtNombre.Text,this.txtDireccion.Text,rb.Text,this.lbxPais.Text,cursosCheckeados,(int)this.nupEdad.Value);

            MessageBox.Show(ingresante.Mostrar());
        }
    }
}
