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

        private Form Form = null;

        // ABRE FORM CLIENTE
        private void clienteMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new Cliente());
        }

        // ABRE FORM FORNECEDOR
        private void fornecedorMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new Fornecedor());
        }

        // ABRE FORM PRODUTO
        private void produtoMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new Produto());
        }

        // ABRE FORM PEDIDO
        private void pedidoMenuItem_Click_1(object sender, EventArgs e)
        {
            AbrirForm(new Pedido());
        }

        // ABRE FORM USUÁRIOS
        private void usuáriosMenuItem_Click_1(object sender, EventArgs e)
        {
            AbrirForm(new Usuarios());
        }

        // ABRE FORM CATEGORIAS
        private void CategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new Categoria());
        }

        // ABRE FORM DE PEDIDOS EXCLUÍDOS 
        private void pedidosExcluidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new PedidoExcluido());
        }

        // BOTÃO DE SAIR
        private void sairMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // FECHA A APLICAÇÃO AO CLICAR NO BOTÃO SAIR SE UM FORM ESTIVER SOBREPOSTO A HOME
        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        // FUNÇÃO QUE SUBSTITUI O FORM ABERTO POR OUTRO 
        private void AbrirForm(Form novoForm)
        {
            if (Form != null && !Form.IsDisposed)
            {
                Form.Close();
            }

            novoForm.Owner = this;
            novoForm.Show();
            Form = novoForm;
        }

    }
}
