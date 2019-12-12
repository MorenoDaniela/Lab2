namespace VistaForm
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtmPicker = new System.Windows.Forms.DateTimePicker();
            this.txtCursoDni = new System.Windows.Forms.TextBox();
            this.txtCursoApellido = new System.Windows.Forms.TextBox();
            this.txtCursoNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numCursoAño = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAlumnoLegajo = new System.Windows.Forms.TextBox();
            this.txtAlumnoApellido = new System.Windows.Forms.TextBox();
            this.txtAlumnoNombre = new System.Windows.Forms.TextBox();
            this.cmbAlumnoDivision = new System.Windows.Forms.ComboBox();
            this.numAlumnoAño = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnCrearCurso = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCursoAño)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAlumnoAño)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCurso);
            this.groupBox1.Controls.Add(this.dtmPicker);
            this.groupBox1.Controls.Add(this.txtCursoDni);
            this.groupBox1.Controls.Add(this.txtCursoApellido);
            this.groupBox1.Controls.Add(this.txtCursoNombre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numCursoAño);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Curso";
            // 
            // dtmPicker
            // 
            this.dtmPicker.Location = new System.Drawing.Point(125, 181);
            this.dtmPicker.Name = "dtmPicker";
            this.dtmPicker.Size = new System.Drawing.Size(200, 20);
            this.dtmPicker.TabIndex = 11;
            // 
            // txtCursoDni
            // 
            this.txtCursoDni.Location = new System.Drawing.Point(176, 155);
            this.txtCursoDni.Name = "txtCursoDni";
            this.txtCursoDni.Size = new System.Drawing.Size(149, 20);
            this.txtCursoDni.TabIndex = 10;
            // 
            // txtCursoApellido
            // 
            this.txtCursoApellido.Location = new System.Drawing.Point(176, 125);
            this.txtCursoApellido.Name = "txtCursoApellido";
            this.txtCursoApellido.Size = new System.Drawing.Size(149, 20);
            this.txtCursoApellido.TabIndex = 9;
            // 
            // txtCursoNombre
            // 
            this.txtCursoNombre.Location = new System.Drawing.Point(178, 97);
            this.txtCursoNombre.Name = "txtCursoNombre";
            this.txtCursoNombre.Size = new System.Drawing.Size(147, 20);
            this.txtCursoNombre.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ingreso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Division";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Año";
            // 
            // numCursoAño
            // 
            this.numCursoAño.Location = new System.Drawing.Point(176, 39);
            this.numCursoAño.Name = "numCursoAño";
            this.numCursoAño.Size = new System.Drawing.Size(149, 20);
            this.numCursoAño.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAlumnoLegajo);
            this.groupBox2.Controls.Add(this.txtAlumnoApellido);
            this.groupBox2.Controls.Add(this.txtAlumnoNombre);
            this.groupBox2.Controls.Add(this.cmbAlumnoDivision);
            this.groupBox2.Controls.Add(this.numAlumnoAño);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(363, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 209);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Alumno";
            // 
            // txtAlumnoLegajo
            // 
            this.txtAlumnoLegajo.Location = new System.Drawing.Point(217, 100);
            this.txtAlumnoLegajo.Name = "txtAlumnoLegajo";
            this.txtAlumnoLegajo.Size = new System.Drawing.Size(120, 20);
            this.txtAlumnoLegajo.TabIndex = 9;
            // 
            // txtAlumnoApellido
            // 
            this.txtAlumnoApellido.Location = new System.Drawing.Point(217, 70);
            this.txtAlumnoApellido.Name = "txtAlumnoApellido";
            this.txtAlumnoApellido.Size = new System.Drawing.Size(120, 20);
            this.txtAlumnoApellido.TabIndex = 8;
            // 
            // txtAlumnoNombre
            // 
            this.txtAlumnoNombre.Location = new System.Drawing.Point(216, 36);
            this.txtAlumnoNombre.Name = "txtAlumnoNombre";
            this.txtAlumnoNombre.Size = new System.Drawing.Size(121, 20);
            this.txtAlumnoNombre.TabIndex = 7;
            // 
            // cmbAlumnoDivision
            // 
            this.cmbAlumnoDivision.FormattingEnabled = true;
            this.cmbAlumnoDivision.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.cmbAlumnoDivision.Location = new System.Drawing.Point(216, 156);
            this.cmbAlumnoDivision.Name = "cmbAlumnoDivision";
            this.cmbAlumnoDivision.Size = new System.Drawing.Size(121, 21);
            this.cmbAlumnoDivision.TabIndex = 6;
            // 
            // numAlumnoAño
            // 
            this.numAlumnoAño.Location = new System.Drawing.Point(217, 130);
            this.numAlumnoAño.Name = "numAlumnoAño";
            this.numAlumnoAño.Size = new System.Drawing.Size(120, 20);
            this.numAlumnoAño.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Division";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Año";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Legajo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Apellido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nombre";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 263);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(694, 190);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // btnCrearCurso
            // 
            this.btnCrearCurso.Location = new System.Drawing.Point(12, 227);
            this.btnCrearCurso.Name = "btnCrearCurso";
            this.btnCrearCurso.Size = new System.Drawing.Size(172, 30);
            this.btnCrearCurso.TabIndex = 3;
            this.btnCrearCurso.Text = "Crear Curso";
            this.btnCrearCurso.UseVisualStyleBackColor = true;
            this.btnCrearCurso.Click += new System.EventHandler(this.BtnCrearCurso_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(190, 227);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(167, 30);
            this.btnMostrar.TabIndex = 4;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(363, 227);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(343, 30);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // cmbCurso
            // 
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.cmbCurso.Location = new System.Drawing.Point(176, 69);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(149, 21);
            this.cmbCurso.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 465);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnCrearCurso);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCursoAño)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAlumnoAño)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numCursoAño;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCrearCurso;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCursoDni;
        private System.Windows.Forms.TextBox txtCursoApellido;
        private System.Windows.Forms.TextBox txtCursoNombre;
        private System.Windows.Forms.ComboBox cmbAlumnoDivision;
        private System.Windows.Forms.NumericUpDown numAlumnoAño;
        private System.Windows.Forms.TextBox txtAlumnoLegajo;
        private System.Windows.Forms.TextBox txtAlumnoApellido;
        private System.Windows.Forms.TextBox txtAlumnoNombre;
        private System.Windows.Forms.DateTimePicker dtmPicker;
        private System.Windows.Forms.ComboBox cmbCurso;
    }
}

