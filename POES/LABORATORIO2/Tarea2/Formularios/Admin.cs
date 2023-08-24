using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoGym.Formularios;

namespace ProyectoGym
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form formulario= new Agregar_Cliente();
            formulario.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
          
           
        }
    }
}
