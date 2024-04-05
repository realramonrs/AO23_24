using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          /*  DateTime fechaUno = Convert.ToDateTime(txtDate1.Text).Date;
            DateTime fechaDos = Convert.ToDateTime(txtDate2.Text).Date;

            TimeSpan difFechas = fechaDos - fechaUno;

            int days = (int)difFechas.TotalDays;

            string dias = Convert.ToString(days);

            lbl1.Text = dias;*/
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;
            int dia = fecha.Day;
            int mes = fecha.Month;
            int anho = fecha.Year;
            String fechaCorta = fecha.ToShortDateString();
            String fechaLarga = fecha.ToLongDateString();
            String hora = fecha.ToShortTimeString();

            // Sumar 3 días a la fecha seleccionada
            DateTime fechaLimite = fecha.AddDays(3);

            //Mostrar la info en las cajas de texto
            txtDia.Text = dia.ToString();
            txtMes.Text = mes.ToString();
            txtAnho.Text = anho.ToString();
            txtFechaCorta.Text = fechaCorta;
            txtFechaLarga.Text = fechaLarga;

            DateTime hoy = DateTime.Today;

            TimeSpan ts = hoy - fecha;

           int dias =  ts.Days;
           txtDiasTranscurridos.Text = dias.ToString();
          
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
