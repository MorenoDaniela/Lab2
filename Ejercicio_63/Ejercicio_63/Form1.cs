using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_63
{
    public partial class Form1 : Form
    {
        DateTime hora = DateTime.Now;
        public Form1()
        {
            InitializeComponent();
            AsignarHora();
        }

        public void AsignarHora()
        { 
            if (hora!=DateTime.Now)
            {
                lblHora.Text = hora.ToString();
            }      
        }
    }
}
