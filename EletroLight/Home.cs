using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EletroLight
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente frm = new Cliente();
            frm.Show();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fornecedor frm = new Fornecedor();
            frm.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produto frm = new Produto();
            frm.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categoria frm = new Categoria();
            frm.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pedidoMenuItem_Click(object sender, EventArgs e)
        {
            Pedido frm = new Pedido();
            frm.Show();
        }

        private void usuáriosMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios frm = new Usuarios();
            frm.Show();
        }

        private void MenuHome_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void novasCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categoria frm = new Categoria();
            frm.Show();
        }
    }
}
