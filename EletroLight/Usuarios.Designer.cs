using System.Drawing;
using System.Windows.Forms;

namespace EletroLight
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.incluirBT = new System.Windows.Forms.Button();
            this.limparBT = new System.Windows.Forms.Button();
            this.excluirBT = new System.Windows.Forms.Button();
            this.usuarioTB = new System.Windows.Forms.TextBox();
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.senhaTB = new System.Windows.Forms.TextBox();
            this.senhaLabel = new System.Windows.Forms.Label();
            this.consultarBT = new System.Windows.Forms.Button();
            this.usuarioDGV = new System.Windows.Forms.DataGridView();
            this.idLabel = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.TextBox();
            this.atualizarBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // incluirBT
            // 
            this.incluirBT.BackColor = System.Drawing.Color.ForestGreen;
            this.incluirBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incluirBT.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.incluirBT.ForeColor = System.Drawing.Color.White;
            this.incluirBT.Location = new System.Drawing.Point(45, 264);
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
            this.limparBT.Location = new System.Drawing.Point(428, 264);
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
            this.excluirBT.Location = new System.Drawing.Point(327, 264);
            this.excluirBT.Name = "excluirBT";
            this.excluirBT.Size = new System.Drawing.Size(95, 46);
            this.excluirBT.TabIndex = 54;
            this.excluirBT.Text = "Excluir";
            this.excluirBT.UseVisualStyleBackColor = false;
            this.excluirBT.Click += new System.EventHandler(this.excluirBT_Click);
            // 
            // usuarioTB
            // 
            this.usuarioTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.usuarioTB.Location = new System.Drawing.Point(45, 45);
            this.usuarioTB.MaxLength = 50;
            this.usuarioTB.Name = "usuarioTB";
            this.usuarioTB.Size = new System.Drawing.Size(216, 29);
            this.usuarioTB.TabIndex = 50;
            // 
            // usuarioLabel
            // 
            this.usuarioLabel.AutoSize = true;
            this.usuarioLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.usuarioLabel.Location = new System.Drawing.Point(41, 21);
            this.usuarioLabel.Name = "usuarioLabel";
            this.usuarioLabel.Size = new System.Drawing.Size(64, 21);
            this.usuarioLabel.TabIndex = 46;
            this.usuarioLabel.Text = "Usuário";
            // 
            // senhaTB
            // 
            this.senhaTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.senhaTB.Location = new System.Drawing.Point(348, 45);
            this.senhaTB.MaxLength = 10;
            this.senhaTB.Name = "senhaTB";
            this.senhaTB.Size = new System.Drawing.Size(175, 29);
            this.senhaTB.TabIndex = 58;
            // 
            // senhaLabel
            // 
            this.senhaLabel.AutoSize = true;
            this.senhaLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.senhaLabel.Location = new System.Drawing.Point(344, 21);
            this.senhaLabel.Name = "senhaLabel";
            this.senhaLabel.Size = new System.Drawing.Size(56, 21);
            this.senhaLabel.TabIndex = 59;
            this.senhaLabel.Text = "Senha:";
            // 
            // consultarBT
            // 
            this.consultarBT.BackColor = System.Drawing.Color.SlateGray;
            this.consultarBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consultarBT.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.consultarBT.ForeColor = System.Drawing.Color.White;
            this.consultarBT.Location = new System.Drawing.Point(45, 80);
            this.consultarBT.Name = "consultarBT";
            this.consultarBT.Size = new System.Drawing.Size(95, 46);
            this.consultarBT.TabIndex = 60;
            this.consultarBT.Text = "Consultar";
            this.consultarBT.UseVisualStyleBackColor = false;
            this.consultarBT.Click += new System.EventHandler(this.consultarBT_Click);
            // 
            // usuarioDGV
            // 
            this.usuarioDGV.AllowUserToAddRows = false;
            this.usuarioDGV.AllowUserToDeleteRows = false;
            this.usuarioDGV.AllowUserToResizeColumns = false;
            this.usuarioDGV.AllowUserToResizeRows = false;
            this.usuarioDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuarioDGV.Location = new System.Drawing.Point(42, 142);
            this.usuarioDGV.MultiSelect = false;
            this.usuarioDGV.Name = "usuarioDGV";
            this.usuarioDGV.ReadOnly = true;
            this.usuarioDGV.RowHeadersVisible = false;
            this.usuarioDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.usuarioDGV.Size = new System.Drawing.Size(481, 97);
            this.usuarioDGV.TabIndex = 61;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.idLabel.Location = new System.Drawing.Point(276, 21);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(28, 21);
            this.idLabel.TabIndex = 73;
            this.idLabel.Text = "ID:";
            // 
            // idTB
            // 
            this.idTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.idTB.Location = new System.Drawing.Point(277, 45);
            this.idTB.MaxLength = 2;
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(53, 29);
            this.idTB.TabIndex = 72;
            this.idTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idTB_KeyPress);
            // 
            // atualizarBT
            // 
            this.atualizarBT.BackColor = System.Drawing.SystemColors.HotTrack;
            this.atualizarBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atualizarBT.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.atualizarBT.ForeColor = System.Drawing.Color.White;
            this.atualizarBT.Location = new System.Drawing.Point(226, 264);
            this.atualizarBT.Name = "atualizarBT";
            this.atualizarBT.Size = new System.Drawing.Size(95, 46);
            this.atualizarBT.TabIndex = 74;
            this.atualizarBT.Text = "Atualizar";
            this.atualizarBT.UseVisualStyleBackColor = false;
            this.atualizarBT.Click += new System.EventHandler(this.atualizarBT_Click);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(571, 329);
            this.Controls.Add(this.atualizarBT);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.usuarioDGV);
            this.Controls.Add(this.consultarBT);
            this.Controls.Add(this.senhaLabel);
            this.Controls.Add(this.senhaTB);
            this.Controls.Add(this.incluirBT);
            this.Controls.Add(this.limparBT);
            this.Controls.Add(this.excluirBT);
            this.Controls.Add(this.usuarioTB);
            this.Controls.Add(this.usuarioLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuários";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Usuarios_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button incluirBT;
        private Button limparBT;
        private Button excluirBT;
        private TextBox usuarioTB;
        private Label usuarioLabel;
        private TextBox senhaTB;
        private Label senhaLabel;
        private Button consultarBT;
        private DataGridView usuarioDGV;
        private Label idLabel;
        private TextBox idTB;
        private Button atualizarBT;
    }
}