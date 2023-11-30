using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Windows_Forms.Resources
{
    public partial class FormaClientes : Form
    {
        public FormaClientes()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow renglon = (DataGridViewRow)dataGridView1.Rows[0].Clone();

                renglon.Cells[0].Value = textnombre.Text;
                renglon.Cells[1].Value = textid.Text;
                renglon.Cells[2].Value = textpaterno.Text;
                renglon.Cells[3].Value = textmaterno.Text;
                renglon.Cells[4].Value = textemail.Text;
                renglon.Cells[5].Value = textinstagram.Text;
                renglon.Cells[6].Value = textfacebook.Text;

                dataGridView1.Rows.Add(renglon);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Agregando Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
