using System.Drawing;
using System.Windows.Forms;

namespace EletroLight
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            cadastroMenuStrip = new ToolStripMenuItem();
            clienteMenuItem = new ToolStripMenuItem();
            fornecedorMenuItem = new ToolStripMenuItem();
            produtoMenuItem = new ToolStripMenuItem();
            movMenuStrip = new ToolStripMenuItem();
            pedidoMenuItem = new ToolStripMenuItem();
            segurançaMenuStrip = new ToolStripMenuItem();
            usuáriosMenuItem = new ToolStripMenuItem();
            novasCategoriasToolStripMenuItem = new ToolStripMenuItem();
            sairMenuItem = new ToolStripMenuItem();
            MenuHome = new MenuStrip();
            MenuHome.SuspendLayout();
            SuspendLayout();
            // 
            // cadastroMenuStrip
            // 
            cadastroMenuStrip.Checked = true;
            cadastroMenuStrip.CheckState = CheckState.Indeterminate;
            cadastroMenuStrip.DropDownItems.AddRange(new ToolStripItem[] { clienteMenuItem, fornecedorMenuItem, produtoMenuItem });
            cadastroMenuStrip.ForeColor = Color.Black;
            cadastroMenuStrip.ImageTransparentColor = SystemColors.ActiveCaptionText;
            cadastroMenuStrip.Name = "cadastroMenuStrip";
            cadastroMenuStrip.Size = new Size(80, 24);
            cadastroMenuStrip.Text = "Cadastro";
            // 
            // clienteMenuItem
            // 
            clienteMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            clienteMenuItem.ImageTransparentColor = SystemColors.ActiveCaptionText;
            clienteMenuItem.Name = "clienteMenuItem";
            clienteMenuItem.Size = new Size(180, 24);
            clienteMenuItem.Text = "Cliente";
            clienteMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // fornecedorMenuItem
            // 
            fornecedorMenuItem.Name = "fornecedorMenuItem";
            fornecedorMenuItem.Size = new Size(180, 24);
            fornecedorMenuItem.Text = "Fornecedor";
            fornecedorMenuItem.Click += fornecedorToolStripMenuItem_Click;
            // 
            // produtoMenuItem
            // 
            produtoMenuItem.Name = "produtoMenuItem";
            produtoMenuItem.Size = new Size(180, 24);
            produtoMenuItem.Text = "Produto";
            produtoMenuItem.Click += produtosToolStripMenuItem_Click;
            // 
            // movMenuStrip
            // 
            movMenuStrip.DropDownItems.AddRange(new ToolStripItem[] { pedidoMenuItem });
            movMenuStrip.ForeColor = Color.Black;
            movMenuStrip.Name = "movMenuStrip";
            movMenuStrip.Size = new Size(120, 24);
            movMenuStrip.Text = "Movimentação";
            // 
            // pedidoMenuItem
            // 
            pedidoMenuItem.BackgroundImageLayout = ImageLayout.None;
            pedidoMenuItem.Name = "pedidoMenuItem";
            pedidoMenuItem.Size = new Size(130, 24);
            pedidoMenuItem.Text = "Pedidos";
            pedidoMenuItem.Click += pedidoMenuItem_Click;
            // 
            // segurançaMenuStrip
            // 
            segurançaMenuStrip.DropDownItems.AddRange(new ToolStripItem[] { usuáriosMenuItem, novasCategoriasToolStripMenuItem });
            segurançaMenuStrip.ForeColor = Color.Black;
            segurançaMenuStrip.Name = "segurançaMenuStrip";
            segurançaMenuStrip.Size = new Size(103, 24);
            segurançaMenuStrip.Text = "Manutenção";
            // 
            // usuáriosMenuItem
            // 
            usuáriosMenuItem.Name = "usuáriosMenuItem";
            usuáriosMenuItem.Size = new Size(180, 24);
            usuáriosMenuItem.Text = "Usuários";
            usuáriosMenuItem.Click += usuáriosMenuItem_Click;
            // 
            // novasCategoriasToolStripMenuItem
            // 
            novasCategoriasToolStripMenuItem.Name = "novasCategoriasToolStripMenuItem";
            novasCategoriasToolStripMenuItem.Size = new Size(180, 24);
            novasCategoriasToolStripMenuItem.Text = " Categorias";
            novasCategoriasToolStripMenuItem.Click += novasCategoriasToolStripMenuItem_Click;
            // 
            // sairMenuItem
            // 
            sairMenuItem.ForeColor = Color.Black;
            sairMenuItem.Name = "sairMenuItem";
            sairMenuItem.Size = new Size(46, 24);
            sairMenuItem.Text = "Sair";
            sairMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // MenuHome
            // 
            MenuHome.BackColor = Color.White;
            MenuHome.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            MenuHome.ImeMode = ImeMode.On;
            MenuHome.Items.AddRange(new ToolStripItem[] { cadastroMenuStrip, movMenuStrip, segurançaMenuStrip, sairMenuItem });
            MenuHome.Location = new Point(0, 0);
            MenuHome.Name = "MenuHome";
            MenuHome.Size = new Size(800, 28);
            MenuHome.TabIndex = 0;
            MenuHome.Text = "menuStrip1";
            MenuHome.ItemClicked += MenuHome_ItemClicked;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Gainsboro;
            BackgroundImageLayout = ImageLayout.None;
            CausesValidation = false;
            ClientSize = new Size(800, 450);
            Controls.Add(MenuHome);
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.Off;
            MainMenuStrip = MenuHome;
            Name = "Home";
            Text = "EletroLight";
            WindowState = FormWindowState.Maximized;
            MenuHome.ResumeLayout(false);
            MenuHome.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripMenuItem cadastroMenuStrip;
        private ToolStripMenuItem clienteMenuItem;
        private ToolStripMenuItem fornecedorMenuItem;
        private ToolStripMenuItem produtoMenuItem;
        private ToolStripMenuItem movMenuStrip;
        private ToolStripMenuItem pedidoMenuItem;
        private ToolStripMenuItem segurançaMenuStrip;
        private ToolStripMenuItem usuáriosMenuItem;
        private ToolStripMenuItem sairMenuItem;
        private MenuStrip MenuHome;
        private ToolStripMenuItem novasCategoriasToolStripMenuItem;
    }
}