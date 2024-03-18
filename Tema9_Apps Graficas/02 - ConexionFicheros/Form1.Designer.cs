namespace _02___ConexionFicheros
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
            this.txtTituloSerie = new System.Windows.Forms.TextBox();
            this.txtValoracion = new System.Windows.Forms.TextBox();
            this.lblTituloSerie = new System.Windows.Forms.Label();
            this.lblValoracion = new System.Windows.Forms.Label();
            this.btnGuardarValoracion = new System.Windows.Forms.Button();
            this.btnAbrirVisorSeries = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTituloSerie
            // 
            this.txtTituloSerie.Location = new System.Drawing.Point(233, 91);
            this.txtTituloSerie.Name = "txtTituloSerie";
            this.txtTituloSerie.Size = new System.Drawing.Size(100, 22);
            this.txtTituloSerie.TabIndex = 0;
            // 
            // txtValoracion
            // 
            this.txtValoracion.Location = new System.Drawing.Point(233, 171);
            this.txtValoracion.Name = "txtValoracion";
            this.txtValoracion.Size = new System.Drawing.Size(100, 22);
            this.txtValoracion.TabIndex = 1;
            // 
            // lblTituloSerie
            // 
            this.lblTituloSerie.AutoSize = true;
            this.lblTituloSerie.Location = new System.Drawing.Point(100, 97);
            this.lblTituloSerie.Name = "lblTituloSerie";
            this.lblTituloSerie.Size = new System.Drawing.Size(106, 16);
            this.lblTituloSerie.TabIndex = 2;
            this.lblTituloSerie.Text = "Titulo de la serie";
            // 
            // lblValoracion
            // 
            this.lblValoracion.AutoSize = true;
            this.lblValoracion.Location = new System.Drawing.Point(100, 177);
            this.lblValoracion.Name = "lblValoracion";
            this.lblValoracion.Size = new System.Drawing.Size(72, 16);
            this.lblValoracion.TabIndex = 3;
            this.lblValoracion.Text = "Valoracion";
            // 
            // btnGuardarValoracion
            // 
            this.btnGuardarValoracion.Location = new System.Drawing.Point(150, 225);
            this.btnGuardarValoracion.Name = "btnGuardarValoracion";
            this.btnGuardarValoracion.Size = new System.Drawing.Size(133, 45);
            this.btnGuardarValoracion.TabIndex = 4;
            this.btnGuardarValoracion.Text = "Guardar Valoracion";
            this.btnGuardarValoracion.UseVisualStyleBackColor = true;
            this.btnGuardarValoracion.Click += new System.EventHandler(this.btnGuardarValoracion_Click);
            // 
            // btnAbrirVisorSeries
            // 
            this.btnAbrirVisorSeries.Location = new System.Drawing.Point(453, 91);
            this.btnAbrirVisorSeries.Name = "btnAbrirVisorSeries";
            this.btnAbrirVisorSeries.Size = new System.Drawing.Size(111, 43);
            this.btnAbrirVisorSeries.TabIndex = 5;
            this.btnAbrirVisorSeries.Text = "Visor Series";
            this.btnAbrirVisorSeries.UseVisualStyleBackColor = true;
            this.btnAbrirVisorSeries.Click += new System.EventHandler(this.btnAbrirVisorSeries_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAbrirVisorSeries);
            this.Controls.Add(this.btnGuardarValoracion);
            this.Controls.Add(this.lblValoracion);
            this.Controls.Add(this.lblTituloSerie);
            this.Controls.Add(this.txtValoracion);
            this.Controls.Add(this.txtTituloSerie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTituloSerie;
        private System.Windows.Forms.TextBox txtValoracion;
        private System.Windows.Forms.Label lblTituloSerie;
        private System.Windows.Forms.Label lblValoracion;
        private System.Windows.Forms.Button btnGuardarValoracion;
        private System.Windows.Forms.Button btnAbrirVisorSeries;
    }
}

