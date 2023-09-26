using System.Drawing;
using System.Windows.Forms;
using System;

namespace EletroLight
{
    partial class Pedido
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedido));
            this.dataLabel = new System.Windows.Forms.Label();
            this.consultarBT = new System.Windows.Forms.Button();
            this.incluirBT = new System.Windows.Forms.Button();
            this.limparBT = new System.Windows.Forms.Button();
            this.excluirBT = new System.Windows.Forms.Button();
            this.produtoLabel = new System.Windows.Forms.Label();
            this.valorUniLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.cpfLabel = new System.Windows.Forms.Label();
            this.quantidadeLabel = new System.Windows.Forms.Label();
            this.valorTotalLabel1 = new System.Windows.Forms.Label();
            this.atualizarBT = new System.Windows.Forms.Button();
            this.cpfMTB = new System.Windows.Forms.MaskedTextBox();
            this.quantidadeTB = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.TextBox();
            this.dataMTB = new System.Windows.Forms.MaskedTextBox();
            this.produtoCB = new System.Windows.Forms.ComboBox();
            this.clienteCB = new System.Windows.Forms.ComboBox();
            this.valor_unitarioTB = new System.Windows.Forms.TextBox();
            this.valor_totalTB = new System.Windows.Forms.TextBox();
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.relatorioBT = new System.Windows.Forms.Button();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dataLabel.Location = new System.Drawing.Point(508, 138);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(45, 21);
            this.dataLabel.TabIndex = 58;
            this.dataLabel.Text = "Data:";
            // 
            // consultarBT
            // 
            this.consultarBT.BackColor = System.Drawing.Color.SlateGray;
            this.consultarBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consultarBT.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.consultarBT.ForeColor = System.Drawing.Color.White;
            this.consultarBT.Location = new System.Drawing.Point(51, 82);
            this.consultarBT.Name = "consultarBT";
            this.consultarBT.Size = new System.Drawing.Size(95, 46);
            this.consultarBT.TabIndex = 57;
            this.consultarBT.Text = "Consultar";
            this.consultarBT.UseVisualStyleBackColor = false;
            this.consultarBT.Click += new System.EventHandler(this.consultarBT_Click);
            // 
            // incluirBT
            // 
            this.incluirBT.BackColor = System.Drawing.Color.ForestGreen;
            this.incluirBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incluirBT.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.incluirBT.ForeColor = System.Drawing.Color.White;
            this.incluirBT.Location = new System.Drawing.Point(51, 468);
            this.incluirBT.Name = "incluirBT";
            this.incluirBT.Size = new System.Drawing.Size(95, 46);
            this.incluirBT.TabIndex = 56;
            this.incluirBT.Text = "Incluir";
            this.incluirBT.UseVisualStyleBackColor = false;
            this.incluirBT.Click += new System.EventHandler(this.incluirBT_Click);
            // 
            // limparBT
            // 
            this.limparBT.BackColor = System.Drawing.Color.DarkOrange;
            this.limparBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limparBT.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.limparBT.ForeColor = System.Drawing.Color.White;
            this.limparBT.Location = new System.Drawing.Point(506, 468);
            this.limparBT.Name = "limparBT";
            this.limparBT.Size = new System.Drawing.Size(95, 46);
            this.limparBT.TabIndex = 55;
            this.limparBT.Text = "Limpar";
            this.limparBT.UseVisualStyleBackColor = false;
            this.limparBT.Click += new System.EventHandler(this.limparBT_Click);
            // 
            // excluirBT
            // 
            this.excluirBT.BackColor = System.Drawing.Color.DarkRed;
            this.excluirBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluirBT.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.excluirBT.ForeColor = System.Drawing.Color.White;
            this.excluirBT.Location = new System.Drawing.Point(406, 468);
            this.excluirBT.Name = "excluirBT";
            this.excluirBT.Size = new System.Drawing.Size(95, 46);
            this.excluirBT.TabIndex = 54;
            this.excluirBT.Text = "Excluir";
            this.excluirBT.UseVisualStyleBackColor = false;
            this.excluirBT.Click += new System.EventHandler(this.excluirBT_Click);
            // 
            // produtoLabel
            // 
            this.produtoLabel.AutoSize = true;
            this.produtoLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.produtoLabel.Location = new System.Drawing.Point(47, 138);
            this.produtoLabel.Name = "produtoLabel";
            this.produtoLabel.Size = new System.Drawing.Size(69, 21);
            this.produtoLabel.TabIndex = 48;
            this.produtoLabel.Text = "Produto:";
            // 
            // valorUniLabel
            // 
            this.valorUniLabel.AutoSize = true;
            this.valorUniLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.valorUniLabel.Location = new System.Drawing.Point(47, 205);
            this.valorUniLabel.Name = "valorUniLabel";
            this.valorUniLabel.Size = new System.Drawing.Size(130, 21);
            this.valorUniLabel.TabIndex = 47;
            this.valorUniLabel.Text = "Valor unitário R$:\r\n";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nomeLabel.Location = new System.Drawing.Point(47, 17);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(61, 21);
            this.nomeLabel.TabIndex = 46;
            this.nomeLabel.Text = "Cliente:";
            // 
            // cpfLabel
            // 
            this.cpfLabel.AutoSize = true;
            this.cpfLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cpfLabel.Location = new System.Drawing.Point(470, 17);
            this.cpfLabel.Name = "cpfLabel";
            this.cpfLabel.Size = new System.Drawing.Size(40, 21);
            this.cpfLabel.TabIndex = 61;
            this.cpfLabel.Text = "CPF:";
            // 
            // quantidadeLabel
            // 
            this.quantidadeLabel.AutoSize = true;
            this.quantidadeLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.quantidadeLabel.Location = new System.Drawing.Point(398, 138);
            this.quantidadeLabel.Name = "quantidadeLabel";
            this.quantidadeLabel.Size = new System.Drawing.Size(94, 21);
            this.quantidadeLabel.TabIndex = 64;
            this.quantidadeLabel.Text = "Quantidade:";
            // 
            // valorTotalLabel1
            // 
            this.valorTotalLabel1.AutoSize = true;
            this.valorTotalLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.valorTotalLabel1.Location = new System.Drawing.Point(216, 205);
            this.valorTotalLabel1.Name = "valorTotalLabel1";
            this.valorTotalLabel1.Size = new System.Drawing.Size(107, 21);
            this.valorTotalLabel1.TabIndex = 66;
            this.valorTotalLabel1.Text = "Valor total R$:\r\n";
            // 
            // atualizarBT
            // 
            this.atualizarBT.BackColor = System.Drawing.SystemColors.HotTrack;
            this.atualizarBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atualizarBT.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.atualizarBT.ForeColor = System.Drawing.Color.White;
            this.atualizarBT.Location = new System.Drawing.Point(305, 468);
            this.atualizarBT.Name = "atualizarBT";
            this.atualizarBT.Size = new System.Drawing.Size(95, 46);
            this.atualizarBT.TabIndex = 67;
            this.atualizarBT.Text = "Atualizar";
            this.atualizarBT.UseVisualStyleBackColor = false;
            this.atualizarBT.Click += new System.EventHandler(this.atualizarBT_Click);
            // 
            // cpfMTB
            // 
            this.cpfMTB.Enabled = false;
            this.cpfMTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cpfMTB.Location = new System.Drawing.Point(474, 41);
            this.cpfMTB.Mask = "000,000,000-00";
            this.cpfMTB.Name = "cpfMTB";
            this.cpfMTB.Size = new System.Drawing.Size(127, 29);
            this.cpfMTB.TabIndex = 68;
            // 
            // quantidadeTB
            // 
            this.quantidadeTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.quantidadeTB.Location = new System.Drawing.Point(402, 162);
            this.quantidadeTB.MaxLength = 2;
            this.quantidadeTB.Name = "quantidadeTB";
            this.quantidadeTB.Size = new System.Drawing.Size(95, 29);
            this.quantidadeTB.TabIndex = 69;
            this.quantidadeTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantidadeTB_KeyPress);
            this.quantidadeTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.quantidadeTB_KeyUp);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.idLabel.Location = new System.Drawing.Point(398, 17);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(28, 21);
            this.idLabel.TabIndex = 71;
            this.idLabel.Text = "ID:";
            // 
            // idTB
            // 
            this.idTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.idTB.Location = new System.Drawing.Point(399, 41);
            this.idTB.MaxLength = 2;
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(53, 29);
            this.idTB.TabIndex = 70;
            // 
            // dataMTB
            // 
            this.dataMTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dataMTB.Location = new System.Drawing.Point(512, 162);
            this.dataMTB.Mask = "00/00/0000";
            this.dataMTB.Name = "dataMTB";
            this.dataMTB.Size = new System.Drawing.Size(89, 29);
            this.dataMTB.TabIndex = 75;
            this.dataMTB.ValidatingType = typeof(System.DateTime);
            // 
            // produtoCB
            // 
            this.produtoCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.produtoCB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.produtoCB.FormattingEnabled = true;
            this.produtoCB.Location = new System.Drawing.Point(51, 162);
            this.produtoCB.Name = "produtoCB";
            this.produtoCB.Size = new System.Drawing.Size(332, 29);
            this.produtoCB.TabIndex = 77;
            this.produtoCB.SelectedIndexChanged += new System.EventHandler(this.produtoCB_SelectedIndexChanged_1);
            // 
            // clienteCB
            // 
            this.clienteCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clienteCB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.clienteCB.FormattingEnabled = true;
            this.clienteCB.Location = new System.Drawing.Point(51, 41);
            this.clienteCB.Name = "clienteCB";
            this.clienteCB.Size = new System.Drawing.Size(332, 29);
            this.clienteCB.TabIndex = 78;
            // 
            // valor_unitarioTB
            // 
            this.valor_unitarioTB.Enabled = false;
            this.valor_unitarioTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.valor_unitarioTB.Location = new System.Drawing.Point(51, 229);
            this.valor_unitarioTB.MaxLength = 2;
            this.valor_unitarioTB.Name = "valor_unitarioTB";
            this.valor_unitarioTB.ReadOnly = true;
            this.valor_unitarioTB.Size = new System.Drawing.Size(154, 29);
            this.valor_unitarioTB.TabIndex = 79;
            // 
            // valor_totalTB
            // 
            this.valor_totalTB.Enabled = false;
            this.valor_totalTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.valor_totalTB.Location = new System.Drawing.Point(220, 229);
            this.valor_totalTB.MaxLength = 2;
            this.valor_totalTB.Name = "valor_totalTB";
            this.valor_totalTB.ReadOnly = true;
            this.valor_totalTB.Size = new System.Drawing.Size(154, 29);
            this.valor_totalTB.TabIndex = 80;
            // 
            // dataGV
            // 
            this.dataGV.AllowUserToAddRows = false;
            this.dataGV.AllowUserToDeleteRows = false;
            this.dataGV.AllowUserToResizeColumns = false;
            this.dataGV.AllowUserToResizeRows = false;
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Location = new System.Drawing.Point(51, 277);
            this.dataGV.MultiSelect = false;
            this.dataGV.Name = "dataGV";
            this.dataGV.ReadOnly = true;
            this.dataGV.RowHeadersVisible = false;
            this.dataGV.RowTemplate.Height = 25;
            this.dataGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGV.Size = new System.Drawing.Size(550, 162);
            this.dataGV.TabIndex = 81;
            // 
            // relatorioBT
            // 
            this.relatorioBT.BackColor = System.Drawing.Color.DimGray;
            this.relatorioBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.relatorioBT.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.relatorioBT.ForeColor = System.Drawing.Color.White;
            this.relatorioBT.Location = new System.Drawing.Point(152, 82);
            this.relatorioBT.Name = "relatorioBT";
            this.relatorioBT.Size = new System.Drawing.Size(95, 46);
            this.relatorioBT.TabIndex = 82;
            this.relatorioBT.Text = "Relatório";
            this.relatorioBT.UseVisualStyleBackColor = false;
            this.relatorioBT.Click += new System.EventHandler(this.relatorioBT_Click);
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(EletroLight.Categoria);
            // 
            // categoriaBindingSource1
            // 
            this.categoriaBindingSource1.DataSource = typeof(EletroLight.Categoria);
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(650, 547);
            this.Controls.Add(this.relatorioBT);
            this.Controls.Add(this.dataGV);
            this.Controls.Add(this.valor_totalTB);
            this.Controls.Add(this.valor_unitarioTB);
            this.Controls.Add(this.clienteCB);
            this.Controls.Add(this.produtoCB);
            this.Controls.Add(this.dataMTB);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.quantidadeTB);
            this.Controls.Add(this.cpfMTB);
            this.Controls.Add(this.atualizarBT);
            this.Controls.Add(this.valorTotalLabel1);
            this.Controls.Add(this.quantidadeLabel);
            this.Controls.Add(this.cpfLabel);
            this.Controls.Add(this.dataLabel);
            this.Controls.Add(this.consultarBT);
            this.Controls.Add(this.incluirBT);
            this.Controls.Add(this.limparBT);
            this.Controls.Add(this.excluirBT);
            this.Controls.Add(this.produtoLabel);
            this.Controls.Add(this.valorUniLabel);
            this.Controls.Add(this.nomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Pedido_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pedido_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label dataLabel;
        private Button consultarBT;
        private Button incluirBT;
        private Button limparBT;
        private Button excluirBT;
        private TextBox ufTextBox;
        private TextBox quantidadeTextBox;
        private Label fornecedorLabel;
        private Label produtoLabel;
        private Label valorUniLabel;
        private Label nomeLabel;
        private Label cpfLabel;
        private Label quantidadeLabel;
        private Label valorTotalLabel1;
        private Button atualizarBT;
        private MaskedTextBox cpfMTB;
        private TextBox quantidadeTB;
        private Label idLabel;
        private TextBox idTB;
        private MaskedTextBox dataMTB;
        private ComboBox produtoCB;
        private ComboBox clienteCB;
        private TextBox valor_unitarioTB;
        private TextBox valor_totalTB;
        private BindingSource categoriaBindingSource;
        private BindingSource categoriaBindingSource1;
        private DataGridView dataGV;
        private Button relatorioBT;
    }
}