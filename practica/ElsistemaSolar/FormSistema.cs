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

namespace ElsistemaSolar
{
    public partial class FormSistema : Form
    {
        public static List<Astro> planetas;
        
        public FormSistema()
        {
            InitializeComponent();
            planetas = new List<Astro>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnAgregarPlaneta_Click(object sender, EventArgs e)
        {
            if (numCantSatelites.Value>0 && numRotacion.Value>0 && txtNombrePlaneta.Text!="" && txtOrbitaPlaneta.Text!="")
            {
                int resultado;
                resultado = Convert.ToInt32(txtOrbitaPlaneta.Text);
                ETipo tipo;
                if (cmbTipo.Text == "Gaseoso")
                {
                    tipo = ETipo.Gaseoso;
                    Planeta nuevo = new Planeta(resultado, (int)numRotacion.Value, txtNombrePlaneta.Text, (int)numCantSatelites.Value, tipo);
                    planetas.Add(nuevo);
                    cmbPlanetas.Items.Add(nuevo);
                }
                else if (cmbTipo.Text == "Rocoso")
                {
                    tipo = ETipo.Rocoso;
                    Planeta nuevo = new Planeta(resultado, (int)numRotacion.Value, txtNombrePlaneta.Text, (int)numCantSatelites.Value, tipo);
                    planetas.Add(nuevo);
                    cmbPlanetas.Items.Add(nuevo);
                }
                 
            }
            
        }

        private void BtnAgregarSatelite_Click(object sender, EventArgs e)
        {
            if (numCantSatelites.Value>0 && numOrbitaSatelite.Value>0 && txtNombreSatelite.Text!="")
            {
                if (cmbPlanetas.Items.Count>0)
                {
                    Satelite sat = new Satelite((int)numOrbitaSatelite.Value, (int)numRotacionSatelite.Value, txtNombreSatelite.Text);
                    
                    
                    foreach (Planeta planet in planetas)
                    {
                        planet.Satelites.Add(sat);
                    }
                    
                }
            }
        }

        private void BtnMostrarInformacion_Click(object sender, EventArgs e)
        {
            foreach (Astro astro in planetas)
            {
                if (astro is Planeta)
                {
                    richTextBox1.AppendText(astro.ToString());
                    foreach (Satelite sat in )
                    
                }else if (astro is Satelite)
                richTextBox1.AppendText(astro.ToString());
            }
            //foreach(Satelite sat in planetas)
            //{
                
                
            //}
           
        }

        private void BtnMoverAstros_Click(object sender, EventArgs e)
        {
            foreach (Planeta planet in planetas)
            {
                richTextBox1.AppendText(planet.Orbitar());
                richTextBox1.AppendText(planet.Rotar());
                foreach (Satelite sat in planet.Satelites)
                {
                    richTextBox1.AppendText(sat.Orbitar());
                    richTextBox1.AppendText(sat.Rotar());
                }
                    
            }
            
        }
    }
}
