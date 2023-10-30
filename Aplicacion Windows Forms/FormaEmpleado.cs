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
    public partial class Formaempleado : Form
    {
        public Formaempleado()
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

                renglon.Cells[0].Value = textnombre.Text;
                renglon.Cells[1].Value = textfecha.Text;
                renglon.Cells[2].Value = texttelefono.Text;
                renglon.Cells[3].Value = textcorreo.Text;
                renglon.Cells[4].Value = combopuesto.Text;
                renglon.Cells[5].Value = texthorario.Text;
                renglon.Cells[6].Value = textsalario.Text;

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
    }
}
