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
    public partial class FrmCantidadEspaciosCantina : Form
    {
        public FrmCantidadEspaciosCantina()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.Cancel;
            
            //btnCancelar.DialogResult= DialogResult.Cancel;
            this.Close();
            
  
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.OK;
            //btnAgregar.DialogResult = DialogResult.OK;
            this.Close();
        }

        public short CantidadEspacios
        {
            get
            {
                return (short)nudCantidad.Value;
            }
        }

        private void FrmCantidadEspaciosCantina_Load(object sender, EventArgs e)
        {

        }
    }
}
