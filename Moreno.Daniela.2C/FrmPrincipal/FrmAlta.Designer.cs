namespace FrmPrincipal
{
    partial class FrmAlta
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCilindrada = new System.Windows.Forms.Label();
            this.lblTransmision = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdAuto = new System.Windows.Forms.RadioButton();
            this.rdMoto = new System.Windows.Forms.RadioButton();
            this.cmbTransmision = new System.Windows.Forms.ComboBox();
            this.txtCilindrada = new System.Windows.Forms.TextBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtDni);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Dueño";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DNI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbColor);
            this.groupBox2.Controls.Add(this.txtPatente);
            this.groupBox2.Controls.Add(this.txtCilindrada);
            this.groupBox2.Controls.Add(this.cmbTransmision);
            this.groupBox2.Controls.Add(this.rdMoto);
            this.groupBox2.Controls.Add(this.rdAuto);
            this.groupBox2.Controls.Add(this.lblCilindrada);
            this.groupBox2.Controls.Add(this.lblTransmision);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 175);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Vehiculo";
            // 
            // lblCilindrada
            // 
            this.lblCilindrada.AutoSize = true;
            this.lblCilindrada.Location = new System.Drawing.Point(16, 148);
            this.lblCilindrada.Name = "lblCilindrada";
            this.lblCilindrada.Size = new System.Drawing.Size(76, 13);
            this.lblCilindrada.TabIndex = 4;
            this.lblCilindrada.Text = "Cilindrada (CC)";
            // 
            // lblTransmision
            // 
            this.lblTransmision.AutoSize = true;
            this.lblTransmision.Location = new System.Drawing.Point(16, 117);
            this.lblTransmision.Name = "lblTransmision";
            this.lblTransmision.Size = new System.Drawing.Size(63, 13);
            this.lblTransmision.TabIndex = 3;
            this.lblTransmision.Text = "Transmision";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tipo Vehiculo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Patente Vehiculo";
            // 
            // rdAuto
            // 
            this.rdAuto.AutoSize = true;
            this.rdAuto.Location = new System.Drawing.Point(129, 86);
            this.rdAuto.Name = "rdAuto";
            this.rdAuto.Size = new System.Drawing.Size(47, 17);
            this.rdAuto.TabIndex = 5;
            this.rdAuto.TabStop = true;
            this.rdAuto.Text = "Auto";
            this.rdAuto.UseVisualStyleBackColor = true;
            this.rdAuto.CheckedChanged += new System.EventHandler(this.rdAuto_CheckedChanged);
            // 
            // rdMoto
            // 
            this.rdMoto.AutoSize = true;
            this.rdMoto.Location = new System.Drawing.Point(230, 88);
            this.rdMoto.Name = "rdMoto";
            this.rdMoto.Size = new System.Drawing.Size(49, 17);
            this.rdMoto.TabIndex = 6;
            this.rdMoto.TabStop = true;
            this.rdMoto.Text = "Moto";
            this.rdMoto.UseVisualStyleBackColor = true;
            this.rdMoto.CheckedChanged += new System.EventHandler(this.rdMoto_CheckedChanged);
            // 
            // cmbTransmision
            // 
            this.cmbTransmision.FormattingEnabled = true;
            this.cmbTransmision.Items.AddRange(new object[] {
            "Seleccionar",
            "AT",
            "Manual"});
            this.cmbTransmision.Location = new System.Drawing.Point(120, 114);
            this.cmbTransmision.Name = "cmbTransmision";
            this.cmbTransmision.Size = new System.Drawing.Size(209, 21);
            this.cmbTransmision.TabIndex = 7;
            // 
            // txtCilindrada
            // 
            this.txtCilindrada.Location = new System.Drawing.Point(120, 145);
            this.txtCilindrada.Name = "txtCilindrada";
            this.txtCilindrada.Size = new System.Drawing.Size(209, 20);
            this.txtCilindrada.TabIndex = 8;
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(120, 28);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(209, 20);
            this.txtPatente.TabIndex = 9;
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Items.AddRange(new object[] {
            "Seleccionar",
            "Azul",
            "Rojo",
            "Blanco",
            "Negro"});
            this.cmbColor.Location = new System.Drawing.Point(120, 57);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(209, 21);
            this.cmbColor.TabIndex = 10;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(120, 51);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(209, 20);
            this.txtDni.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(120, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(209, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(12, 293);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(176, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(194, 293);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(153, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 330);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAlta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALTA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAlta_FormClosing);
            this.Load += new System.EventHandler(this.FrmAlta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCilindrada;
        private System.Windows.Forms.Label lblTransmision;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.TextBox txtCilindrada;
        private System.Windows.Forms.ComboBox cmbTransmision;
        private System.Windows.Forms.RadioButton rdMoto;
        private System.Windows.Forms.RadioButton rdAuto;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}

