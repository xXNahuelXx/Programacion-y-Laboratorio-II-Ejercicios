using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades_Clase10;

namespace Ejercicio2_AtrapameSiPuedes
{
    public partial class FrmCalculador : Form
    {
        public FrmCalculador()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int kilometros;
            int litros;
            float resultado;
            try
            {
                this.ValidarParametros(txtKilometros.Text,txtLitros.Text);
                kilometros=int.Parse(txtKilometros.Text);
                litros = int.Parse(txtLitros.Text);
                resultado=Calculador.Calcular(kilometros, litros);
                richTextBox1.Text= resultado.ToString();

            }
            catch (ParametrosVaciosException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(ArgumentNullException)
            {
                MessageBox.Show("Vacio");
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Desbordó");
            }
            catch(DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ValidarParametros(string text1,string text2)
        {
            if (string.IsNullOrEmpty(text1) || string.IsNullOrEmpty(text2))
            {
                throw new ParametrosVaciosException("Debe completar todos los campos");
            }
        }
    }
}
