using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Aplicacion_Windows_Forms
{
    public partial class Formaclientes : Form
    {
        private bool EsCorreoElectronicoValido(string correo)
        {
            if (string.IsNullOrWhiteSpace(correo))
                return false;

            // Expresión regular para validar el formato de un correo electrónico
            string patronCorreoElectronico = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            return Regex.IsMatch(correo, patronCorreoElectronico);
        }
        private bool EsNumeroValido(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;


            return input.All(char.IsDigit);
        }
        public Formaclientes()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow renglon = (DataGridViewRow)dataGridViewempleado.Rows[0].Clone();

                renglon.Cells[0].Value = textid.Text;
                renglon.Cells[1].Value = textnombre.Text;
                renglon.Cells[2].Value = textpaterno.Text;
                renglon.Cells[3].Value = textmaterno.Text;
                renglon.Cells[4].Value = texttelefono.Text;
                renglon.Cells[5].Value = textemail.Text;
                renglon.Cells[6].Value = textinstagram.Text;
                renglon.Cells[7].Value = textfacebook.Text;

                dataGridViewempleado.Rows.Add(renglon);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Agregando Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Desea eliminar el registro?";
            string titulo = "Eliminando el registro"; //titulo cuadro del dialogo

            if (!(dataGridViewempleado.CurrentRow is null)) // en caso de que no exista ningun renglon seleccionado
            {
                if (MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        dataGridViewempleado.Rows.Remove(dataGridViewempleado.CurrentRow); // elimina el renglon
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Eliminando Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar un renglon", "Eliminando Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Formaempleado_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (dataGridViewempleado.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dataGridViewempleado.SelectedRows[0];

                    // Validar que texttelefono contenga solo números
                    if (!EsNumeroValido(texttelefono.Text))
                    {
                        MessageBox.Show("Por favor, ingrese un número de teléfono válido.", "Modificando Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Validar que textemail contenga un correo electrónico válido
                    if (!EsCorreoElectronicoValido(textemail.Text))
                    {
                        MessageBox.Show("Por favor, ingrese un correo electrónico válido.", "Modificando Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Modificar los valores en la fila seleccionada
                    selectedRow.Cells["ID"].Value = textid.Text;
                    selectedRow.Cells["Nombre"].Value = textnombre.Text;
                    selectedRow.Cells["Paterno"].Value = textpaterno.Text;
                    selectedRow.Cells["Materno"].Value = textmaterno.Text;
                    selectedRow.Cells["Telefono"].Value = texttelefono.Text;
                    selectedRow.Cells["email"].Value = textemail.Text;
                    selectedRow.Cells["instagram"].Value = textinstagram.Text;
                    selectedRow.Cells["facebook"].Value = textfacebook.Text;

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Modificando Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar un renglon", "Modificando datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

    }
}
