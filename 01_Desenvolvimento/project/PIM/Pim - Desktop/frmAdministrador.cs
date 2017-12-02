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

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {
            ListaMoradorTO x = new ListaMoradorTO();

            x = MoradorService.Listar();

            lstMoradores.Items.Add(x.Lista.ToString());
        }

        private void admCondominioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdministrarCondominio frmAdministrarCondominio1 = new frmAdministrarCondominio();
            frmAdministrarCondominio1.Show();
        }

        private void moradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMorador frmMorador1 = new frmMorador();
            frmMorador1.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmCadastrarColaborador cadastrarColaborador1 = new frmCadastrarColaborador();
            cadastrarColaborador1.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCadastrarMorador_Click(object sender, EventArgs e)
        {
            frmCadastrarMorador cadastrarMorador1 = new frmCadastrarMorador();
            cadastrarMorador1.Show();
        }
    }
}
