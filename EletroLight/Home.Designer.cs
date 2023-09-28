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
            this.cadastroMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segurançaMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosExcluidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHome = new System.Windows.Forms.MenuStrip();
            this.MenuHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // cadastroMenuStrip
            // 
            this.cadastroMenuStrip.Checked = true;
            this.cadastroMenuStrip.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cadastroMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteMenuItem,
            this.fornecedorMenuItem,
            this.produtoMenuItem});
            this.cadastroMenuStrip.ForeColor = System.Drawing.Color.Black;
            this.cadastroMenuStrip.ImageTransparentColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cadastroMenuStrip.Name = "cadastroMenuStrip";
            this.cadastroMenuStrip.Size = new System.Drawing.Size(80, 24);
            this.cadastroMenuStrip.Text = "Cadastro";
            // 
            // clienteMenuItem
            // 
            this.clienteMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.clienteMenuItem.ImageTransparentColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clienteMenuItem.Name = "clienteMenuItem";
            this.clienteMenuItem.Size = new System.Drawing.Size(153, 24);
            this.clienteMenuItem.Text = "Cliente";
            this.clienteMenuItem.Click += new System.EventHandler(this.clienteMenuItem_Click);
            // 
            // fornecedorMenuItem
            // 
            this.fornecedorMenuItem.Name = "fornecedorMenuItem";
            this.fornecedorMenuItem.Size = new System.Drawing.Size(153, 24);
            this.fornecedorMenuItem.Text = "Fornecedor";
            this.fornecedorMenuItem.Click += new System.EventHandler(this.fornecedorMenuItem_Click);
            // 
            // produtoMenuItem
            // 
            this.produtoMenuItem.Name = "produtoMenuItem";
            this.produtoMenuItem.Size = new System.Drawing.Size(153, 24);
            this.produtoMenuItem.Text = "Produto";
            this.produtoMenuItem.Click += new System.EventHandler(this.produtoMenuItem_Click);
            // 
            // movMenuStrip
            // 
            this.movMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidoMenuItem});
            this.movMenuStrip.ForeColor = System.Drawing.Color.Black;
            this.movMenuStrip.Name = "movMenuStrip";
            this.movMenuStrip.Size = new System.Drawing.Size(120, 24);
            this.movMenuStrip.Text = "Movimentação";
            // 
            // pedidoMenuItem
            // 
            this.pedidoMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pedidoMenuItem.Name = "pedidoMenuItem";
            this.pedidoMenuItem.Size = new System.Drawing.Size(130, 24);
            this.pedidoMenuItem.Text = "Pedidos";
            this.pedidoMenuItem.Click += new System.EventHandler(this.pedidoMenuItem_Click_1);
            // 
            // segurançaMenuStrip
            // 
            this.segurançaMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosMenuItem,
            this.CategoriasToolStripMenuItem,
            this.pedidosExcluidoToolStripMenuItem});
            this.segurançaMenuStrip.ForeColor = System.Drawing.Color.Black;
            this.segurançaMenuStrip.Name = "segurançaMenuStrip";
            this.segurançaMenuStrip.Size = new System.Drawing.Size(103, 24);
            this.segurançaMenuStrip.Text = "Manutenção";
            // 
            // usuáriosMenuItem
            // 
            this.usuáriosMenuItem.Name = "usuáriosMenuItem";
            this.usuáriosMenuItem.Size = new System.Drawing.Size(196, 24);
            this.usuáriosMenuItem.Text = "Usuários";
            this.usuáriosMenuItem.Click += new System.EventHandler(this.usuáriosMenuItem_Click_1);
            // 
            // CategoriasToolStripMenuItem
            // 
            this.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem";
            this.CategoriasToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.CategoriasToolStripMenuItem.Text = "Categorias";
            this.CategoriasToolStripMenuItem.Click += new System.EventHandler(this.CategoriasToolStripMenuItem_Click);
            // 
            // pedidosExcluidoToolStripMenuItem
            // 
            this.pedidosExcluidoToolStripMenuItem.Name = "pedidosExcluidoToolStripMenuItem";
            this.pedidosExcluidoToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.pedidosExcluidoToolStripMenuItem.Text = "Pedidos Excluídos";
            this.pedidosExcluidoToolStripMenuItem.Click += new System.EventHandler(this.pedidosExcluidoToolStripMenuItem_Click);
            // 
            // sairMenuItem
            // 
            this.sairMenuItem.ForeColor = System.Drawing.Color.Black;
            this.sairMenuItem.Name = "sairMenuItem";
            this.sairMenuItem.Size = new System.Drawing.Size(46, 24);
            this.sairMenuItem.Text = "Sair";
            this.sairMenuItem.Click += new System.EventHandler(this.sairMenuItem_Click);
            // 
            // MenuHome
            // 
            this.MenuHome.BackColor = System.Drawing.Color.White;
            this.MenuHome.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.MenuHome.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MenuHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroMenuStrip,
            this.movMenuStrip,
            this.segurançaMenuStrip,
            this.sairMenuItem});
            this.MenuHome.Location = new System.Drawing.Point(0, 0);
            this.MenuHome.Name = "MenuHome";
            this.MenuHome.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.MenuHome.Size = new System.Drawing.Size(686, 28);
            this.MenuHome.TabIndex = 0;
            this.MenuHome.Text = "menuStrip1";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.MenuHome);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MainMenuStrip = this.MenuHome;
            this.Name = "Home";
            this.Text = "EletroLight";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.MenuHome.ResumeLayout(false);
            this.MenuHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private ToolStripMenuItem CategoriasToolStripMenuItem;
        private ToolStripMenuItem pedidosExcluidoToolStripMenuItem;
    }
}