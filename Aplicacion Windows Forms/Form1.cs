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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
       
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private int intentos = 0;
        private const string usuarioCorrecto = "Andy";
        private const string contrasenaCorrecta = "andy123";
        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textusuario.Text;
            string contrasena = textcontrasena.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show("Los campos no pueden estar vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (usuario.Length < 3)
            {
                MessageBox.Show("La longitud del usuario debe ser al menos 3 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (usuario == usuarioCorrecto && contrasena != contrasenaCorrecta)
            {
                MessageBox.Show("Usuario correcto, contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                intentos++;

                if (intentos >= 3)
                {
                    MessageBox.Show("Has alcanzado el máximo de intentos. La aplicación se cerrará.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            else if (usuario != usuarioCorrecto && contrasena == contrasenaCorrecta)
            {
                MessageBox.Show("Usuario incorrecto, contraseña correcta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                intentos++;

                if (intentos >= 3)
                {
                    MessageBox.Show("Has alcanzado el máximo de intentos. La aplicación se cerrará.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            else if (usuario == usuarioCorrecto && contrasena == contrasenaCorrecta)
            {
                MessageBox.Show("¡Bienvenido!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Crear una instancia del formulario que deseas abrir (reemplaza 'FormTienda' con el nombre real de tu formulario)
                FormaHome home = new FormaHome();

                // Mostrar el formulario
                home.Show();

                // Ocultar la ventana de inicio de sesión
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario y contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                intentos++;

                if (intentos >= 3)
                {
                    MessageBox.Show("Has alcanzado el máximo de intentos. La aplicación se cerrará.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }


            }


            }

        private void button2_Click(object sender, EventArgs e)
        {
            FormaRegistro registro = new FormaRegistro();
            registro.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textusuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
