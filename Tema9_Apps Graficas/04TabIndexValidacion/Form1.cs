using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04TabIndexValidacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardarDatos_Click(object sender, EventArgs e)
        {
            //Recogemos los datos introducidos
            String nombre = txtNombre.Text;
            String telefono = txtTelefono.Text;
            String email = txtEmail.Text;
            String dni = txtDNI.Text; ;

            //Validarlos
            if(nombre.Length == 0)
            {
                MessageBox.Show("Debe de introducir un nombre.");
                txtNombre.BackColor = Color.CadetBlue;
                txtNombre.Focus();
                return;
            }
            else if(telefono.Length == 0)
            {
                MessageBox.Show("Debe de introducir un teléfono.");
                txtTelefono.BackColor = Color.CadetBlue;
                txtTelefono.Focus();
                return;
            }
            else if(email.Length == 0)
            {
                MessageBox.Show("Debe de introducir un correo.");
                txtEmail.BackColor = Color.CadetBlue;
                txtEmail.Focus();
                return;
            }
            else if(dni.Length == 0)
            {
                MessageBox.Show("Debe de introducir un dni.\n Esres muy despistados");
                txtDNI.BackColor = Color.CadetBlue;
                txtDNI.Focus();
                return;
            }
            else
            {
                //Validar el email como profesionales
                if(!Regex.IsMatch(email, "^(([\\w-]+\\.)+[\\w-]+|([a-zA-Z]{1}|[\\w-]{2,}))@(([a-zA-Z]+[\\w-]+\\.){1,2}[a-zA-Z]{2,4})$"))
                {
                    MessageBox.Show("El email no tiene el formato correcto");
                    txtEmail.Focus();
                    txtEmail.SelectAll();
                    
                    return;
                }
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            TextBox txtDisparador = (TextBox)sender;
            txtDisparador.BackColor = Color.White;
        }
    }
}
