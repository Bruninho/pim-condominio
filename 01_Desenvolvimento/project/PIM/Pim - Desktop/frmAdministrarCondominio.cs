﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim___Desktop
{
    public partial class frmAdministrarCondominio : Form
    {
        public frmAdministrarCondominio()
        {
            InitializeComponent();
        }

        private void btnNovoMorador_Click(object sender, EventArgs e)
        {
            frmCadastrarMorador cadastrarMorador = new frmCadastrarMorador();
            cadastrarMorador.Show();
        }
    }
}
