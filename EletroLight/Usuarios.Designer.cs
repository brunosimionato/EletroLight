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
            this.incluirButton1 = new System.Windows.Forms.Button();
            this.limparButton = new System.Windows.Forms.Button();
            this.excluirBt = new System.Windows.Forms.Button();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.senhaSabel = new System.Windows.Forms.Label();
            this.consultarBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // incluirButton1
            // 
            this.incluirButton1.BackColor = System.Drawing.Color.ForestGreen;
            this.incluirButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incluirButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.incluirButton1.ForeColor = System.Drawing.Color.White;
            this.incluirButton1.Location = new System.Drawing.Point(45, 264);
            this.incluirButton1.Name = "incluirButton1";
            this.incluirButton1.Size = new System.Drawing.Size(95, 46);
            this.incluirButton1.TabIndex = 56;
            this.incluirButton1.Text = "Incluir";
            this.incluirButton1.UseVisualStyleBackColor = false;
            // 
            // limparButton
            // 
            this.limparButton.BackColor = System.Drawing.Color.DarkOrange;
            this.limparButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limparButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.limparButton.ForeColor = System.Drawing.Color.White;
            this.limparButton.Location = new System.Drawing.Point(260, 264);
            this.limparButton.Name = "limparButton";
            this.limparButton.Size = new System.Drawing.Size(95, 46);
            this.limparButton.TabIndex = 55;
            this.limparButton.Text = "Limpar";
            this.limparButton.UseVisualStyleBackColor = false;
            // 
            // excluirBt
            // 
            this.excluirBt.BackColor = System.Drawing.Color.DarkRed;
            this.excluirBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluirBt.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.excluirBt.ForeColor = System.Drawing.Color.White;
            this.excluirBt.Location = new System.Drawing.Point(163, 264);
            this.excluirBt.Name = "excluirBt";
            this.excluirBt.Size = new System.Drawing.Size(95, 46);
            this.excluirBt.TabIndex = 54;
            this.excluirBt.Text = "Excluir";
            this.excluirBt.UseVisualStyleBackColor = false;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nomeTextBox.Location = new System.Drawing.Point(45, 45);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(296, 29);
            this.nomeTextBox.TabIndex = 50;
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
            // senhaTextBox
            // 
            this.senhaTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.senhaTextBox.Location = new System.Drawing.Point(45, 178);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(296, 29);
            this.senhaTextBox.TabIndex = 58;
            // 
            // senhaSabel
            // 
            this.senhaSabel.AutoSize = true;
            this.senhaSabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.senhaSabel.Location = new System.Drawing.Point(41, 154);
            this.senhaSabel.Name = "senhaSabel";
            this.senhaSabel.Size = new System.Drawing.Size(56, 21);
            this.senhaSabel.TabIndex = 59;
            this.senhaSabel.Text = "Senha:";
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
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(396, 329);
            this.Controls.Add(this.consultarBT);
            this.Controls.Add(this.senhaSabel);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.incluirButton1);
            this.Controls.Add(this.limparButton);
            this.Controls.Add(this.excluirBt);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.usuarioLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button incluirButton1;
        private Button limparButton;
        private Button excluirBt;
        private TextBox nomeTextBox;
        private Label usuarioLabel;
        private TextBox senhaTextBox;
        private Label senhaSabel;
        private Button consultarBT;
    }
}