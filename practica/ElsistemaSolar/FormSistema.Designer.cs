namespace ElsistemaSolar
{
    partial class FormSistema
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbPlanetas = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.numRotacion = new System.Windows.Forms.NumericUpDown();
            this.numCantSatelites = new System.Windows.Forms.NumericUpDown();
            this.numOrbitaSatelite = new System.Windows.Forms.NumericUpDown();
            this.numRotacionSatelite = new System.Windows.Forms.NumericUpDown();
            this.txtNombrePlaneta = new System.Windows.Forms.TextBox();
            this.txtOrbitaPlaneta = new System.Windows.Forms.TextBox();
            this.txtNombreSatelite = new System.Windows.Forms.TextBox();
            this.btnAgregarPlaneta = new System.Windows.Forms.Button();
            this.btnAgregarSatelite = new System.Windows.Forms.Button();
            this.btnMostrarInformacion = new System.Windows.Forms.Button();
            this.btnMoverAstros = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numRotacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantSatelites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOrbitaSatelite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotacionSatelite)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del planeta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tiempo en completar orbita";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tiempo en completar rotacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad de lunas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo de planeta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Planeta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nombre del satelite";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(248, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tiempo en completar la orbita";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(248, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tiempo en completar rotacion";
            // 
            // cmbPlanetas
            // 
            this.cmbPlanetas.FormattingEnabled = true;
            this.cmbPlanetas.Location = new System.Drawing.Point(400, 30);
            this.cmbPlanetas.Name = "cmbPlanetas";
            this.cmbPlanetas.Size = new System.Drawing.Size(121, 21);
            this.cmbPlanetas.TabIndex = 9;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Rocoso",
            "Gaseoso"});
            this.cmbTipo.Location = new System.Drawing.Point(130, 177);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 10;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(527, 30);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(198, 294);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // numRotacion
            // 
            this.numRotacion.Location = new System.Drawing.Point(131, 116);
            this.numRotacion.Name = "numRotacion";
            this.numRotacion.Size = new System.Drawing.Size(120, 20);
            this.numRotacion.TabIndex = 12;
            // 
            // numCantSatelites
            // 
            this.numCantSatelites.Location = new System.Drawing.Point(131, 148);
            this.numCantSatelites.Name = "numCantSatelites";
            this.numCantSatelites.Size = new System.Drawing.Size(120, 20);
            this.numCantSatelites.TabIndex = 13;
            // 
            // numOrbitaSatelite
            // 
            this.numOrbitaSatelite.Location = new System.Drawing.Point(400, 116);
            this.numOrbitaSatelite.Name = "numOrbitaSatelite";
            this.numOrbitaSatelite.Size = new System.Drawing.Size(120, 20);
            this.numOrbitaSatelite.TabIndex = 14;
            // 
            // numRotacionSatelite
            // 
            this.numRotacionSatelite.Location = new System.Drawing.Point(400, 153);
            this.numRotacionSatelite.Name = "numRotacionSatelite";
            this.numRotacionSatelite.Size = new System.Drawing.Size(120, 20);
            this.numRotacionSatelite.TabIndex = 15;
            // 
            // txtNombrePlaneta
            // 
            this.txtNombrePlaneta.Location = new System.Drawing.Point(140, 31);
            this.txtNombrePlaneta.Name = "txtNombrePlaneta";
            this.txtNombrePlaneta.Size = new System.Drawing.Size(100, 20);
            this.txtNombrePlaneta.TabIndex = 16;
            // 
            // txtOrbitaPlaneta
            // 
            this.txtOrbitaPlaneta.Location = new System.Drawing.Point(140, 67);
            this.txtOrbitaPlaneta.Name = "txtOrbitaPlaneta";
            this.txtOrbitaPlaneta.Size = new System.Drawing.Size(100, 20);
            this.txtOrbitaPlaneta.TabIndex = 17;
            // 
            // txtNombreSatelite
            // 
            this.txtNombreSatelite.Location = new System.Drawing.Point(421, 67);
            this.txtNombreSatelite.Name = "txtNombreSatelite";
            this.txtNombreSatelite.Size = new System.Drawing.Size(100, 20);
            this.txtNombreSatelite.TabIndex = 18;
            // 
            // btnAgregarPlaneta
            // 
            this.btnAgregarPlaneta.Location = new System.Drawing.Point(42, 240);
            this.btnAgregarPlaneta.Name = "btnAgregarPlaneta";
            this.btnAgregarPlaneta.Size = new System.Drawing.Size(136, 23);
            this.btnAgregarPlaneta.TabIndex = 19;
            this.btnAgregarPlaneta.Text = "Agregar planeta";
            this.btnAgregarPlaneta.UseVisualStyleBackColor = true;
            this.btnAgregarPlaneta.Click += new System.EventHandler(this.BtnAgregarPlaneta_Click);
            // 
            // btnAgregarSatelite
            // 
            this.btnAgregarSatelite.Location = new System.Drawing.Point(195, 240);
            this.btnAgregarSatelite.Name = "btnAgregarSatelite";
            this.btnAgregarSatelite.Size = new System.Drawing.Size(142, 23);
            this.btnAgregarSatelite.TabIndex = 20;
            this.btnAgregarSatelite.Text = "Agregar satelite";
            this.btnAgregarSatelite.UseVisualStyleBackColor = true;
            this.btnAgregarSatelite.Click += new System.EventHandler(this.BtnAgregarSatelite_Click);
            // 
            // btnMostrarInformacion
            // 
            this.btnMostrarInformacion.Location = new System.Drawing.Point(42, 269);
            this.btnMostrarInformacion.Name = "btnMostrarInformacion";
            this.btnMostrarInformacion.Size = new System.Drawing.Size(295, 23);
            this.btnMostrarInformacion.TabIndex = 21;
            this.btnMostrarInformacion.Text = "Mostrar informacion";
            this.btnMostrarInformacion.UseVisualStyleBackColor = true;
            this.btnMostrarInformacion.Click += new System.EventHandler(this.BtnMostrarInformacion_Click);
            // 
            // btnMoverAstros
            // 
            this.btnMoverAstros.Location = new System.Drawing.Point(42, 301);
            this.btnMoverAstros.Name = "btnMoverAstros";
            this.btnMoverAstros.Size = new System.Drawing.Size(295, 23);
            this.btnMoverAstros.TabIndex = 22;
            this.btnMoverAstros.Text = "Mover astros";
            this.btnMoverAstros.UseVisualStyleBackColor = true;
            this.btnMoverAstros.Click += new System.EventHandler(this.BtnMoverAstros_Click);
            // 
            // FormSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 364);
            this.Controls.Add(this.btnMoverAstros);
            this.Controls.Add(this.btnMostrarInformacion);
            this.Controls.Add(this.btnAgregarSatelite);
            this.Controls.Add(this.btnAgregarPlaneta);
            this.Controls.Add(this.txtNombreSatelite);
            this.Controls.Add(this.txtOrbitaPlaneta);
            this.Controls.Add(this.txtNombrePlaneta);
            this.Controls.Add(this.numRotacionSatelite);
            this.Controls.Add(this.numOrbitaSatelite);
            this.Controls.Add(this.numCantSatelites);
            this.Controls.Add(this.numRotacion);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.cmbPlanetas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSistema";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRotacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantSatelites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOrbitaSatelite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotacionSatelite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbPlanetas;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.NumericUpDown numRotacion;
        private System.Windows.Forms.NumericUpDown numCantSatelites;
        private System.Windows.Forms.NumericUpDown numOrbitaSatelite;
        private System.Windows.Forms.NumericUpDown numRotacionSatelite;
        private System.Windows.Forms.TextBox txtNombrePlaneta;
        private System.Windows.Forms.TextBox txtOrbitaPlaneta;
        private System.Windows.Forms.TextBox txtNombreSatelite;
        private System.Windows.Forms.Button btnAgregarPlaneta;
        private System.Windows.Forms.Button btnAgregarSatelite;
        private System.Windows.Forms.Button btnMostrarInformacion;
        private System.Windows.Forms.Button btnMoverAstros;
    }
}

