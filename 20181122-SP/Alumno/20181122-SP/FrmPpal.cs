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
        Queue<Patente> cola;
        public List<Thread> lista;

        public FrmPpal()
        {
            InitializeComponent();

            this.cola = new Queue<Patente>();
            lista = new List<Thread>();
        }

        private void FrmPpal_Load(object sender, EventArgs e)
        {
            //En el evento Load del formulario, asociar el evento VistaPatente para los objetos vistaPatente1 y
            //vistaPatente2 con el manejador.
            

            /*
            // EVENTO
            votacion.EventoVotoEfectuado += ManejadorVoto;

            // THREAD
            Thread hilo = new Thread(votacion.Simular);//Al hilo yo le paso el metodo que quiero correr en segundo plano
            hilo.Start();*/
        }

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnXml_Click(object sender, EventArgs e)
        {

        }

        private void btnTxt_Click(object sender, EventArgs e)
        {

        }

        private void btnSql_Click(object sender, EventArgs e)
        {

        }

        private void FinalizarSimulacion()
        {
        //matar hilos
        }
    }
}
