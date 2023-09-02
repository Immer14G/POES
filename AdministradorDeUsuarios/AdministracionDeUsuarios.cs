using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministradorDeUsuarios
{
    public partial class AdministracionDeUsuarios : Form
    {
        public AdministracionDeUsuarios()
        {
            InitializeComponent();
        }

        private void UsuarioslistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            UsuarioslistBox.Items.Remove(UsuarioslistBox);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            UsuarioslistBox.Items.Add(IdtextBox.Text + NombretextBox.Text + TelefonotextBox.Text + EmailtextBox.Text+ ContraseñatextBox.Text+EstadoComboBox.Text);
          


            if (AgregarGroupBox.Text.Trim() == "")
            {
                errorId.SetError(AgregarGroupBox, "Introduce un id");
                errorNombre.SetError(AgregarGroupBox, "Introduce tu nombre");
                errorTelefono.SetError(AgregarGroupBox, "Introduce tu telefono");
                errorEmail.SetError(AgregarGroupBox, "Introduce tu email");
                errorContraseña.SetError(AgregarGroupBox, "Introduce una contraseña");
                errorEstado.SetError(AgregarGroupBox, "elige un estado");
                IdtextBox.Focus();
                NombretextBox.Focus();
                EmailtextBox.Focus();
                ContraseñatextBox.Focus();
                EstadoComboBox.Focus();



            }
            else
            {
                errorId.Clear();
                errorNombre.Clear();
                errorTelefono.Clear();
                errorEmail.Clear();
                errorContraseña.Clear();
                errorEstado.Clear();


            }
        }

        private void IdtextBox_TextChanged(object sender, EventArgs e)
        {
            string numero = IdtextBox.Text;

            if (string.IsNullOrWhiteSpace(numero))
            {
                MessageBox.Show("error");
            }
            else if (!int.TryParse(numero, out _))
            {
                MessageBox.Show("Escribe por favor numeros");
            }
            else
            {
                errorId.Clear();
            }
        }


        private void NombretextBox_TextChanged(object sender, EventArgs e)
        {
            string nombre = NombretextBox.Text;

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Escribe un nombre");
                errorNombre.SetError(NombretextBox, "Introduce tu nombre");
            }
            else
            {
                errorNombre.Clear();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void TelefonotextBox_Validated(object sender, EventArgs e)
        {
            string telefono = IdtextBox.Text;

            if (string.IsNullOrWhiteSpace(telefono))
            {
                MessageBox.Show("error");
            }
            else if (!int.TryParse(telefono, out _))
            {
                MessageBox.Show("Escribe por favor numeros");
            }
            else
            {
                errorId.Clear();
            }
        }
    }

 }

