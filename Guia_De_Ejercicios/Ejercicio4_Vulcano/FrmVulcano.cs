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

namespace Ejercicio4_Vulcano
{
    public partial class FrmVulcano : Form
    {
        public FrmVulcano()
        {
            InitializeComponent();
        }

        private void btnFahrConversor_Click(object sender, EventArgs e)
        {
            double fharDouble = Convert.ToDouble(txtFahrTemp.Text);            
            Fahrenheit f = new Fahrenheit(fharDouble);
            Celsius c = (Celsius)f;
            Kelvin k = (Kelvin)f;
            this.txtFahrFahr.Text = this.txtFahrTemp.Text;
            this.txtFahrCelsius.Text = c.GetValorCelsius().ToString();
            this.txtFahrKelvin.Text = k.GetValorKelvin().ToString();
        }

        private void btnCelsiusConversor_Click(object sender, EventArgs e)
        {
            double celsiusDouble = Convert.ToDouble(this.txtCelsiusTemp.Text);
            Celsius c = new Celsius(celsiusDouble);
            Fahrenheit f = (Fahrenheit)c;
            Kelvin k = (Kelvin)f;
            this.txtCelsiusCelsius.Text = this.txtCelsiusTemp.Text;
            this.txtCelsiusFahr.Text = f.GetValorFahrenheit().ToString();   
            this.txtCelsiusKelvin.Text = k.GetValorKelvin().ToString();
        }

        private void btnKelvinConversor_Click(object sender, EventArgs e)
        {
            double kelvinDouble = Convert.ToDouble(this.txtKelvinTemp.Text);
            Kelvin k = new Kelvin(kelvinDouble);
            Fahrenheit f = (Fahrenheit)k;
            Celsius c = (Celsius)f;
            this.txtKelvinKelvin.Text = this.txtKelvinTemp.Text;
            this.txtKelvinFahr.Text = f.GetValorFahrenheit().ToString();
            this.txtKelvinCelsius.Text = c.GetValorCelsius().ToString();
        }
    }
}
