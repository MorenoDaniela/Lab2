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

namespace FrmCantina
{
    public partial class FormBar : Form
    {
        Edificio edificio = Edificio.GetBar();
        public FormBar()
        {
            InitializeComponent();
            //IsMdiContainer = true;
           
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FrmCantidadEspaciosCantina frmCantidad = new FrmCantidadEspaciosCantina();
            frmCantidad.MdiParent = this;
            frmCantidad.Show();
                      
            if (frmCantidad.DialogResult==DialogResult.OK)
            {
                int cantidad = frmCantidad.CantidadEspacios;
                Cantina cantina = new Cantina(cantidad);
                FrmCantina frmCantina = new FrmCantina();
                frmCantina.Show();

            
                if (this.edificio + frmCantina.GetCantina)
                {
                    
                    frmCantina.MdiParent = this;
                    frmCantina.Show();
                }

            }
        }

        private void barrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            foreach (FrmCantina f in this.MdiChildren)
            {
                
                MessageBox.Show(f.GetInforme);//aca deberia poder mostrar la cantina
            }
            //this.MdiChildren = 
        }

        private void FormBar_Load(object sender, EventArgs e)
        {
            
        }
    }
}
