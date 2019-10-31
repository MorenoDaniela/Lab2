using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_56
{
    public partial class Ej55 : Form
    {
        public Ej55()
        {
            InitializeComponent();
        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            EventoAbrir.ShowDialog();

        }

        private void BtnGuardarComo_Click(object sender, EventArgs e)
        {
            EventoGuardarComo.ShowDialog();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

        }
    }
}
