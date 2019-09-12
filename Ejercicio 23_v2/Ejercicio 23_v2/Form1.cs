using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moneda;

namespace Ejercicio_23_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botoneuro_Click(object sender, EventArgs e)
        {
            // EURO1.Text
            double numero;
            double.TryParse(EURO1.Text, out numero);
            Euro e1 = new Euro(numero);
            textBox13.Text =numero.ToString();
            
            Dolar d1 = new Dolar(numero);

            Peso p1 = new Peso();

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            double numero;
            double.TryParse(textBox13.Text, out numero);
            Euro nuevo = new Euro(numero);
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
