using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FrmPrincipal
{
    public partial class FrmPrincipal : Form
    {
        Estacionamiento estacionamiento;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Instancia el formAlta, indica que el Frmprincipal es el mdiParent del formAlta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlta frmAlta = FrmAlta.CrearInstancia(estacionamiento);
            frmAlta.MdiParent = this;
            frmAlta.Show();
        }

        /// <summary>
        /// Instancia el estacionamiento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            estacionamiento = Estacionamiento.InstanciarEstacionamiento("Estacionamiento Denu", 10, 20);
        }

        /// <summary>
        /// Lista toda la informacion de un estacionamiento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listarInformacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder cadena = new StringBuilder();
            //cadena.AppendFormat("Nombre del estacionamiento: {0}", estacionamiento.Nombre);
            //se puede acceder pero como ya la muestro en el metodo ToString sino repite.
            cadena.Append(estacionamiento.ToString());
            
            MessageBox.Show(cadena.ToString());
        }
    }
}
