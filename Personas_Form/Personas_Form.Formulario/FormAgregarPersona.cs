using Personas_From.Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personas_Form.Formulario
{
    public partial class FormAgregarPersona : FormPersona
    {
        public FormAgregarPersona()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ((FormLista)Owner).AgregarPersona(new Persona(txtEmail.Text, txtNombre.Text, txtApellido.Text, int.Parse(txtEdad.Text)));
            ((FormLista)Owner).ActualizarLista();
            Owner.Show();
            this.Close();
        }
    }
}
