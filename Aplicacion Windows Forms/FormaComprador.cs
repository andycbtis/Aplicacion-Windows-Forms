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
                DataGridViewRow renglon = (DataGridViewRow)dataGridViewcatalogo.Rows[0].Clone();

                renglon.Cells[0].Value = textnombre.Text;
                renglon.Cells[1].Value = texttelefono.Text;
                renglon.Cells[2].Value = combomascota.Text;
                renglon.Cells[3].Value = combocategoria.Text;
                renglon.Cells[4].Value = comboproducto.Text;
                renglon.Cells[5].Value = textprecio.Text;
                renglon.Cells[6].Value = numericUpDowncan.Text;

                dataGridViewcatalogo.Rows.Add(renglon);
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

            if (!(dataGridViewcatalogo.CurrentRow is null)) // en caso de que no exista ningun renglon seleccionado
            {
                if (MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                { 
                    try
                    {
                        dataGridViewcatalogo.Rows.Remove(dataGridViewcatalogo.CurrentRow); // elimina el renglon
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
            if (dataGridViewcatalogo.SelectedRows.Count <= 0) // en caso de que no exista renglon seleccionado
            {
                MessageBox.Show("Debes seleccionar un renglon", "Modificando datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                textnombre.Text = dataGridViewcatalogo.CurrentRow.Cells["Nombre"].Value.ToString();
                texttelefono.Text = dataGridViewcatalogo.CurrentRow.Cells["Telefono"].Value.ToString();
                combomascota.Text = dataGridViewcatalogo.CurrentRow.Cells["Mascota"].Value.ToString();
                combocategoria.Text = dataGridViewcatalogo.CurrentRow.Cells["Categoria"].Value.ToString();
                comboproducto.Text = dataGridViewcatalogo.CurrentRow.Cells["Producto"].Value.ToString();
                textprecio.Text = dataGridViewcatalogo.CurrentRow.Cells["Precio"].Value.ToString();
                numericUpDowncan.Text = dataGridViewcatalogo.CurrentRow.Cells["Cantidad"].Value.ToString();
            }

            }
    }
}
