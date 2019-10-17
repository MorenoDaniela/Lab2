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
        
        public FrmCantina()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.barra1.SetCantina = Cantina.GetCantina(10);
            cmbBotellaTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));
        }

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
