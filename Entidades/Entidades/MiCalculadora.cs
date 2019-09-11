using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades
{
    public partial class MiCalculadora : Form
    {
        public MiCalculadora()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Numero uno = new Numero(textBox1.Text);
            Numero dos = new Numero(textBox2.Text);
            double resultado;
            resultado = Calculadora.Operar(uno, dos, comboBox1.Text);
            label1.Text = resultado.ToString();


        }
    }
}
