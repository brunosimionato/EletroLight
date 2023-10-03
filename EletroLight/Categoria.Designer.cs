using System.Drawing;
using System.Windows.Forms;

namespace EletroLight
{
    partial class Categoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categoria));
            this.consultarBT = new System.Windows.Forms.Button();
            this.incluirBT = new System.Windows.Forms.Button();
            this.excluirBT = new System.Windows.Forms.Button();
            this.descricaoTB = new System.Windows.Forms.TextBox();
            this.nomeCliLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.limparBT = new System.Windows.Forms.Button();
            this.idTB = new System.Windows.Forms.TextBox();
            this.atualizarBT = new System.Windows.Forms.Button();
            this.categoriaDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // consultarBT
            // 
            this.consultarBT.BackColor = System.Drawing.Color.SlateGray;
            this.consultarBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consultarBT.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.consultarBT.ForeColor = System.Drawing.Color.White;
            this.consultarBT.Location = new System.Drawing.Point(35, 69);
            this.consultarBT.Name = "consultarBT";
            this.consultarBT.Size = new System.Drawing.Size(89, 40);
            this.consultarBT.TabIndex = 63;
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
            this.incluirBT.Location = new System.Drawing.Point(35, 304);
            this.incluirBT.Name = "incluirBT";
            this.incluirBT.Size = new System.Drawing.Size(89, 40);
            this.incluirBT.TabIndex = 62;
            this.incluirBT.Text = "Incluir";
            this.incluirBT.UseVisualStyleBackColor = false;
            this.incluirBT.Click += new System.EventHandler(this.incluirBT_Click);
            // 
            // excluirBT
            // 
            this.excluirBT.BackColor = System.Drawing.Color.DarkRed;
            this.excluirBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluirBT.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.excluirBT.ForeColor = System.Drawing.Color.White;
            this.excluirBT.Location = new System.Drawing.Point(260, 304);
            this.excluirBT.Name = "excluirBT";
            this.excluirBT.Size = new System.Drawing.Size(89, 40);
            this.excluirBT.TabIndex = 60;
            this.excluirBT.Text = "Excluir";
            this.excluirBT.UseVisualStyleBackColor = false;
            this.excluirBT.Click += new System.EventHandler(this.excluirBT_Click);
            // 
            // descricaoTB
            // 
            this.descricaoTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.descricaoTB.Location = new System.Drawing.Point(151, 34);
            this.descricaoTB.MaxLength = 50;
            this.descricaoTB.Name = "descricaoTB";
            this.descricaoTB.Size = new System.Drawing.Size(293, 29);
            this.descricaoTB.TabIndex = 59;
            // 
            // nomeCliLabel
            // 
            this.nomeCliLabel.AutoSize = true;
            this.nomeCliLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nomeCliLabel.Location = new System.Drawing.Point(147, 10);
            this.nomeCliLabel.Name = "nomeCliLabel";
            this.nomeCliLabel.Size = new System.Drawing.Size(80, 21);
            this.nomeCliLabel.TabIndex = 58;
            this.nomeCliLabel.Text = "Categoria:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(31, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 21);
            this.label1.TabIndex = 65;
            this.label1.Text = "ID:";
            // 
            // limparBT
            // 
            this.limparBT.BackColor = System.Drawing.Color.DarkOrange;
            this.limparBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limparBT.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.limparBT.ForeColor = System.Drawing.Color.White;
            this.limparBT.Location = new System.Drawing.Point(355, 304);
            this.limparBT.Name = "limparBT";
            this.limparBT.Size = new System.Drawing.Size(89, 40);
            this.limparBT.TabIndex = 66;
            this.limparBT.Text = "Limpar";
            this.limparBT.UseVisualStyleBackColor = false;
            this.limparBT.Click += new System.EventHandler(this.limparBT_Click);
            // 
            // idTB
            // 
            this.idTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.idTB.Location = new System.Drawing.Point(35, 34);
            this.idTB.MaxLength = 50;
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(89, 29);
            this.idTB.TabIndex = 64;
            // 
            // atualizarBT
            // 
            this.atualizarBT.BackColor = System.Drawing.SystemColors.HotTrack;
            this.atualizarBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atualizarBT.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.atualizarBT.ForeColor = System.Drawing.Color.White;
            this.atualizarBT.Location = new System.Drawing.Point(165, 304);
            this.atualizarBT.Name = "atualizarBT";
            this.atualizarBT.Size = new System.Drawing.Size(89, 40);
            this.atualizarBT.TabIndex = 67;
            this.atualizarBT.Text = "Atualizar";
            this.atualizarBT.UseVisualStyleBackColor = false;
            this.atualizarBT.Click += new System.EventHandler(this.atualizarBT_Click);
            // 
            // categoriaDGV
            // 
            this.categoriaDGV.AllowUserToAddRows = false;
            this.categoriaDGV.AllowUserToDeleteRows = false;
            this.categoriaDGV.AllowUserToResizeColumns = false;
            this.categoriaDGV.AllowUserToResizeRows = false;
            this.categoriaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriaDGV.Location = new System.Drawing.Point(35, 135);
            this.categoriaDGV.MultiSelect = false;
            this.categoriaDGV.Name = "categoriaDGV";
            this.categoriaDGV.ReadOnly = true;
            this.categoriaDGV.RowHeadersVisible = false;
            this.categoriaDGV.RowTemplate.Height = 25;
            this.categoriaDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.categoriaDGV.Size = new System.Drawing.Size(409, 129);
            this.categoriaDGV.TabIndex = 82;
            // 
            // Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(493, 366);
            this.Controls.Add(this.categoriaDGV);
            this.Controls.Add(this.atualizarBT);
            this.Controls.Add(this.limparBT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.consultarBT);
            this.Controls.Add(this.incluirBT);
            this.Controls.Add(this.excluirBT);
            this.Controls.Add(this.descricaoTB);
            this.Controls.Add(this.nomeCliLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Categoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.Categoria_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Categoria_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.categoriaDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button consultarBT;
        private Button incluirBT;
        private Button excluirBT;
        private TextBox descricaoTB;
        private Label nomeCliLabel;
        private Label label1;
        private Button limparBT;
        private TextBox idTB;
        private Button atualizarBT;
        private DataGridView categoriaDGV;
    }
}