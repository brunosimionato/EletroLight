using System.Drawing;
using System.Windows.Forms;

namespace EletroLight
{
    partial class Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.nomeLabel = new System.Windows.Forms.Label();
            this.cpfLabel = new System.Windows.Forms.Label();
            this.enderecoLabel = new System.Windows.Forms.Label();
            this.cidadeLabel = new System.Windows.Forms.Label();
            this.ufLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.nomeTB = new System.Windows.Forms.TextBox();
            this.enderecoTB = new System.Windows.Forms.TextBox();
            this.cidadeTB = new System.Windows.Forms.TextBox();
            this.ufTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.Telefonelabel = new System.Windows.Forms.Label();
            this.excluirBT = new System.Windows.Forms.Button();
            this.limparBT = new System.Windows.Forms.Button();
            this.incluirBT = new System.Windows.Forms.Button();
            this.consultarBT = new System.Windows.Forms.Button();
            this.cepLabel = new System.Windows.Forms.Label();
            this.rgTB = new System.Windows.Forms.TextBox();
            this.rgLabel = new System.Windows.Forms.Label();
            this.cpfMTB = new System.Windows.Forms.MaskedTextBox();
            this.cepMTB = new System.Windows.Forms.MaskedTextBox();
            this.telefoneMTB = new System.Windows.Forms.MaskedTextBox();
            this.atualizarBT = new System.Windows.Forms.Button();
            this.idTB = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nomeLabel.Location = new System.Drawing.Point(54, 31);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(56, 21);
            this.nomeLabel.TabIndex = 0;
            this.nomeLabel.Text = "Nome:";
            // 
            // cpfLabel
            // 
            this.cpfLabel.AutoSize = true;
            this.cpfLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cpfLabel.Location = new System.Drawing.Point(455, 31);
            this.cpfLabel.Name = "cpfLabel";
            this.cpfLabel.Size = new System.Drawing.Size(40, 21);
            this.cpfLabel.TabIndex = 1;
            this.cpfLabel.Text = "CPF:";
            // 
            // enderecoLabel
            // 
            this.enderecoLabel.AutoSize = true;
            this.enderecoLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.enderecoLabel.Location = new System.Drawing.Point(180, 163);
            this.enderecoLabel.Name = "enderecoLabel";
            this.enderecoLabel.Size = new System.Drawing.Size(77, 21);
            this.enderecoLabel.TabIndex = 2;
            this.enderecoLabel.Text = "Endereço:";
            // 
            // cidadeLabel
            // 
            this.cidadeLabel.AutoSize = true;
            this.cidadeLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cidadeLabel.Location = new System.Drawing.Point(480, 163);
            this.cidadeLabel.Name = "cidadeLabel";
            this.cidadeLabel.Size = new System.Drawing.Size(61, 21);
            this.cidadeLabel.TabIndex = 3;
            this.cidadeLabel.Text = "Cidade:";
            // 
            // ufLabel
            // 
            this.ufLabel.AutoSize = true;
            this.ufLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ufLabel.Location = new System.Drawing.Point(629, 163);
            this.ufLabel.Name = "ufLabel";
            this.ufLabel.Size = new System.Drawing.Size(32, 21);
            this.ufLabel.TabIndex = 4;
            this.ufLabel.Text = "UF:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.emailLabel.Location = new System.Drawing.Point(54, 227);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(57, 21);
            this.emailLabel.TabIndex = 5;
            this.emailLabel.Text = "E-mail:";
            // 
            // nomeTB
            // 
            this.nomeTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nomeTB.Location = new System.Drawing.Point(58, 54);
            this.nomeTB.MaxLength = 100;
            this.nomeTB.Name = "nomeTB";
            this.nomeTB.Size = new System.Drawing.Size(318, 29);
            this.nomeTB.TabIndex = 6;
            // 
            // enderecoTB
            // 
            this.enderecoTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.enderecoTB.Location = new System.Drawing.Point(184, 187);
            this.enderecoTB.MaxLength = 100;
            this.enderecoTB.Name = "enderecoTB";
            this.enderecoTB.Size = new System.Drawing.Size(273, 29);
            this.enderecoTB.TabIndex = 8;
            // 
            // cidadeTB
            // 
            this.cidadeTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cidadeTB.Location = new System.Drawing.Point(484, 187);
            this.cidadeTB.MaxLength = 50;
            this.cidadeTB.Name = "cidadeTB";
            this.cidadeTB.Size = new System.Drawing.Size(130, 29);
            this.cidadeTB.TabIndex = 9;
            // 
            // ufTB
            // 
            this.ufTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ufTB.Location = new System.Drawing.Point(633, 187);
            this.ufTB.MaxLength = 2;
            this.ufTB.Name = "ufTB";
            this.ufTB.Size = new System.Drawing.Size(69, 29);
            this.ufTB.TabIndex = 10;
            this.ufTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ufTB_KeyPress);
            // 
            // emailTB
            // 
            this.emailTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.emailTB.Location = new System.Drawing.Point(58, 251);
            this.emailTB.MaxLength = 100;
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(259, 29);
            this.emailTB.TabIndex = 11;
            // 
            // Telefonelabel
            // 
            this.Telefonelabel.AutoSize = true;
            this.Telefonelabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Telefonelabel.Location = new System.Drawing.Point(334, 227);
            this.Telefonelabel.Name = "Telefonelabel";
            this.Telefonelabel.Size = new System.Drawing.Size(70, 21);
            this.Telefonelabel.TabIndex = 12;
            this.Telefonelabel.Text = "Telefone:";
            // 
            // excluirBT
            // 
            this.excluirBT.BackColor = System.Drawing.Color.DarkRed;
            this.excluirBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluirBT.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.excluirBT.ForeColor = System.Drawing.Color.White;
            this.excluirBT.Location = new System.Drawing.Point(501, 317);
            this.excluirBT.Name = "excluirBT";
            this.excluirBT.Size = new System.Drawing.Size(95, 46);
            this.excluirBT.TabIndex = 14;
            this.excluirBT.Text = "Excluir";
            this.excluirBT.UseVisualStyleBackColor = false;
            this.excluirBT.Click += new System.EventHandler(this.excluirBT_Click);
            // 
            // limparBT
            // 
            this.limparBT.BackColor = System.Drawing.Color.DarkOrange;
            this.limparBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limparBT.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.limparBT.ForeColor = System.Drawing.Color.White;
            this.limparBT.Location = new System.Drawing.Point(607, 317);
            this.limparBT.Name = "limparBT";
            this.limparBT.Size = new System.Drawing.Size(95, 46);
            this.limparBT.TabIndex = 15;
            this.limparBT.Text = "Limpar";
            this.limparBT.UseVisualStyleBackColor = false;
            this.limparBT.Click += new System.EventHandler(this.limparBT_Click);
            // 
            // incluirBT
            // 
            this.incluirBT.BackColor = System.Drawing.Color.ForestGreen;
            this.incluirBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incluirBT.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.incluirBT.ForeColor = System.Drawing.Color.White;
            this.incluirBT.Location = new System.Drawing.Point(58, 317);
            this.incluirBT.Name = "incluirBT";
            this.incluirBT.Size = new System.Drawing.Size(95, 46);
            this.incluirBT.TabIndex = 16;
            this.incluirBT.Text = "Incluir";
            this.incluirBT.UseVisualStyleBackColor = false;
            this.incluirBT.Click += new System.EventHandler(this.incluirBT_Click);
            // 
            // consultarBT
            // 
            this.consultarBT.BackColor = System.Drawing.Color.SlateGray;
            this.consultarBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consultarBT.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.consultarBT.ForeColor = System.Drawing.Color.White;
            this.consultarBT.Location = new System.Drawing.Point(58, 99);
            this.consultarBT.Name = "consultarBT";
            this.consultarBT.Size = new System.Drawing.Size(95, 46);
            this.consultarBT.TabIndex = 17;
            this.consultarBT.Text = "Consultar";
            this.consultarBT.UseVisualStyleBackColor = false;
            this.consultarBT.Click += new System.EventHandler(this.consultarBT_Click);
            // 
            // cepLabel
            // 
            this.cepLabel.AutoSize = true;
            this.cepLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cepLabel.Location = new System.Drawing.Point(54, 163);
            this.cepLabel.Name = "cepLabel";
            this.cepLabel.Size = new System.Drawing.Size(40, 21);
            this.cepLabel.TabIndex = 19;
            this.cepLabel.Text = "CEP:";
            // 
            // rgTB
            // 
            this.rgTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.rgTB.Location = new System.Drawing.Point(601, 54);
            this.rgTB.MaxLength = 10;
            this.rgTB.Name = "rgTB";
            this.rgTB.Size = new System.Drawing.Size(101, 29);
            this.rgTB.TabIndex = 20;
            this.rgTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rgTB_KeyPress_1);
            // 
            // rgLabel
            // 
            this.rgLabel.AutoSize = true;
            this.rgLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.rgLabel.Location = new System.Drawing.Point(603, 30);
            this.rgLabel.Name = "rgLabel";
            this.rgLabel.Size = new System.Drawing.Size(34, 21);
            this.rgLabel.TabIndex = 21;
            this.rgLabel.Text = "RG:";
            // 
            // cpfMTB
            // 
            this.cpfMTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cpfMTB.Location = new System.Drawing.Point(459, 54);
            this.cpfMTB.Mask = "000,000,000-00";
            this.cpfMTB.Name = "cpfMTB";
            this.cpfMTB.Size = new System.Drawing.Size(121, 29);
            this.cpfMTB.TabIndex = 22;
            // 
            // cepMTB
            // 
            this.cepMTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cepMTB.Location = new System.Drawing.Point(58, 187);
            this.cepMTB.Mask = "00000-000";
            this.cepMTB.Name = "cepMTB";
            this.cepMTB.Size = new System.Drawing.Size(100, 29);
            this.cepMTB.TabIndex = 23;
            // 
            // telefoneMTB
            // 
            this.telefoneMTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.telefoneMTB.Location = new System.Drawing.Point(338, 251);
            this.telefoneMTB.Mask = "(00) 00000-0000";
            this.telefoneMTB.Name = "telefoneMTB";
            this.telefoneMTB.Size = new System.Drawing.Size(149, 29);
            this.telefoneMTB.TabIndex = 24;
            // 
            // atualizarBT
            // 
            this.atualizarBT.BackColor = System.Drawing.SystemColors.HotTrack;
            this.atualizarBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atualizarBT.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.atualizarBT.ForeColor = System.Drawing.Color.White;
            this.atualizarBT.Location = new System.Drawing.Point(392, 317);
            this.atualizarBT.Name = "atualizarBT";
            this.atualizarBT.Size = new System.Drawing.Size(95, 46);
            this.atualizarBT.TabIndex = 25;
            this.atualizarBT.Text = "Atualizar";
            this.atualizarBT.UseVisualStyleBackColor = false;
            this.atualizarBT.Click += new System.EventHandler(this.atualizarBT_Click);
            // 
            // idTB
            // 
            this.idTB.Enabled = false;
            this.idTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.idTB.Location = new System.Drawing.Point(392, 54);
            this.idTB.MaxLength = 2;
            this.idTB.Name = "idTB";
            this.idTB.ReadOnly = true;
            this.idTB.Size = new System.Drawing.Size(48, 29);
            this.idTB.TabIndex = 26;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.idLabel.Location = new System.Drawing.Point(388, 31);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(28, 21);
            this.idLabel.TabIndex = 27;
            this.idLabel.Text = "ID:";
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(778, 408);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.atualizarBT);
            this.Controls.Add(this.telefoneMTB);
            this.Controls.Add(this.cepMTB);
            this.Controls.Add(this.cpfMTB);
            this.Controls.Add(this.rgLabel);
            this.Controls.Add(this.rgTB);
            this.Controls.Add(this.cepLabel);
            this.Controls.Add(this.consultarBT);
            this.Controls.Add(this.incluirBT);
            this.Controls.Add(this.limparBT);
            this.Controls.Add(this.excluirBT);
            this.Controls.Add(this.Telefonelabel);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.ufTB);
            this.Controls.Add(this.cidadeTB);
            this.Controls.Add(this.enderecoTB);
            this.Controls.Add(this.nomeTB);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.ufLabel);
            this.Controls.Add(this.cidadeLabel);
            this.Controls.Add(this.enderecoLabel);
            this.Controls.Add(this.cpfLabel);
            this.Controls.Add(this.nomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cliente_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nomeLabel;
        private Label cpfLabel;
        private Label enderecoLabel;
        private Label cidadeLabel;
        private Label ufLabel;
        private Label emailLabel;
        private TextBox nomeTB;
        private TextBox enderecoTB;
        private TextBox cidadeTB;
        private TextBox ufTB;
        private TextBox emailTB;
        private Label Telefonelabel;
        private Button excluirBT;
        private Button limparBT;
        private Button incluirBT;
        private Button consultarBT;
        private Label cepLabel;
        private TextBox rgTB;
        private Label rgLabel;
        private MaskedTextBox cpfMTB;
        private MaskedTextBox cepMTB;
        private MaskedTextBox telefoneMTB;
        private Button atualizarBT;
        private TextBox idTB;
        private Label idLabel;
    }
}