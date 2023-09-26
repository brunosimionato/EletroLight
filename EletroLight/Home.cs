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


        private Form formularioAberto = null;

        private void clienteMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new Cliente());
        }

        private void fornecedorMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new Fornecedor());
        }

        private void produtoMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new Produto());
        }

        private void pedidoMenuItem_Click_1(object sender, EventArgs e)
        {
            AbrirForm(new Pedido());
        }

        private void usuáriosMenuItem_Click_1(object sender, EventArgs e)
        {
            AbrirForm(new Usuarios());
        }

        private void CategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new Categoria());
        }

        private void AbrirForm(Form novoFormulario)
        {
            if (formularioAberto != null && !formularioAberto.IsDisposed)
            {
                formularioAberto.Close();
            }

            novoFormulario.Owner = this;
            novoFormulario.Show();
            formularioAberto = novoFormulario;
        }

        private void sairMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
