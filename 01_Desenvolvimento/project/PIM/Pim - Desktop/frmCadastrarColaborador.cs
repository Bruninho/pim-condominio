using PIM.Database.TO;
using PIM.Service.Services;
using System;
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
    public partial class frmCadastrarColaborador : Form
    {
        public frmCadastrarColaborador()
        {
            InitializeComponent();
        }

        private void btnSalvarColaborador_Click(object sender, EventArgs e)
        {
            ColaboradorTO a = new ColaboradorTO();
            a.Nome = txtNomeColab.Text;
        }

    }
}
