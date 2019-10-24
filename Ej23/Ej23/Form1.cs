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

namespace Ej23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double numero;
            double.TryParse(textBox1.Text, out numero);
            
            //Dolar d = new Dolar(numero);
            Euro eu = new Euro(numero);

            textBox7.Text = numero.ToString();
            textBox8.Text = ((Dolar)eu).GetCantidad().ToString();
            textBox9.Text = ((Peso)eu).GetCantidad().ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = Euro.GetCotizacion().ToString();
            textBox5.Text = Dolar.GetCotizacion().ToString();
            textBox6.Text = Peso.GetCotizacion().ToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double numero2;
            double.TryParse(textBox2.Text, out numero2);

            Euro euro = new Euro(numero2);
            Peso peso = new Peso(numero2);
            Dolar dolar = new Dolar(numero2);

            textBox11.Text = numero2.ToString();
            textBox10.Text = ((Euro)dolar).GetCantidad().ToString();
            textBox12.Text = ((Dolar)peso).GetCantidad().ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            double numero3;
            double.TryParse(textBox3.Text, out numero3);

            Euro euro = new Euro(numero3);
            Dolar dolar = new Dolar(numero3);
            Peso peso = new Peso(numero3);

            textBox15.Text = numero3.ToString();
            textBox13.Text = ((Euro)peso).GetCantidad().ToString();
            textBox14.Text = ((Dolar)peso).GetCantidad().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
