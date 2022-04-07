using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3_AContarPalabras
{
    public partial class FrmContador : Form
    {
        public FrmContador()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Dictionary<string,int> diccionarioPalabras = new Dictionary<string,int>();
            foreach (string palabra in this.rchText.Text.Split('\0'))
            {
                if(!diccionarioPalabras.ContainsKey(palabra))
                {
                    diccionarioPalabras.Add(palabra, 1);
                  
                }
                else
                {
                    diccionarioPalabras[palabra] += 1;
                }
            }

            foreach(int valor in diccionarioPalabras.Values)
            {

            }
        }
    }
}
