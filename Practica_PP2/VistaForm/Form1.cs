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

namespace VistaForm
{
    public partial class Form1 : Form
    {
        Curso curso=null;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void BtnCrearCurso_Click(object sender, EventArgs e)
        {
            cmbCurso.DataSource = Enum.GetValues(typeof(Divisiones));
            Divisiones division;
            Enum.TryParse<Divisiones>(cmbCurso.SelectedValue.ToString(), out division);
            Profesor profesor = new Profesor(txtCursoNombre.Text, txtCursoApellido.Text, dtmPicker.CustomFormat);
            curso = new Curso((short)numCursoAño.Value, division, profesor);
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            if (!(curso is null))
            {
                richTextBox1.Text = (string)curso;
            }else
            {
                MessageBox.Show("No hay curso","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            
            cmbAlumnoDivision.DataSource = Enum.GetValues(typeof(Divisiones));
            Divisiones division;
            Enum.TryParse<Divisiones>(cmbAlumnoDivision.SelectedValue.ToString(), out division);
            Alumno alumno = new Alumno(txtAlumnoNombre.Text, txtAlumnoApellido.Text, txtAlumnoLegajo.Text,(short) numAlumnoAño.Value, division);

        }
    }
}
