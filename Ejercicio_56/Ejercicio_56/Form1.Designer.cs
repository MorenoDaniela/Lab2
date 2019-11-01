namespace Ejercicio_56
{
    partial class Ej55
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stripMenuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGuardarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.strip = new System.Windows.Forms.StatusStrip();
            this.richText = new System.Windows.Forms.RichTextBox();
            this.EventoAbrir = new System.Windows.Forms.OpenFileDialog();
            this.EventoGuardarComo = new System.Windows.Forms.SaveFileDialog();
            this.EventoGuardar = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.CantCaracteres = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripMenuArchivo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(660, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stripMenuArchivo
            // 
            this.stripMenuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAbrir,
            this.btnGuardar,
            this.btnGuardarComo});
            this.stripMenuArchivo.Name = "stripMenuArchivo";
            this.stripMenuArchivo.Size = new System.Drawing.Size(60, 20);
            this.stripMenuArchivo.Text = "Archivo";
            
            // 
            // btnAbrir
            // 
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.btnAbrir.Size = new System.Drawing.Size(238, 22);
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.btnGuardar.Size = new System.Drawing.Size(238, 22);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnGuardarComo
            // 
            this.btnGuardarComo.Name = "btnGuardarComo";
            this.btnGuardarComo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.btnGuardarComo.Size = new System.Drawing.Size(238, 22);
            this.btnGuardarComo.Text = "Guardar Como";
            this.btnGuardarComo.Click += new System.EventHandler(this.BtnGuardarComo_Click);
            // 
            // strip
            // 
            this.strip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CantCaracteres});
            this.strip.Location = new System.Drawing.Point(0, 358);
            this.strip.Name = "strip";
            this.strip.Size = new System.Drawing.Size(660, 22);
            this.strip.TabIndex = 1;
            // 
            // richText
            // 
            this.richText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richText.Location = new System.Drawing.Point(0, 24);
            this.richText.Name = "richText";
            this.richText.Size = new System.Drawing.Size(660, 334);
            this.richText.TabIndex = 2;
            this.richText.Text = "";
            this.richText.TextChanged += new System.EventHandler(this.RichText_TextChanged);
            // 
            // EventoAbrir
            // 
            this.EventoAbrir.FileName = "EventoAbrir";
            // 
            // CantCaracteres
            // 
            this.CantCaracteres.Name = "CantCaracteres";
            this.CantCaracteres.Size = new System.Drawing.Size(10, 17);
            this.CantCaracteres.Text = " ";
            // 
            // Ej55
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 380);
            this.Controls.Add(this.richText);
            this.Controls.Add(this.strip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Ej55";
            this.Text = "Ej56";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.strip.ResumeLayout(false);
            this.strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stripMenuArchivo;
        private System.Windows.Forms.ToolStripMenuItem btnAbrir;
        private System.Windows.Forms.ToolStripMenuItem btnGuardar;
        private System.Windows.Forms.ToolStripMenuItem btnGuardarComo;
        private System.Windows.Forms.StatusStrip strip;
        private System.Windows.Forms.RichTextBox richText;
        private System.Windows.Forms.OpenFileDialog EventoAbrir;
        private System.Windows.Forms.SaveFileDialog EventoGuardarComo;
        private System.Windows.Forms.SaveFileDialog EventoGuardar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripStatusLabel CantCaracteres;
    }
}

