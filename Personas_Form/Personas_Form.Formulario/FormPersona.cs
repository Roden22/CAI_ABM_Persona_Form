﻿using Personas_From.Biblioteca;
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
    public partial class FormPersona : Form
    {
        public FormPersona()
        {
            InitializeComponent();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

    }
}
