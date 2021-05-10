using Personas_From.Biblioteca;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Personas_Form.Formulario
{
    public partial class FormLista : Form
    {
        private List<Persona> _personas;

        public FormLista()
        {
            InitializeComponent();
            _personas = new List<Persona>();
        }

        private void FormLista_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void FormLista_Load(object sender, EventArgs e)
        {
            for(int i = 1; i<10; i++)
            {
                Persona p = new Persona("mail"+i, "nombre"+i, "apellido"+i, 20 + i);
                AgregarPersona(p);
            }
            ActualizarLista();            
        }

        public void ActualizarLista()
        {
            listBoxPersonas.DataSource = null;
            listBoxPersonas.DataSource = _personas;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregarPersona formNuevaPersona = new FormAgregarPersona();
            formNuevaPersona.Owner = this;
            formNuevaPersona.Show();
            this.Hide();
        }

        public void AgregarPersona(Persona p)
        {
            if(p != null)
            {
                _personas.Add(p);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int i = listBoxPersonas.SelectedIndex;
            Persona p = (Persona) listBoxPersonas.SelectedItem;
            if (p != null)
            {
                _personas.Remove(p);
                ActualizarLista();
            }
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormEditarPersona fm = new FormEditarPersona((Persona) listBoxPersonas.SelectedItem);
            fm.Owner = this;
            fm.Show();
            this.Hide();
        }

        private void ListBoxPersonas_DoubleClick(object sender, EventArgs e)
        {
            btnEditar_Click(sender, e);
        }
    }
}
