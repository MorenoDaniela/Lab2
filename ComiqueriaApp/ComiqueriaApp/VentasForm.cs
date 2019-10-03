using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComiqueriaLogic;

namespace ComiqueriaApp
{
    public partial class VentasForm : Form
    {
        Comiqueria comic;
        Producto product;

        public VentasForm (Comiqueria c, Producto product)
        {
            InitializeComponent();
            this.comic = c;
            this.product = product;
        }

        private void VentasForm_Load(object sender, EventArgs e)
        {
            lblDescripcion.Text = product.Descripcion;
            numericUpDownCantidad.Minimum = 1;
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("Precio final: ${0}", product.Precio.ToString());
            lblPreciofinal.Text = cadena.ToString();
            
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NumericUpDownCantidad_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownCantidad.Minimum = 1;
            double auxiliar = (double)numericUpDownCantidad.Value;
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("Precio Final: ${0} ", product.Precio * (double)numericUpDownCantidad.Value);
            lblPreciofinal.Text = cadena.ToString();

        }

        private void BtnVender_Click(object sender, EventArgs e)
        {
            if (numericUpDownCantidad.Value>=1 && numericUpDownCantidad.Value <= product.Stock)
            {
                comic.Vender(product, (int)numericUpDownCantidad.Value );
                
                this.DialogResult = DialogResult.OK;
            }else if (numericUpDownCantidad.Value > product.Stock)
            {
                MessageBox.Show("Supero la cantidad de stock disponible, debe disminuir la cantidad de unidades a vender","ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
        }
    }
}
