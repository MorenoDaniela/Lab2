using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmCantina
{
    public partial class FormBar : Form
    {
        public FormBar()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCantidadEspaciosCantina edificio = new FrmCantidadEspaciosCantina();
            edificio.ShowDialog();

            if (edificio.ShowDialog(this)==DialogResult.OK)
            {
                int cantidad = edificio.CantidadEspacios;
                FrmCantina frmCantina = new FrmCantina();
                if (this.edificio + frmCantina.GetCantina)
                {
                    frmCantina.MdiParent = this;
                    frmCantina.Show();
                }

            }
        }

        private void barrasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //this.MdiChildren = 
        }

        
    }
}
