using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_56
{
    public partial class Ej55 : Form
    {
        string ultimoAbierto = null;
        public Ej55()
        {
            InitializeComponent();
        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            if (EventoAbrir.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(EventoAbrir.FileName))
                {
                    this.ultimoAbierto = EventoAbrir.FileName;
                    StreamReader aux = new StreamReader(EventoAbrir.FileName);
                    string auxiliar = aux.ReadToEnd();
                    richText.Text = auxiliar;    
                    aux.Close();
                }

            }
        }

        private void BtnGuardarComo_Click(object sender, EventArgs e)
        {
            if (EventoGuardarComo.ShowDialog()==DialogResult.OK)
            {
                StreamWriter cadena = new StreamWriter(EventoGuardarComo.FileName);
                cadena.Write(richText.Text);
                cadena.Close();
            }
            
            
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            StreamWriter aux;
            if(!(ultimoAbierto is null))
            {
                aux = new StreamWriter(ultimoAbierto);
                aux.Write(richText.Text);
                aux.Close();
            }
            else
            {
                if (EventoGuardarComo.ShowDialog() == DialogResult.OK)
                {

                    aux = new StreamWriter(EventoGuardarComo.FileName+".txt");
                    aux.Write(richText.Text);
                    aux.Close();
                }
                
            }
        }

       

        private void RichText_TextChanged(object sender, EventArgs e)
        {
            CantCaracteres.Text = richText.Text.Length + " Caracteres";
        }
    }
}
