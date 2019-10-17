namespace FrmCantina
{
    partial class FrmCantina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCantina));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBotellaTipo = new System.Windows.Forms.ComboBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.numCapacidad = new System.Windows.Forms.NumericUpDown();
            this.numContenido = new System.Windows.Forms.NumericUpDown();
            this.BtnCerveza = new System.Windows.Forms.RadioButton();
            this.BtnAgua = new System.Windows.Forms.RadioButton();
            this.barra1 = new ControlCantina.Barra();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numContenido)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(371, 415);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(151, 40);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Capacidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contenido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Botella tipo";
            // 
            // cmbBotellaTipo
            // 
            this.cmbBotellaTipo.FormattingEnabled = true;
            this.cmbBotellaTipo.Items.AddRange(new object[] {
            "Vidrio",
            "Plastico"});
            this.cmbBotellaTipo.Location = new System.Drawing.Point(380, 384);
            this.cmbBotellaTipo.Name = "cmbBotellaTipo";
            this.cmbBotellaTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbBotellaTipo.TabIndex = 6;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(234, 384);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 7;
            // 
            // numCapacidad
            // 
            this.numCapacidad.Location = new System.Drawing.Point(104, 434);
            this.numCapacidad.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numCapacidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCapacidad.Name = "numCapacidad";
            this.numCapacidad.Size = new System.Drawing.Size(120, 20);
            this.numCapacidad.TabIndex = 8;
            this.numCapacidad.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numContenido
            // 
            this.numContenido.Location = new System.Drawing.Point(230, 434);
            this.numContenido.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numContenido.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numContenido.Name = "numContenido";
            this.numContenido.Size = new System.Drawing.Size(120, 20);
            this.numContenido.TabIndex = 9;
            this.numContenido.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // BtnCerveza
            // 
            this.BtnCerveza.AutoSize = true;
            this.BtnCerveza.Location = new System.Drawing.Point(25, 411);
            this.BtnCerveza.Name = "BtnCerveza";
            this.BtnCerveza.Size = new System.Drawing.Size(64, 17);
            this.BtnCerveza.TabIndex = 10;
            this.BtnCerveza.TabStop = true;
            this.BtnCerveza.Text = "Cerveza";
            this.BtnCerveza.UseVisualStyleBackColor = true;
            // 
            // BtnAgua
            // 
            this.BtnAgua.AutoSize = true;
            this.BtnAgua.Location = new System.Drawing.Point(25, 434);
            this.BtnAgua.Name = "BtnAgua";
            this.BtnAgua.Size = new System.Drawing.Size(50, 17);
            this.BtnAgua.TabIndex = 11;
            this.BtnAgua.TabStop = true;
            this.BtnAgua.Text = "Agua";
            this.BtnAgua.UseVisualStyleBackColor = true;
            // 
            // barra1
            // 
            this.barra1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra1.BackgroundImage")));
            this.barra1.Location = new System.Drawing.Point(25, 12);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(565, 335);
            this.barra1.TabIndex = 1;
            // 
            // FrmCantina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 476);
            this.Controls.Add(this.BtnAgua);
            this.Controls.Add(this.BtnCerveza);
            this.Controls.Add(this.numContenido);
            this.Controls.Add(this.numCapacidad);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.cmbBotellaTipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barra1);
            this.Controls.Add(this.btnAgregar);
            this.Name = "FrmCantina";
            this.Text = "Cantina";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numContenido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private ControlCantina.Barra barra1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBotellaTipo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.NumericUpDown numCapacidad;
        private System.Windows.Forms.NumericUpDown numContenido;
        private System.Windows.Forms.RadioButton BtnCerveza;
        private System.Windows.Forms.RadioButton BtnAgua;
    }
}

