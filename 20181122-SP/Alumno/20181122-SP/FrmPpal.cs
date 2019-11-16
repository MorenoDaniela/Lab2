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
using VistaPatentes;
using Archivos;
using System.Threading;

namespace _20181122_SP
{
    public partial class FrmPpal : Form
    {
        public Queue<Patente> cola;
        public List<Thread> lista;
        

        public FrmPpal()
        {
            InitializeComponent();

            this.cola = new Queue<Patente>();
            lista = new List<Thread>();
        }

        private void FrmPpal_Load(object sender, EventArgs e)
        {
            vistaPatente1.finExposicion += new Patentes.FinExposicionPatente(ProximaPatente);
            vistaPatente2.finExposicion += new Patentes.FinExposicionPatente(ProximaPatente);
        }


        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            FinalizarSimulacion();
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            
            Xml<Queue<Patente>> xml = new Xml<Queue<Patente>>();
            xml.Leer(AppDomain.CurrentDomain.BaseDirectory + "patentes.xml", out cola);
            IniciarSimulación();
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            Texto texto = new Texto();
            texto.Leer(AppDomain.CurrentDomain.BaseDirectory + "patentes.txt", out cola);
            IniciarSimulación();
        }

        private void btnSql_Click(object sender, EventArgs e)
        {

        }

        private void FinalizarSimulacion()
        {
            foreach (Thread t in lista)
            {
                if (t.IsAlive && !(t is null))
                {
                    t.Abort();
                }
            }
            
        }

        private void IniciarSimulación()
        {
            FinalizarSimulacion();
            ProximaPatente(vistaPatente1);
            ProximaPatente(vistaPatente2);
        }

        public void ProximaPatente(Patentes.VistaPatente pat)
        {
            if (cola.Count>0 && !(cola is null))
            {

                foreach (Patente p in cola)
                {
                    Thread hilo = new Thread (new ParameterizedThreadStart(pat.MostrarPatente));
                    hilo.Start();
                    lista.Add(hilo);
                }
            }
            
        }
    }
}
