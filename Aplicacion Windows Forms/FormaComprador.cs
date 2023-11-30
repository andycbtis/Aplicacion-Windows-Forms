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
    public partial class FormaComprador : Form
    {
        public FormaComprador()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow renglon = (DataGridViewRow)dataGridViewlibros.Rows[0].Clone();

                renglon.Cells[0].Value = textid.Text;
                renglon.Cells[1].Value = textnombre.Text;
                renglon.Cells[2].Value = textautor.Text;
                renglon.Cells[3].Value = comboedicion.Text;
                renglon.Cells[4].Value = combogenero.Text;
                renglon.Cells[5].Value = textpaginas.Text;
                renglon.Cells[6].Value = texteditorial.Text;
                renglon.Cells[7].Value = textprecio.Text;
                // Validar que textpaginas y textprecio contengan valores numéricos
                if (int.TryParse(textpaginas.Text, out int paginas) && double.TryParse(textprecio.Text, out double precio))
                {
                    renglon.Cells[5].Value = paginas;
                    renglon.Cells[7].Value = precio;

                    renglon.Cells[6].Value = texteditorial.Text;
                    dataGridViewlibros.Rows.Add(renglon);

                    
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese valores numéricos válidos para páginas y precio.", "Agregando Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Agregando Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void buttoneliminar_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Desea eliminar el registro?";
            string titulo = "Eliminando el registro"; //titulo cuadro del dialogo

            if (!(dataGridViewlibros.CurrentRow is null)) // en caso de que no exista ningun renglon seleccionado
            {
                if (MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                { 
                    try
                    {
                        dataGridViewlibros.Rows.Remove(dataGridViewlibros.CurrentRow); // elimina el renglon
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Eliminando estudiante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar un renglon", "Eliminando Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }

        private void buttonmodificar_Click(object sender, EventArgs e)
        {

            if (dataGridViewlibros.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dataGridViewlibros.SelectedRows[0];

                // Modificar los valores en la fila seleccionada
                selectedRow.Cells["ID"].Value = textid.Text;
                selectedRow.Cells["Nombre"].Value = textnombre.Text;
                selectedRow.Cells["Autor"].Value = textautor.Text;
                selectedRow.Cells["Edicion"].Value = comboedicion.Text;
                selectedRow.Cells["Genero"].Value = combogenero.Text;

                // Validar que textpaginas y textprecio contengan valores numéricos
                if (int.TryParse(textpaginas.Text, out int paginas) && double.TryParse(textprecio.Text, out double precio))
                {
                    selectedRow.Cells["Paginas"].Value = paginas;
                    selectedRow.Cells["Precio"].Value = precio;
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese valores numéricos válidos para páginas y precio.", "Modificando Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // No continuar con la modificación si los valores no son válidos
                }

                selectedRow.Cells["Editorial"].Value = texteditorial.Text;

            }
            else
            {
                MessageBox.Show("Debes seleccionar un renglon", "Modificando datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
