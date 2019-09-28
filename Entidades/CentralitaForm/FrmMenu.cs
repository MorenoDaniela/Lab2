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
    public partial class FrmMenu : Form
    {
        Centralita llamada= new Centralita("Denu center");

        public Centralita Llamada
        {
            get
            {
                return this.llamada;
            }
        }

        public FrmMenu()
        {
            InitializeComponent();
        }

        public FrmMenu(Centralita central)
            : this()
        {
            this.llamada = central;
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            Form formLlamador = new FrmLlamador(llamada);
            formLlamador.ShowDialog();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void BtnFacturacionTotal_Click(object sender, EventArgs e)
        {
            

            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("Las ganancias totales por llamadas: {0}", llamada.GananciasPorTotal);
            Form formMostrar = new FrmMostrar(cadena.ToString());
            
            formMostrar.ShowDialog();
            /*
            Form formMostrar = new FrmMostrar(llamada.Mostrar());
            formMostrar.ShowDialog();*/
        }

        private void BtnLocal_Click(object sender, EventArgs e)
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("Las ganancias totales por llamadas locales: {0}", llamada.GananciasPorLocal);
            Form formMostrar = new FrmMostrar(cadena.ToString());
            formMostrar.ShowDialog();
            /*
            Form formMostrar = new FrmMostrar(llamada.GananciasPorLocal.ToString());
            formMostrar.ShowDialog();
            
            foreach (Llamada call in llamada.Llamadas)
            {
                if (call is Local && llamada is Local)
                {
                    Form formMostrar = new FrmMostrar(llamada.Mostrar());
                    formMostrar.ShowDialog();
                }
            }*/
            
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnProvincial_Click(object sender, EventArgs e)
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("Las ganancias totales por llamadas provinciales: {0}", llamada.GananciasPorProvincial);
            Form formMostrar = new FrmMostrar(cadena.ToString());
            formMostrar.ShowDialog();
        }
    }
}
