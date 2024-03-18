using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02___ConexionFicheros
{
    public partial class VisorSeries : Form
    {
        public VisorSeries()
        {
            InitializeComponent();
        }

        private void VisorSeries_Load(object sender, EventArgs e)
        {
            StreamReader lector = new StreamReader(Globals.ruta);

            string line = "";
            while(line!= null)
            {
                line =lector.ReadLine();
                //Añadirlo al listbox
                if (line != null)
                {
                    listBox1.Items.Add(line.Split('*')[0]);
                }
            }
            lector.Close();
        }
    }
}
