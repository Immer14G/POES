using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGym.Formularios
{
    public partial class Agregar_Cliente : Form
    {
        private int n = 0;


        public Agregar_Cliente()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int n = dtvgDatos.Rows.Add();
            dtvgDatos.Rows[n].Cells[0].Value = NombretextBox.Text;
            dtvgDatos.Rows[n].Cells[1].Value = MembresiascomboBox.Text;
            dtvgDatos.Rows[n].Cells[2].Value = coachtextBox.Text;
            dtvgDatos.Rows[n].Cells[3].Value = comboBox1.Text;


            NombretextBox.Text = "";
            MembresiascomboBox.Text = "";
            coachtextBox.Text = "";
            comboBox1.Text = "";

            bool ok = true;
            if (NombretextBox.Text == "")

            {
                ok = false;
                errorProvider1.SetError(NombretextBox, "Ingresa nombre");
                errorProvider2.SetError(MembresiascomboBox, "elige");
            }


        }



        private void Agregar_Cliente_Load(object sender, EventArgs e)
        {
            MembresiascomboBox.Items.Add("Platinum 15$ ");
            MembresiascomboBox.Items.Add("Gold 25$  ");
            MembresiascomboBox.Items.Add("Diamante 30$");


        }



        private void NombretextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NombretextBox.Text))
            {
                MessageBox.Show("Un nuevo cliente se a Agregado\", \"Bienvenido\"");

            }

        }

        private void NombretextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("error no has rellenado el campo o escribe solo texto");
                e.Handled = true;
                return;
            }

        }

        private DataGridView GetDtvgDatos()
        {
            return dtvgDatos;
        }

        private void btnBorrar_Click_1(object sender, EventArgs e, DataGridView dtvgDatos)
        {
            if (n != -1)
            {
                dtvgDatos.Rows.RemoveAt(n);
                n = -1;

              
            }
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            NombretextBox.ReadOnly = !NombretextBox.ReadOnly;
            MembresiascomboBox.Enabled = !MembresiascomboBox.Enabled;
            coachtextBox.ReadOnly = !coachtextBox.ReadOnly;
            comboBox1.Enabled = !comboBox1.Enabled;

            btnEditar.Text = NombretextBox.ReadOnly ? "Editar" : "Guardar";

            if (!NombretextBox.ReadOnly)
            {
                NombretextBox.Focus();
            }
        }
    }
}