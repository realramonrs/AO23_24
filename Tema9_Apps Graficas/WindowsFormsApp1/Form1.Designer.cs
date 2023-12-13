namespace WindowsFormsApp1
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
            this.txtLimiteInferior = new System.Windows.Forms.TextBox();
            this.txtLimiteSuperiors = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ejerciciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularNúmeroPrimoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediaDeUnArrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.txtArrayGenerado = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLimiteInferior
            // 
            this.txtLimiteInferior.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLimiteInferior.ForeColor = System.Drawing.Color.DarkRed;
            this.txtLimiteInferior.Location = new System.Drawing.Point(174, 65);
            this.txtLimiteInferior.Name = "txtLimiteInferior";
            this.txtLimiteInferior.Size = new System.Drawing.Size(67, 29);
            this.txtLimiteInferior.TabIndex = 0;
            // 
            // txtLimiteSuperiors
            // 
            this.txtLimiteSuperiors.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLimiteSuperiors.ForeColor = System.Drawing.Color.DarkRed;
            this.txtLimiteSuperiors.Location = new System.Drawing.Point(174, 115);
            this.txtLimiteSuperiors.Name = "txtLimiteSuperiors";
            this.txtLimiteSuperiors.Size = new System.Drawing.Size(67, 29);
            this.txtLimiteSuperiors.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Limite Inferior";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Limite Superior";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "Pulsame!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejerciciosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ejerciciosToolStripMenuItem
            // 
            this.ejerciciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcularNúmeroPrimoToolStripMenuItem,
            this.mediaDeUnArrayToolStripMenuItem});
            this.ejerciciosToolStripMenuItem.Name = "ejerciciosToolStripMenuItem";
            this.ejerciciosToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.ejerciciosToolStripMenuItem.Text = "Ejercicios";
            // 
            // calcularNúmeroPrimoToolStripMenuItem
            // 
            this.calcularNúmeroPrimoToolStripMenuItem.Name = "calcularNúmeroPrimoToolStripMenuItem";
            this.calcularNúmeroPrimoToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.calcularNúmeroPrimoToolStripMenuItem.Text = "1. Calcular Número Primo";
            // 
            // mediaDeUnArrayToolStripMenuItem
            // 
            this.mediaDeUnArrayToolStripMenuItem.Name = "mediaDeUnArrayToolStripMenuItem";
            this.mediaDeUnArrayToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.mediaDeUnArrayToolStripMenuItem.Text = "2. Media de un Array";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 179);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(273, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 55);
            this.button2.TabIndex = 7;
            this.button2.Text = "Generar Array";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtArrayGenerado
            // 
            this.txtArrayGenerado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArrayGenerado.ForeColor = System.Drawing.Color.DarkRed;
            this.txtArrayGenerado.Location = new System.Drawing.Point(389, 89);
            this.txtArrayGenerado.Name = "txtArrayGenerado";
            this.txtArrayGenerado.Size = new System.Drawing.Size(378, 29);
            this.txtArrayGenerado.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2",
            "4",
            "5",
            "7",
            "8",
            "9"});
            this.comboBox1.Location = new System.Drawing.Point(413, 188);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLimiteSuperiors);
            this.Controls.Add(this.txtArrayGenerado);
            this.Controls.Add(this.txtLimiteInferior);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLimiteInferior;
        private System.Windows.Forms.TextBox txtLimiteSuperiors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ejerciciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularNúmeroPrimoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediaDeUnArrayToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtArrayGenerado;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

