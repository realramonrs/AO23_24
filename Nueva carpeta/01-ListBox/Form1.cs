using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           //Obtener item seleccionado por el usuario
           String jugador = listBox1.SelectedItem.ToString();
            MessageBox.Show(jugador);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Obtener el equipo
            String equipo = comboBox1.SelectedItem.ToString();

            switch (equipo)
            {
                case "Real Madrid":
                    txtEstadio.Text = "Santiago Bernabeu";
                    break;
                case "RC Celta":
                    txtEstadio.Text = "Balaídos";
                    break;
                default:
                    txtEstadio.Text = "";
                    break;
            }
        }

        private void chkAspas_CheckedChanged(object sender, EventArgs e)
        {
            if(chkAspas.Checked)
            {
                //Añadimos al listbox2
                listBox2.Items.Add(chkAspas.Text);
            }
            else
            {
                listBox2.Items.Remove(chkAspas.Text);
            }
          
        }

        private void chkRenato_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRenato.Checked)
            {
                listBox2.Items.Add(chkRenato.Text);
            }
            else
            {
                listBox2.Items.Remove(chkRenato.Text);
            }
        }

        private void chkUnai_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUnai.Checked)
            {
                listBox2.Items.Add(chkUnai.Text);
            }
            else
            {
                listBox2.Items.Remove(chkUnai.Text);
            }
        }

        private void btnEliminarJugador_Click(object sender, EventArgs e)
        {
            //Obtener jugador
            if (listBox2.SelectedIndex > -1)
            {
                String jugador = listBox2.SelectedItem.ToString();


                DialogResult respuesta = MessageBox.Show("Está seguro??", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    listBox2.Items.Remove(jugador);
                    //Desmarcar el checkbox correspondiente
                    if (chkAspas.Text == jugador)
                    {
                        chkAspas.Checked = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe de seleccionar al menos un jugador");
            }


           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
