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
    public partial class frmAdministrador : Form
    {
        public frmAdministrador()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmCadastrarColaborador cadastrarColaborador1 = new frmCadastrarColaborador();
            cadastrarColaborador1.Show();
        }

        private void btnCadastrarMorador_Click(object sender, EventArgs e)
        {
            frmCadastrarMorador cadastrarMorador1 = new frmCadastrarMorador();
            cadastrarMorador1.Show();
        }

        private void admCondomínioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdministrarCondominio admCondominio = new frmAdministrarCondominio();
            admCondominio.Show();
        }

        private void moradorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMorador janelaMorador = new frmMorador();
            janelaMorador.Show();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            frmCadastrarColaborador janelaCadastroColaborador = new frmCadastrarColaborador();
            janelaCadastroColaborador.Show();
        }
    }
}
