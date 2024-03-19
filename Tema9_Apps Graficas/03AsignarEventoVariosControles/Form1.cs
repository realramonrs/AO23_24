using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03AsignarEventoVariosControles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            
            //Obtener Botón que ha generado el evento (que ha sido pulsado)
            Button btn = sender as Button;

            //Añada un uno a la caja de texto

            txtResultado.Text += btn.Text;
        }

       
    }
}
