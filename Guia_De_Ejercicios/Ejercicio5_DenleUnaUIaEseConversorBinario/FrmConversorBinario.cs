using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades_Clase4;

namespace Ejercicio5_DenleUnaUIaEseConversorBinario
{
    public partial class FrmConversorBinario : Form
    {
        public FrmConversorBinario()
        {
            InitializeComponent();
        }

        private void btnBinaDec_Click(object sender, EventArgs e)
        {
            int _decimal=Conversor.ConvertirBinarioADecimal(this.txtBinNum.Text);
            this.txtResultadoDec.Text = _decimal.ToString();
        }

        private void btnDecBin_Click(object sender, EventArgs e)
        {
            int _decimal;
            int.TryParse(this.txtDecNum.Text, out _decimal);
            this.txtResultadoBin.Text=Conversor.ConvertirDecimalABinario(_decimal);
        }
    }
}
