﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{
    public partial class FrmPickUp : Form
    {
        public FrmPickUp()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            PickUp camioneta = new PickUp(txtPatente.Text, txtModelo.Text);
            MessageBox.Show(camioneta.ConsultarDatos(), "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
