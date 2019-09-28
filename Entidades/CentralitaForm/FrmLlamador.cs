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
    public partial class FrmLlamador : Form
    {
        Centralita llamada;
        TextBox foco = new TextBox();
        public Centralita Llamada
        {
            get
            {
                return this.llamada;
            }
        }

        public FrmLlamador()
        {
            InitializeComponent();
        }

        public FrmLlamador(Centralita central)
            : this()
        {
            this.llamada = central;
        }


        private void FrmLlamador_Load(object sender, EventArgs e)
        {

        }

#region NUMEROS
        private void Btn1_Click(object sender, EventArgs e)
        {
            ConcatenarOLimpiar("1");
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            ConcatenarOLimpiar("2");
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            ConcatenarOLimpiar("3");
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            ConcatenarOLimpiar("4");
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            ConcatenarOLimpiar("5");
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            ConcatenarOLimpiar("6");
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            ConcatenarOLimpiar("7");
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            ConcatenarOLimpiar("8");
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            ConcatenarOLimpiar("9");
        }

        private void BtnAsterisco_Click(object sender, EventArgs e)
        {
            ConcatenarOLimpiar("*");
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            ConcatenarOLimpiar("0");
        }

        private void BtnHashtag_Click(object sender, EventArgs e)
        {
            ConcatenarOLimpiar("#");
        }
#endregion

        private void TxtBoxDestino_TextChanged(object sender, EventArgs e)
        {
            #region harcode
            /*
            char[] array = txtBoxDestino.Text.ToCharArray();
            for (int i=0; i<array.Length;i++)
            {
                if (array[i]!='#')
                {
                    cmbFranja.Enabled = false;
                }
            }*/
            #endregion
            if (txtBoxDestino.Text.StartsWith("#"))
            {
                cmbFranja.Enabled = true;
            }else
            {
                cmbFranja.Enabled = false;
            }
        }

        private void ConcatenarOLimpiar(string ingreso)
        {
            if (foco.Text=="Nro Destino" || foco.Text == "Nro Origen")
            {
                foco.Text = ingreso;
            }
            else
            {
                foco.Text +=ingreso;
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtBoxDestino.Text = "";
            txtBoxOrigen.Text = "";
        }

        private void TxtBoxDestino_Click(object sender, EventArgs e)
        {
            foco = txtBoxDestino;
            
        }

        private void TxtBoxOrigen_Click(object sender, EventArgs e)
        {
            foco = txtBoxOrigen;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Form aux = new FrmMenu(llamada);
            this.Close();
        }

        private void BtnLlamar_Click(object sender, EventArgs e)
        {
            Random num = new Random();
            int duracion = num.Next(1, 50);
           
            if (txtBoxDestino.Text.StartsWith("#") && txtBoxDestino.Text!="Nro Destino")
            {
                // Carga
                cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
                // Lectura
                Provincial.Franja franjas;
                Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjas);
                Provincial prov = new Provincial(txtBoxOrigen.Text, franjas, (float)duracion, txtBoxDestino.Text);
                llamada += prov;
                BtnLimpiar_Click(sender, e);
            }else if (txtBoxOrigen.Text!="Nro Origen")
            {
                int costo = num.Next(5, 56);
                float costoF = costo / 10;
                Local local = new Local(txtBoxOrigen.Text, duracion, txtBoxDestino.Text, costoF);
                llamada += local;
                BtnLimpiar_Click(sender, e);
            }
        }
    }
}
