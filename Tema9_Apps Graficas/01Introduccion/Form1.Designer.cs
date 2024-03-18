namespace _01Introduccion
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
            this.btnPulsar = new System.Windows.Forms.Button();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.btnGuardarDNI = new System.Windows.Forms.Button();
            this.btnEjercicio1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eJERCICIO1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eJERCICIO2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPulsar
            // 
            this.btnPulsar.Location = new System.Drawing.Point(121, 111);
            this.btnPulsar.Name = "btnPulsar";
            this.btnPulsar.Size = new System.Drawing.Size(121, 62);
            this.btnPulsar.TabIndex = 0;
            this.btnPulsar.Text = "Pulsame";
            this.btnPulsar.UseVisualStyleBackColor = true;
            this.btnPulsar.Click += new System.EventHandler(this.btnPulsar_Click);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(127, 52);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(39, 22);
            this.lblDNI.TabIndex = 1;
            this.lblDNI.Text = "DNI:";
            // 
            // txtDNI
            // 
            this.txtDNI.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtDNI.Location = new System.Drawing.Point(227, 52);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(163, 28);
            this.txtDNI.TabIndex = 2;
            // 
            // btnGuardarDNI
            // 
            this.btnGuardarDNI.Location = new System.Drawing.Point(304, 111);
            this.btnGuardarDNI.Name = "btnGuardarDNI";
            this.btnGuardarDNI.Size = new System.Drawing.Size(108, 62);
            this.btnGuardarDNI.TabIndex = 3;
            this.btnGuardarDNI.Text = "Guardar DNI";
            this.btnGuardarDNI.UseVisualStyleBackColor = true;
            this.btnGuardarDNI.Click += new System.EventHandler(this.btnGuardarDNI_Click);
            // 
            // btnEjercicio1
            // 
            this.btnEjercicio1.Location = new System.Drawing.Point(121, 208);
            this.btnEjercicio1.Name = "btnEjercicio1";
            this.btnEjercicio1.Size = new System.Drawing.Size(109, 65);
            this.btnEjercicio1.TabIndex = 4;
            this.btnEjercicio1.Text = "Ejercicio 1";
            this.btnEjercicio1.UseVisualStyleBackColor = true;
            this.btnEjercicio1.Click += new System.EventHandler(this.btnEjercicio1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eJERCICIO1ToolStripMenuItem,
            this.eJERCICIO2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eJERCICIO1ToolStripMenuItem
            // 
            this.eJERCICIO1ToolStripMenuItem.Name = "eJERCICIO1ToolStripMenuItem";
            this.eJERCICIO1ToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.eJERCICIO1ToolStripMenuItem.Text = "EJERCICIO 1";
            this.eJERCICIO1ToolStripMenuItem.Click += new System.EventHandler(this.eJERCICIO1ToolStripMenuItem_Click);
            // 
            // eJERCICIO2ToolStripMenuItem
            // 
            this.eJERCICIO2ToolStripMenuItem.Name = "eJERCICIO2ToolStripMenuItem";
            this.eJERCICIO2ToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.eJERCICIO2ToolStripMenuItem.Text = "EJERCICIO 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEjercicio1);
            this.Controls.Add(this.btnGuardarDNI);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.btnPulsar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPulsar;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Button btnGuardarDNI;
        private System.Windows.Forms.Button btnEjercicio1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eJERCICIO1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eJERCICIO2ToolStripMenuItem;
    }
}

