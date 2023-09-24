using System.Drawing;
using System.Windows.Forms;

namespace EletroLight
{
    partial class Produto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produto));
            this.valorLabel = new System.Windows.Forms.Label();
            this.consultarBT = new System.Windows.Forms.Button();
            this.incluirBT = new System.Windows.Forms.Button();
            this.limparBT = new System.Windows.Forms.Button();
            this.excluirBT = new System.Windows.Forms.Button();
            this.quantidadeTB = new System.Windows.Forms.TextBox();
            this.produtoTB = new System.Windows.Forms.TextBox();
            this.fornecedorLabel = new System.Windows.Forms.Label();
            this.categoriaLabel = new System.Windows.Forms.Label();
            this.enderecoLabel = new System.Windows.Forms.Label();
            this.produtoLabel = new System.Windows.Forms.Label();
            this.atualizarBT = new System.Windows.Forms.Button();
            this.categoriaCB = new System.Windows.Forms.ComboBox();
            this.fornecedorCB = new System.Windows.Forms.ComboBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.TextBox();
            this.valorTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // valorLabel
            // 
            this.valorLabel.AutoSize = true;
            this.valorLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.valorLabel.Location = new System.Drawing.Point(58, 151);
            this.valorLabel.Name = "valorLabel";
            this.valorLabel.Size = new System.Drawing.Size(72, 21);
            this.valorLabel.TabIndex = 41;
            this.valorLabel.Text = "Valor R$:";
            // 
            // consultarBT
            // 
            this.consultarBT.BackColor = System.Drawing.Color.SlateGray;
            this.consultarBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consultarBT.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.consultarBT.ForeColor = System.Drawing.Color.White;
            this.consultarBT.Location = new System.Drawing.Point(60, 87);
            this.consultarBT.Name = "consultarBT";
            this.consultarBT.Size = new System.Drawing.Size(95, 46);
            this.consultarBT.TabIndex = 40;
            this.consultarBT.Text = "Consultar";
            this.consultarBT.UseVisualStyleBackColor = false;
            this.consultarBT.Click += new System.EventHandler(this.consultarBT_Click_1);
            // 
            // incluirBT
            // 
            this.incluirBT.BackColor = System.Drawing.Color.ForestGreen;
            this.incluirBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incluirBT.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.incluirBT.ForeColor = System.Drawing.Color.White;
            this.incluirBT.Location = new System.Drawing.Point(62, 310);
            this.incluirBT.Name = "incluirBT";
            this.incluirBT.Size = new System.Drawing.Size(95, 46);
            this.incluirBT.TabIndex = 39;
            this.incluirBT.Text = "Incluir";
            this.incluirBT.UseVisualStyleBackColor = false;
            this.incluirBT.Click += new System.EventHandler(this.incluirBT_Click_1);
            // 
            // limparBT
            // 
            this.limparBT.BackColor = System.Drawing.Color.DarkOrange;
            this.limparBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limparBT.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.limparBT.ForeColor = System.Drawing.Color.White;
            this.limparBT.Location = new System.Drawing.Point(430, 310);
            this.limparBT.Name = "limparBT";
            this.limparBT.Size = new System.Drawing.Size(95, 46);
            this.limparBT.TabIndex = 38;
            this.limparBT.Text = "Limpar";
            this.limparBT.UseVisualStyleBackColor = false;
            this.limparBT.Click += new System.EventHandler(this.limparBT_Click_1);
            // 
            // excluirBT
            // 
            this.excluirBT.BackColor = System.Drawing.Color.DarkRed;
            this.excluirBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluirBT.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.excluirBT.ForeColor = System.Drawing.Color.White;
            this.excluirBT.Location = new System.Drawing.Point(329, 310);
            this.excluirBT.Name = "excluirBT";
            this.excluirBT.Size = new System.Drawing.Size(95, 46);
            this.excluirBT.TabIndex = 37;
            this.excluirBT.Text = "Excluir";
            this.excluirBT.UseVisualStyleBackColor = false;
            this.excluirBT.Click += new System.EventHandler(this.excluirBT_Click_1);
            // 
            // quantidadeTB
            // 
            this.quantidadeTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.quantidadeTB.Location = new System.Drawing.Point(171, 175);
            this.quantidadeTB.MaxLength = 2;
            this.quantidadeTB.Name = "quantidadeTB";
            this.quantidadeTB.Size = new System.Drawing.Size(96, 29);
            this.quantidadeTB.TabIndex = 32;
            this.quantidadeTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantidadeTB_KeyPress_1);
            // 
            // produtoTB
            // 
            this.produtoTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.produtoTB.Location = new System.Drawing.Point(60, 48);
            this.produtoTB.MaxLength = 50;
            this.produtoTB.Name = "produtoTB";
            this.produtoTB.Size = new System.Drawing.Size(207, 29);
            this.produtoTB.TabIndex = 31;
            // 
            // fornecedorLabel
            // 
            this.fornecedorLabel.AutoSize = true;
            this.fornecedorLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fornecedorLabel.Location = new System.Drawing.Point(293, 151);
            this.fornecedorLabel.Name = "fornecedorLabel";
            this.fornecedorLabel.Size = new System.Drawing.Size(92, 21);
            this.fornecedorLabel.TabIndex = 29;
            this.fornecedorLabel.Text = "Fornecedor:";
            // 
            // categoriaLabel
            // 
            this.categoriaLabel.AutoSize = true;
            this.categoriaLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.categoriaLabel.Location = new System.Drawing.Point(350, 24);
            this.categoriaLabel.Name = "categoriaLabel";
            this.categoriaLabel.Size = new System.Drawing.Size(80, 21);
            this.categoriaLabel.TabIndex = 28;
            this.categoriaLabel.Text = "Categoria:";
            // 
            // enderecoLabel
            // 
            this.enderecoLabel.AutoSize = true;
            this.enderecoLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.enderecoLabel.Location = new System.Drawing.Point(167, 151);
            this.enderecoLabel.Name = "enderecoLabel";
            this.enderecoLabel.Size = new System.Drawing.Size(94, 21);
            this.enderecoLabel.TabIndex = 27;
            this.enderecoLabel.Text = "Quantidade:";
            // 
            // produtoLabel
            // 
            this.produtoLabel.AutoSize = true;
            this.produtoLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.produtoLabel.Location = new System.Drawing.Point(58, 24);
            this.produtoLabel.Name = "produtoLabel";
            this.produtoLabel.Size = new System.Drawing.Size(69, 21);
            this.produtoLabel.TabIndex = 25;
            this.produtoLabel.Text = "Produto:";
            // 
            // atualizarBT
            // 
            this.atualizarBT.BackColor = System.Drawing.SystemColors.HotTrack;
            this.atualizarBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atualizarBT.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.atualizarBT.ForeColor = System.Drawing.Color.White;
            this.atualizarBT.Location = new System.Drawing.Point(228, 310);
            this.atualizarBT.Name = "atualizarBT";
            this.atualizarBT.Size = new System.Drawing.Size(95, 46);
            this.atualizarBT.TabIndex = 46;
            this.atualizarBT.Text = "Atualizar";
            this.atualizarBT.UseVisualStyleBackColor = false;
            this.atualizarBT.Click += new System.EventHandler(this.atualizarBT_Click_1);
            // 
            // categoriaCB
            // 
            this.categoriaCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriaCB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.categoriaCB.FormattingEnabled = true;
            this.categoriaCB.Location = new System.Drawing.Point(354, 48);
            this.categoriaCB.Name = "categoriaCB";
            this.categoriaCB.Size = new System.Drawing.Size(171, 29);
            this.categoriaCB.TabIndex = 47;
            // 
            // fornecedorCB
            // 
            this.fornecedorCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fornecedorCB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fornecedorCB.FormattingEnabled = true;
            this.fornecedorCB.Location = new System.Drawing.Point(297, 175);
            this.fornecedorCB.Name = "fornecedorCB";
            this.fornecedorCB.Size = new System.Drawing.Size(228, 29);
            this.fornecedorCB.TabIndex = 48;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.idLabel.Location = new System.Drawing.Point(284, 24);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(28, 21);
            this.idLabel.TabIndex = 52;
            this.idLabel.Text = "ID:";
            // 
            // idTB
            // 
            this.idTB.Enabled = false;
            this.idTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.idTB.Location = new System.Drawing.Point(284, 48);
            this.idTB.MaxLength = 2;
            this.idTB.Name = "idTB";
            this.idTB.ReadOnly = true;
            this.idTB.Size = new System.Drawing.Size(48, 29);
            this.idTB.TabIndex = 51;
            // 
            // valorTB
            // 
            this.valorTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.valorTB.Location = new System.Drawing.Point(60, 175);
            this.valorTB.MaxLength = 10;
            this.valorTB.Name = "valorTB";
            this.valorTB.Size = new System.Drawing.Size(96, 29);
            this.valorTB.TabIndex = 53;
            this.valorTB.TextChanged += new System.EventHandler(this.valorTB_TextChanged_1);
            this.valorTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valorTB_KeyPress_1);
            // 
            // Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(590, 382);
            this.Controls.Add(this.valorTB);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.fornecedorCB);
            this.Controls.Add(this.categoriaCB);
            this.Controls.Add(this.atualizarBT);
            this.Controls.Add(this.valorLabel);
            this.Controls.Add(this.consultarBT);
            this.Controls.Add(this.incluirBT);
            this.Controls.Add(this.limparBT);
            this.Controls.Add(this.excluirBT);
            this.Controls.Add(this.quantidadeTB);
            this.Controls.Add(this.produtoTB);
            this.Controls.Add(this.fornecedorLabel);
            this.Controls.Add(this.categoriaLabel);
            this.Controls.Add(this.enderecoLabel);
            this.Controls.Add(this.produtoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Produto_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label valorLabel;
        private Button consultarBT;
        private Button incluirBT;
        private Button limparBT;
        private Button excluirBT;
        private TextBox quantidadeTB;
        private TextBox produtoTB;
        private Label fornecedorLabel;
        private Label categoriaLabel;
        private Label enderecoLabel;
        private Label produtoLabel;
        private Button atualizarBT;
        private ComboBox categoriaCB;
        private ComboBox fornecedorCB;
        private Label idLabel;
        private TextBox idTB;
        private TextBox valorTB;
    }
}