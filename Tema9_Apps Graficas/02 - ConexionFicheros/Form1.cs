using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _02___ConexionFicheros
{
    public partial class Form1 : Form
    {
        //Zona declaración variables
        String ruta = Directory.GetCurrentDirectory() + "\\series.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardarValoracion_Click(object sender, EventArgs e)
        {
            String titulo = txtTituloSerie.Text;
            int valoracion = int.Parse(txtValoracion.Text);

            //Escribimos en el fichero
            StreamWriter escritor = new StreamWriter(ruta,true);
            escritor.WriteLine(titulo + "*" + valoracion);
            escritor.Close();
        }

        private void btnAbrirVisorSeries_Click(object sender, EventArgs e)
        {
            VisorSeries vs = new VisorSeries();
            vs.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
