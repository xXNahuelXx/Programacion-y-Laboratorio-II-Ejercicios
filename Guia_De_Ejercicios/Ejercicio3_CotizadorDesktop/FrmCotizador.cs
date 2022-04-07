using Billetes;
using System;
using System.Windows.Forms;

namespace Ejercicio3_CotizadorDesktop
{
    public partial class FrmCotizador : Form
    {
        private int flag = 0;
        public FrmCotizador()
        {
            InitializeComponent();
        }

        private void btnBlockCotiz_Click(object sender, EventArgs e)
        {
            if (this.flag == 0)
            {
                this.btnBlockCotiz.BackgroundImage = Properties.Resources.Candado_Cerrado;
                this.txtEuroCotiz.Enabled = false;
                this.txtDolarCotiz.Enabled = false;
                this.txtPesoCotiz.Enabled = false;
                this.flag = 1;
            }
            else
            {
                this.btnBlockCotiz.BackgroundImage = Properties.Resources.Candado_Abierto;
                this.txtEuroCotiz.Enabled = true;
                this.txtDolarCotiz.Enabled = true;
                this.txtPesoCotiz.Enabled = true;
                this.flag = 0;
            }

        }

        private void btnEuroConvertir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.txtEuroCotiz.Text) && !string.IsNullOrWhiteSpace(this.txtPesoCotiz.Text) &&
               !string.IsNullOrWhiteSpace(this.txtEuroCant.Text))
            {
                double euroDouble = Convert.ToDouble(txtEuroCant.Text);
                Euro euro = new Euro(euroDouble);
                Euro.SetCotizacion(Convert.ToDouble(this.txtEuroCotiz.Text));
                Dolar dolar = (Dolar)euro;
                Peso peso = (Peso)euro;
                this.txtEuroEuro.Text = this.txtEuroCant.Text;
                this.txtEuroDolar.Text = dolar.GetCantidad().ToString();
                this.txtEuroPeso.Text = peso.GetCantidad().ToString();
            }
        }

        private void btnDolarConvertir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.txtEuroCotiz.Text) && !string.IsNullOrWhiteSpace(this.txtPesoCotiz.Text) &&
               !string.IsNullOrWhiteSpace(this.txtEuroCant.Text))
            {
                double dolarDouble = Convert.ToDouble(txtDolarCant.Text);
                Dolar dolar = new Dolar(dolarDouble);
                Euro euro = (Euro)dolar;
                Peso peso = (Peso)dolar;
                this.txtDolarDolar.Text = this.txtDolarCant.Text;
                this.txtDolarEuro.Text = euro.GetCantidad().ToString();
                this.txtDolarPeso.Text = peso.GetCantidad().ToString();
            }
        }

        private void btnPesoConvertir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.txtEuroCotiz.Text) && !string.IsNullOrWhiteSpace(this.txtPesoCotiz.Text) &&
               !string.IsNullOrWhiteSpace(this.txtEuroCant.Text))
            {
                Peso.SetCotizacion(Convert.ToDouble(this.txtPesoCotiz.Text));
                double pesoDouble = Convert.ToDouble(txtPesoCant.Text);
                Peso peso = new Peso(pesoDouble);
                Dolar dolar = (Dolar)peso;
                Euro euro = (Euro)peso;
                this.txtPesoPeso.Text = this.txtPesoCant.Text;
                this.txtPesoDolar.Text = dolar.GetCantidad().ToString();
                this.txtPesoEuro.Text = euro.GetCantidad().ToString();
            }
        }
    }
}
