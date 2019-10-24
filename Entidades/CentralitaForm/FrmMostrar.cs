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

namespace CentralitaForm
{
    public partial class FrmMostrar : Form
    {
        Llamada.TipoLlamada tipoCall;
        public FrmMostrar()
        {
            InitializeComponent();
        }

        public Llamada.TipoLlamada GetTipoLlamada
        {
            //get { return myVar; }
            set { tipoCall = value; }
        }


        public FrmMostrar(string cadena)
            : this()
        {
            richTextBox1.Text = cadena;
        }


    }
}
