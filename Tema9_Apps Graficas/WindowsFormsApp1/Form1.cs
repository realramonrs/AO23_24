using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //Declaramos el array
        int[] matriz = new int[10];

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Debe introducir sus datos!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Recoger los datos que el usuario introdujo
            int limInferior = int.Parse(txtLimiteInferior.Text);
            int limSuperior = int.Parse(txtLimiteSuperiors.Text);
            //Generamos numeros aleatorios y los guardamos en el array
            Random generador = new Random();

            for(int i = 0; i< matriz.Length; i++)
            {
                matriz[i] = generador.Next(limInferior, limSuperior + 1);
            }
            String matrizGenerada = "";
            for(int i = 0; i < matriz.Length; i++)
            {
                matrizGenerada += matriz[i] +" , ";
            }
            //  MessageBox.Show("Array Generado: " + matrizGenerada);
            txtArrayGenerado.Text = matrizGenerada;
        }
    }
}
