using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01Introduccion
{
    public partial class Form1 : Form
    {
        //Zona de declaración de variables
        List<String> dnis = new List<string>();


        //******************* Fin zona declaración variables ************//


        public Form1()
        {
            InitializeComponent();
        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esto es increible!!","Bienvenido!!",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
        }

        private void btnGuardarDNI_Click(object sender, EventArgs e)
        {
            //Recoger lo que el usuario introdujo en la caja de texto
            String dni = txtDNI.Text;

            if (dni == "")
            {
                MessageBox.Show("Debe meter un DNI", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDNI.Focus(); //Poner el foco en la caja de texto que generó el error
                return; //Salir corriendo de la función
            }
           

                //Añadir el dni a la lista
                dni = dni.Trim();
                dnis.Add(dni);
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            Ejercicio1 ej1 = new Ejercicio1();
            ej1.ShowDialog();
        }

        private void eJERCICIO1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio1 ej1 = new Ejercicio1();
            ej1.Show();
        }
    }
}
