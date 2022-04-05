using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_HolaWindowsForms
{
    public partial class FrmHelloWinForms : Form
    {
        public FrmHelloWinForms()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            FrmSaludo frmSaludo = new FrmSaludo($"Soy {this.txtNombre.Text} {this.txtApellido.Text} y mi materia favorita es {cmbMaterias.Text}");
            frmSaludo.ShowDialog();
        }

        private void FrmHelloWinForms_Load(object sender, EventArgs e)
        {
            this.cmbMaterias.Items.Add("Programacion II");
            this.cmbMaterias.Items.Add("Laboratorio II");
            this.cmbMaterias.SelectedIndex = 0;
        }
    }
}
