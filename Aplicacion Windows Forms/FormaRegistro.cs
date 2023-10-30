using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplicacion_Windows_Forms;

namespace Aplicacion_Windows_Forms
{
    public partial class FormaRegistro : Form
    {
        public FormaRegistro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = textnombre.Text.Trim();
            string email = textemail.Text.Trim();
            string contrasena = textcontrasena.Text.Trim();
            string confirmar = textconfirmar.Text.Trim();
            string telefono = texttelefono.Text.Trim();

            // Validar que todos los campos no sean nulos ni vacíos
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(contrasena) || string.IsNullOrEmpty(confirmar) || string.IsNullOrEmpty(telefono))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validar que el número de celular solo contenga números
            if (!int.TryParse(telefono, out _))
            {
                MessageBox.Show("El número de celular solo puede contener números enteros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("¡Bienvenido, Ingresa al sistema!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Form1 form = new Form1();
            form.Show();
        }

        private void FormaRegistro_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textcontrasena_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
