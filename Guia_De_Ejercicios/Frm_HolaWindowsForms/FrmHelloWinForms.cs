using System;
using System.Text;
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
            if (Validar())
            {
                FrmSaludo frmSaludo = new FrmSaludo($"Soy {this.txtNombre.Text} {this.txtApellido.Text} y mi materia favorita es {cmbMaterias.Text}");
                frmSaludo.ShowDialog();
            }
        }

        private void FrmHelloWinForms_Load(object sender, EventArgs e)
        {
            this.cmbMaterias.Items.Add("Programacion II");
            this.cmbMaterias.Items.Add("Laboratorio II");
            this.cmbMaterias.SelectedIndex = 0;
        }

        private bool Validar()
        {
            bool esValido = true;
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Se deben completar los siguientes campos:");

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                esValido = false;
                stringBuilder.AppendLine("Nombre");
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                esValido = false;
                stringBuilder.AppendLine("Apellido");
            }

            if (!esValido)
            {
                MessageBox.Show(stringBuilder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return esValido;
        }
    }
}
