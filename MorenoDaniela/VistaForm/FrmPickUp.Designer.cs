namespace VistaForm
{
    partial class FrmPickUp
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblPatente = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(12, 155);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(124, 54);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "CREAR";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(12, 53);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(124, 20);
            this.txtPatente.TabIndex = 1;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(12, 118);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(124, 20);
            this.txtModelo.TabIndex = 2;
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(50, 22);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(44, 13);
            this.lblPatente.TabIndex = 3;
            this.lblPatente.Text = "Patente";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(50, 89);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 4;
            this.lblModelo.Text = "Modelo";
            // 
            // FrmPickUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(154, 233);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblPatente);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.btnCrear);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmPickUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Pick up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.Label lblModelo;
    }
}

