using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerrarIndice_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void verArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {

                if (item.GetType() == typeof(FormVerArticulos))
                {
                    MessageBox.Show("ya esta una ventana abierta");
                    return;
                }
            }

            FormVerArticulos windowViewFormDB = new FormVerArticulos();
            windowViewFormDB.Show();
        }
    }
}
