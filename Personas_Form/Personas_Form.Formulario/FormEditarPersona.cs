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
    public partial class FormEditarPersona : FormPersona
    {
        private Persona _persona;
        public FormEditarPersona(Persona p)
        {
            InitializeComponent();
            _persona = p;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _persona.Nombre = txtNombre.Text;
            _persona.Apellido = txtApellido.Text;
            _persona.Email = txtEmail.Text;
            _persona.Edad = int.Parse(txtEdad.Text);

            Owner.Show();
            ((FormLista)Owner).ActualizarLista();
            this.Close();
        }

        private void FormEditarPersona_Load(object sender, EventArgs e)
        {
            txtNombre.Text = _persona.Nombre;
            txtApellido.Text = _persona.Apellido;
            txtEmail.Text = _persona.Email;
            txtEdad.Text = _persona.Edad.ToString();
        }
    }
}
