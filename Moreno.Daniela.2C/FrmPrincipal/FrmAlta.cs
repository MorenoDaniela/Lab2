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
    public partial class FrmAlta : Form
    {
        public static FrmAlta frmAlta_Instancia;
        Estacionamiento estacionamiento;

        /// <summary>
        /// Carga el estacionamientod de esta clase con el estacionamiento que recibe.
        /// </summary>
        /// <param name="e"></param>
        public FrmAlta(Estacionamiento e)
        {
            InitializeComponent();
            estacionamiento = e;
        }

        /// <summary>
        /// Vuelve la instancia de este form null, cierra el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmAlta_Instancia = null;
            this.Close();
        }

        /// <summary>
        /// Si la instancia de este formulario no es null, la crea y la retorna
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static FrmAlta CrearInstancia(Estacionamiento e)
        {
            if (frmAlta_Instancia is null)
            {
                frmAlta_Instancia = new FrmAlta(e);
                
            }
            return frmAlta_Instancia;
        }

        /// <summary>
        /// Segun el radioButton Chequeado, instancia un Auto o Moto, lo agrega al estacionamiento y muestra un mensaje.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (rdAuto.Checked is true)
            {

                int.TryParse(txtDni.Text, out int dni);
                Auto auto = new Auto(txtPatente.Text, txtNombre.Text, dni, cmbTransmision.Text, cmbColor.Text);
                if (estacionamiento + auto)
                {
                    MessageBox.Show("Auto agregado correctamente");
                }else
                {
                    MessageBox.Show("No se pudo agregar correctamente vuelta a intentarlo");
                }
            }else if (rdMoto.Checked is true)
            {
                
                int.TryParse(txtDni.Text, out int dni);
                int.TryParse(txtCilindrada.Text, out int cilin);
                Moto moto = new Moto(txtPatente.Text, txtNombre.Text, dni, cilin, cmbColor.Text);
                if (estacionamiento + moto)
                {
                    MessageBox.Show("Moto agregada correctamente");
                }
                else
                {
                    MessageBox.Show("No se pudo agregar correctamente vuelva a intentarlo");
                }
            }

            frmAlta_Instancia = null;
        }

        /// <summary>
        ///Asigna el tipo de enumerado que tendran los combo box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAlta_Load(object sender, EventArgs e)
        {
            cmbColor.DataSource = Enum.GetValues(typeof(eColores));
            cmbTransmision.DataSource = Enum.GetValues(typeof(eTransmision));

        }

        /// <summary>
        /// Vuelva la instancia de este form nula.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAlta_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAlta_Instancia = null;
        }

        /// <summary>
        /// Hace los atributos cilindrada del form invisibles, y los atributos de transmision visibles.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdAuto_CheckedChanged(object sender, EventArgs e)
        {
            lblCilindrada.Visible = false;
            txtCilindrada.Visible = false;
            lblTransmision.Visible = true;
            cmbTransmision.Visible = true;
        }

        /// <summary>
        /// Hace los atributos del form transmision invisibles y los de cilindrada visibles.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdMoto_CheckedChanged(object sender, EventArgs e)
        {
            lblTransmision.Visible = false;
            cmbTransmision.Visible = false;
            lblCilindrada.Visible = true;
            txtCilindrada.Visible = true;

        }
    }
}
