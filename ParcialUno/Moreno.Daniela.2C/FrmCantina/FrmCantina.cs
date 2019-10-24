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
using ControlCantina;

namespace FrmCantina
{
    public partial class FrmCantina: Form
    {
        /// <summary>
        /// Inicializa los componentes del FrmCantina.
        /// </summary>
        public FrmCantina()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga el formulario, setea la cantidad de espacios en la cantina y establece el combo box con los tipos de botella.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.barra1.SetCantina = Cantina.GetCantina(10);
            cmbBotellaTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));
        }

        /// <summary>
        /// Agrega una botella a la barra.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            Botella.Tipo tipo;
            Enum.TryParse<Botella.Tipo>(cmbBotellaTipo.SelectedValue.ToString(), out tipo);
            if (BtnAgua.Checked)
            {
                Agua agua = new Agua((int)numCapacidad.Value, txtMarca.Text, (int)numContenido.Value);
                barra1.AgregarBotella(agua);
            }
            else
            {
                Cerveza cerveza = new Cerveza((int)numCapacidad.Value, txtMarca.Text, tipo, (int)numContenido.Value);
                barra1.AgregarBotella(cerveza);
            }

        }      
    }
}
