namespace _01_ListBox
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtEstadio = new System.Windows.Forms.TextBox();
            this.lblEstadio = new System.Windows.Forms.Label();
            this.chkAspas = new System.Windows.Forms.CheckBox();
            this.chkRenato = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkUnai = new System.Windows.Forms.CheckBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnEliminarJugador = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Iago Aspas",
            "Vinicius",
            "Gabri",
            "Morata",
            "Williams Iñaki"});
            this.listBox1.Location = new System.Drawing.Point(54, 110);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(156, 228);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ath Bilbao",
            "Real Madrid",
            "RC Celta",
            "Atl Madrid",
            "FC Barcelona"});
            this.comboBox1.Location = new System.Drawing.Point(285, 114);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Escoja un equipo";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtEstadio
            // 
            this.txtEstadio.Location = new System.Drawing.Point(287, 262);
            this.txtEstadio.Name = "txtEstadio";
            this.txtEstadio.Size = new System.Drawing.Size(157, 22);
            this.txtEstadio.TabIndex = 2;
            // 
            // lblEstadio
            // 
            this.lblEstadio.AutoSize = true;
            this.lblEstadio.Location = new System.Drawing.Point(297, 222);
            this.lblEstadio.Name = "lblEstadio";
            this.lblEstadio.Size = new System.Drawing.Size(53, 16);
            this.lblEstadio.TabIndex = 3;
            this.lblEstadio.Text = "Estadio";
            // 
            // chkAspas
            // 
            this.chkAspas.AutoSize = true;
            this.chkAspas.Location = new System.Drawing.Point(47, 65);
            this.chkAspas.Name = "chkAspas";
            this.chkAspas.Size = new System.Drawing.Size(98, 20);
            this.chkAspas.TabIndex = 4;
            this.chkAspas.Text = "Iago Aspas";
            this.chkAspas.UseVisualStyleBackColor = true;
            this.chkAspas.CheckedChanged += new System.EventHandler(this.chkAspas_CheckedChanged);
            // 
            // chkRenato
            // 
            this.chkRenato.AutoSize = true;
            this.chkRenato.Location = new System.Drawing.Point(47, 111);
            this.chkRenato.Name = "chkRenato";
            this.chkRenato.Size = new System.Drawing.Size(112, 20);
            this.chkRenato.TabIndex = 5;
            this.chkRenato.Text = "Renato Tapia";
            this.chkRenato.UseVisualStyleBackColor = true;
            this.chkRenato.CheckedChanged += new System.EventHandler(this.chkRenato_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkUnai);
            this.groupBox1.Controls.Add(this.chkRenato);
            this.groupBox1.Controls.Add(this.chkAspas);
            this.groupBox1.Location = new System.Drawing.Point(550, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 196);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configure su equipo";
            // 
            // chkUnai
            // 
            this.chkUnai.AutoSize = true;
            this.chkUnai.Location = new System.Drawing.Point(47, 150);
            this.chkUnai.Name = "chkUnai";
            this.chkUnai.Size = new System.Drawing.Size(98, 20);
            this.chkUnai.TabIndex = 6;
            this.chkUnai.Text = "Unai Núñez";
            this.chkUnai.UseVisualStyleBackColor = true;
            this.chkUnai.CheckedChanged += new System.EventHandler(this.chkUnai_CheckedChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(803, 43);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(151, 196);
            this.listBox2.TabIndex = 7;
            // 
            // btnEliminarJugador
            // 
            this.btnEliminarJugador.Location = new System.Drawing.Point(800, 273);
            this.btnEliminarJugador.Name = "btnEliminarJugador";
            this.btnEliminarJugador.Size = new System.Drawing.Size(154, 51);
            this.btnEliminarJugador.TabIndex = 8;
            this.btnEliminarJugador.Text = "Eliminar Jugador";
            this.btnEliminarJugador.UseVisualStyleBackColor = true;
            this.btnEliminarJugador.Click += new System.EventHandler(this.btnEliminarJugador_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(48, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(103, 20);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(50, 71);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(103, 20);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(281, 327);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 116);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnEliminarJugador);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblEstadio);
            this.Controls.Add(this.txtEstadio);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtEstadio;
        private System.Windows.Forms.Label lblEstadio;
        private System.Windows.Forms.CheckBox chkAspas;
        private System.Windows.Forms.CheckBox chkRenato;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkUnai;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnEliminarJugador;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

