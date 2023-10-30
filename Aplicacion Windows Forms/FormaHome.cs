using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Windows_Forms
{
    public partial class FormaHome : Form
    {
        public FormaHome()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void catalogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formaempleado enpleado = new Formaempleado();
            enpleado.Show();
            
        }

        private void compradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaComprador comprador = new FormaComprador();
            comprador.Show();
           
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaServicios servicios = new FormaServicios();
            servicios.Show();
            

        }

        private void FormaHome_Load(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
