using System.Drawing;
using System.Windows.Forms;

namespace EletroLight
{
    partial class Fornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fornecedor));
            this.consultarBT = new System.Windows.Forms.Button();
            this.incluirBT = new System.Windows.Forms.Button();
            this.limparBT = new System.Windows.Forms.Button();
            this.excluirBT = new System.Windows.Forms.Button();
            this.Telefonelabel = new System.Windows.Forms.Label();
            this.enderecoTB = new System.Windows.Forms.TextBox();
            this.nomeTB = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.ufLabel = new System.Windows.Forms.Label();
            this.cidadeLabel = new System.Windows.Forms.Label();
            this.enderecoLabel = new System.Windows.Forms.Label();
            this.cnpjLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.atualizarBT = new System.Windows.Forms.Button();
            this.cnpjMTB = new System.Windows.Forms.MaskedTextBox();
            this.cepMTB = new System.Windows.Forms.MaskedTextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.ufTB = new System.Windows.Forms.TextBox();
            this.cidadeTB = new System.Windows.Forms.TextBox();
            this.cepLabel = new System.Windows.Forms.Label();
            this.telefoneMTB = new System.Windows.Forms.MaskedTextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // consultarBT
            // 
            this.consultarBT.BackColor = System.Drawing.Color.SlateGray;
            this.consultarBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consultarBT.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.consultarBT.ForeColor = System.Drawing.Color.White;
            this.consultarBT.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.consultarBT.Location = new System.Drawing.Point(53, 86);
            this.consultarBT.Name = "consultarBT";
            this.consultarBT.Size = new System.Drawing.Size(95, 46);
            this.consultarBT.TabIndex = 39;
            this.consultarBT.Text = "Consultar";
            this.consultarBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.consultarBT.UseVisualStyleBackColor = false;
            this.consultarBT.Click += new System.EventHandler(this.consultarBT_Click);
            // 
            // incluirBT
            // 
            this.incluirBT.BackColor = System.Drawing.Color.ForestGreen;
            this.incluirBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incluirBT.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.incluirBT.ForeColor = System.Drawing.Color.White;
            this.incluirBT.Location = new System.Drawing.Point(53, 345);
            this.incluirBT.Name = "incluirBT";
            this.incluirBT.Size = new System.Drawing.Size(95, 46);
            this.incluirBT.TabIndex = 38;
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
            this.limparBT.Location = new System.Drawing.Point(527, 345);
            this.limparBT.Name = "limparBT";
            this.limparBT.Size = new System.Drawing.Size(95, 46);
            this.limparBT.TabIndex = 37;
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
            this.excluirBT.Location = new System.Drawing.Point(426, 345);
            this.excluirBT.Name = "excluirBT";
            this.excluirBT.Size = new System.Drawing.Size(95, 46);
            this.excluirBT.TabIndex = 36;
            this.excluirBT.Text = "Excluir";
            this.excluirBT.UseVisualStyleBackColor = false;
            this.excluirBT.Click += new System.EventHandler(this.excluirBT_Click);
            // 
            // Telefonelabel
            // 
            this.Telefonelabel.AutoSize = true;
            this.Telefonelabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Telefonelabel.Location = new System.Drawing.Point(329, 223);
            this.Telefonelabel.Name = "Telefonelabel";
            this.Telefonelabel.Size = new System.Drawing.Size(70, 21);
            this.Telefonelabel.TabIndex = 34;
            this.Telefonelabel.Text = "Telefone:";
            // 
            // enderecoTB
            // 
            this.enderecoTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.enderecoTB.Location = new System.Drawing.Point(161, 177);
            this.enderecoTB.MaxLength = 100;
            this.enderecoTB.Name = "enderecoTB";
            this.enderecoTB.Size = new System.Drawing.Size(224, 29);
            this.enderecoTB.TabIndex = 30;
            // 
            // nomeTB
            // 
            this.nomeTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nomeTB.Location = new System.Drawing.Point(53, 42);
            this.nomeTB.MaxLength = 100;
            this.nomeTB.Name = "nomeTB";
            this.nomeTB.Size = new System.Drawing.Size(314, 29);
            this.nomeTB.TabIndex = 28;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.emailLabel.Location = new System.Drawing.Point(49, 223);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(57, 21);
            this.emailLabel.TabIndex = 27;
            this.emailLabel.Text = "E-mail:";
            // 
            // ufLabel
            // 
            this.ufLabel.AutoSize = true;
            this.ufLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ufLabel.Location = new System.Drawing.Point(549, 153);
            this.ufLabel.Name = "ufLabel";
            this.ufLabel.Size = new System.Drawing.Size(32, 21);
            this.ufLabel.TabIndex = 26;
            this.ufLabel.Text = "UF:";
            // 
            // cidadeLabel
            // 
            this.cidadeLabel.AutoSize = true;
            this.cidadeLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cidadeLabel.Location = new System.Drawing.Point(399, 153);
            this.cidadeLabel.Name = "cidadeLabel";
            this.cidadeLabel.Size = new System.Drawing.Size(61, 21);
            this.cidadeLabel.TabIndex = 25;
            this.cidadeLabel.Text = "Cidade:";
            // 
            // enderecoLabel
            // 
            this.enderecoLabel.AutoSize = true;
            this.enderecoLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.enderecoLabel.Location = new System.Drawing.Point(157, 153);
            this.enderecoLabel.Name = "enderecoLabel";
            this.enderecoLabel.Size = new System.Drawing.Size(77, 21);
            this.enderecoLabel.TabIndex = 24;
            this.enderecoLabel.Text = "Endereço:";
            // 
            // cnpjLabel
            // 
            this.cnpjLabel.AutoSize = true;
            this.cnpjLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cnpjLabel.Location = new System.Drawing.Point(454, 18);
            this.cnpjLabel.Name = "cnpjLabel";
            this.cnpjLabel.Size = new System.Drawing.Size(49, 21);
            this.cnpjLabel.TabIndex = 23;
            this.cnpjLabel.Text = "CNPJ:";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nomeLabel.Location = new System.Drawing.Point(50, 18);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(56, 21);
            this.nomeLabel.TabIndex = 22;
            this.nomeLabel.Text = "Nome:";
            // 
            // atualizarBT
            // 
            this.atualizarBT.BackColor = System.Drawing.SystemColors.HotTrack;
            this.atualizarBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atualizarBT.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.atualizarBT.ForeColor = System.Drawing.Color.White;
            this.atualizarBT.Location = new System.Drawing.Point(325, 345);
            this.atualizarBT.Name = "atualizarBT";
            this.atualizarBT.Size = new System.Drawing.Size(95, 46);
            this.atualizarBT.TabIndex = 42;
            this.atualizarBT.Text = "Atualizar";
            this.atualizarBT.UseVisualStyleBackColor = false;
            this.atualizarBT.Click += new System.EventHandler(this.atualizarBT_Click);
            // 
            // cnpjMTB
            // 
            this.cnpjMTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cnpjMTB.Location = new System.Drawing.Point(458, 42);
            this.cnpjMTB.Mask = "00,000,000/0000-00";
            this.cnpjMTB.Name = "cnpjMTB";
            this.cnpjMTB.Size = new System.Drawing.Size(164, 29);
            this.cnpjMTB.TabIndex = 43;
            // 
            // cepMTB
            // 
            this.cepMTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cepMTB.Location = new System.Drawing.Point(53, 177);
            this.cepMTB.Mask = "00000-000";
            this.cepMTB.Name = "cepMTB";
            this.cepMTB.Size = new System.Drawing.Size(92, 29);
            this.cepMTB.TabIndex = 44;
            // 
            // emailTB
            // 
            this.emailTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.emailTB.Location = new System.Drawing.Point(53, 247);
            this.emailTB.MaxLength = 100;
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(259, 29);
            this.emailTB.TabIndex = 47;
            // 
            // ufTB
            // 
            this.ufTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ufTB.Location = new System.Drawing.Point(553, 177);
            this.ufTB.MaxLength = 2;
            this.ufTB.Name = "ufTB";
            this.ufTB.Size = new System.Drawing.Size(69, 29);
            this.ufTB.TabIndex = 46;
            this.ufTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ufTB_KeyPress);
            // 
            // cidadeTB
            // 
            this.cidadeTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cidadeTB.Location = new System.Drawing.Point(403, 177);
            this.cidadeTB.MaxLength = 50;
            this.cidadeTB.Name = "cidadeTB";
            this.cidadeTB.Size = new System.Drawing.Size(130, 29);
            this.cidadeTB.TabIndex = 45;
            // 
            // cepLabel
            // 
            this.cepLabel.AutoSize = true;
            this.cepLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cepLabel.Location = new System.Drawing.Point(50, 153);
            this.cepLabel.Name = "cepLabel";
            this.cepLabel.Size = new System.Drawing.Size(40, 21);
            this.cepLabel.TabIndex = 48;
            this.cepLabel.Text = "CEP:";
            // 
            // telefoneMTB
            // 
            this.telefoneMTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.telefoneMTB.Location = new System.Drawing.Point(333, 247);
            this.telefoneMTB.Mask = "(00) 00000-0000";
            this.telefoneMTB.Name = "telefoneMTB";
            this.telefoneMTB.Size = new System.Drawing.Size(146, 29);
            this.telefoneMTB.TabIndex = 49;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.idLabel.Location = new System.Drawing.Point(384, 18);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(28, 21);
            this.idLabel.TabIndex = 51;
            this.idLabel.Text = "ID:";
            // 
            // idTB
            // 
            this.idTB.Enabled = false;
            this.idTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.idTB.Location = new System.Drawing.Point(388, 42);
            this.idTB.MaxLength = 2;
            this.idTB.Name = "idTB";
            this.idTB.ReadOnly = true;
            this.idTB.Size = new System.Drawing.Size(48, 29);
            this.idTB.TabIndex = 50;
            // 
            // Fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(700, 439);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.telefoneMTB);
            this.Controls.Add(this.cepLabel);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.ufTB);
            this.Controls.Add(this.cidadeTB);
            this.Controls.Add(this.cepMTB);
            this.Controls.Add(this.cnpjMTB);
            this.Controls.Add(this.atualizarBT);
            this.Controls.Add(this.consultarBT);
            this.Controls.Add(this.incluirBT);
            this.Controls.Add(this.limparBT);
            this.Controls.Add(this.excluirBT);
            this.Controls.Add(this.Telefonelabel);
            this.Controls.Add(this.enderecoTB);
            this.Controls.Add(this.nomeTB);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.ufLabel);
            this.Controls.Add(this.cidadeLabel);
            this.Controls.Add(this.enderecoLabel);
            this.Controls.Add(this.cnpjLabel);
            this.Controls.Add(this.nomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Fornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedor";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label cepLabel;
        private TextBox cepTextBox;
        private Button consultarBT;
        private Button incluirBT;
        private Button limparBT;
        private Button excluirBT;
        private Label Telefonelabel;
        private TextBox emailTextBox;
        private TextBox ufTextBox;
        private TextBox cidadeTextBox;
        private TextBox enderecoTB;
        private TextBox cpfTextBox;
        private TextBox nomeTB;
        private Label emailLabel;
        private Label ufLabel;
        private Label cidadeLabel;
        private Label enderecoLabel;
        private Label cnpjLabel;
        private Label nomeLabel;
        private Button atualizarBT;
        private MaskedTextBox cnpjMTB;
        private MaskedTextBox cepMTB;
        private TextBox emailTB;
        private TextBox ufTB;
        private TextBox cidadeTB;
        private MaskedTextBox telefoneMTB;
        private Label idLabel;
        private TextBox idTB;
    }
}