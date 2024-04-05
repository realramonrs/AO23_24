namespace _02_PictureBox
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
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtAnho = new System.Windows.Forms.TextBox();
            this.txtFechaLarga = new System.Windows.Forms.TextBox();
            this.txtDiasTranscurridos = new System.Windows.Forms.TextBox();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblAnho = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtFechaCorta = new System.Windows.Forms.TextBox();
            this.lblFechaCorta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(626, 22);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(100, 22);
            this.txtDia.TabIndex = 0;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(632, 89);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(100, 22);
            this.txtMes.TabIndex = 1;
            // 
            // txtAnho
            // 
            this.txtAnho.Location = new System.Drawing.Point(631, 155);
            this.txtAnho.Name = "txtAnho";
            this.txtAnho.Size = new System.Drawing.Size(100, 22);
            this.txtAnho.TabIndex = 2;
            // 
            // txtFechaLarga
            // 
            this.txtFechaLarga.Location = new System.Drawing.Point(633, 231);
            this.txtFechaLarga.Name = "txtFechaLarga";
            this.txtFechaLarga.Size = new System.Drawing.Size(283, 22);
            this.txtFechaLarga.TabIndex = 3;
            // 
            // txtDiasTranscurridos
            // 
            this.txtDiasTranscurridos.Location = new System.Drawing.Point(633, 379);
            this.txtDiasTranscurridos.Name = "txtDiasTranscurridos";
            this.txtDiasTranscurridos.Size = new System.Drawing.Size(100, 22);
            this.txtDiasTranscurridos.TabIndex = 4;
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(507, 30);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(31, 16);
            this.lblDia.TabIndex = 6;
            this.lblDia.Text = "Día ";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(507, 95);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(36, 16);
            this.lblMes.TabIndex = 6;
            this.lblMes.Text = "Mes:";
            // 
            // lblAnho
            // 
            this.lblAnho.AutoSize = true;
            this.lblAnho.Location = new System.Drawing.Point(507, 161);
            this.lblAnho.Name = "lblAnho";
            this.lblAnho.Size = new System.Drawing.Size(34, 16);
            this.lblAnho.TabIndex = 6;
            this.lblAnho.Text = "Año:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(507, 231);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(83, 16);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha Larga";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(501, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Días hasta hoy";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(279, 22);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtFechaCorta
            // 
            this.txtFechaCorta.Location = new System.Drawing.Point(633, 286);
            this.txtFechaCorta.Name = "txtFechaCorta";
            this.txtFechaCorta.Size = new System.Drawing.Size(100, 22);
            this.txtFechaCorta.TabIndex = 3;
            this.txtFechaCorta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblFechaCorta
            // 
            this.lblFechaCorta.AutoSize = true;
            this.lblFechaCorta.Location = new System.Drawing.Point(507, 286);
            this.lblFechaCorta.Name = "lblFechaCorta";
            this.lblFechaCorta.Size = new System.Drawing.Size(80, 16);
            this.lblFechaCorta.TabIndex = 6;
            this.lblFechaCorta.Text = "Fecha Corta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFechaCorta);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblAnho);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.txtDiasTranscurridos);
            this.Controls.Add(this.txtFechaCorta);
            this.Controls.Add(this.txtFechaLarga);
            this.Controls.Add(this.txtAnho);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtDia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtAnho;
        private System.Windows.Forms.TextBox txtFechaLarga;
        private System.Windows.Forms.TextBox txtDiasTranscurridos;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblAnho;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtFechaCorta;
        private System.Windows.Forms.Label lblFechaCorta;
    }
}

