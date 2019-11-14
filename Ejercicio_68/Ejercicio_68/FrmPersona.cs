using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace Ejercicio_68
{
    public partial class FrmPersona : Form
    {
        private Persona persona;
        public FrmPersona()
        {
            InitializeComponent();
        }

        public static void NotificarCambio(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            if (persona is null)
            {
                persona = new Persona();
                persona.EventoString += NotificarCambio;
                btnCrear.Text = "Actualizar";
                
            }
            persona.Apellido = txtApellido.Text;
            persona.Nombre = txtNombre.Text;
        }
    }
}
