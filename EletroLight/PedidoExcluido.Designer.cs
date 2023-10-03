namespace EletroLight
{
    partial class PedidoExcluido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidoExcluido));
            this.PedidoExluidoDGV = new System.Windows.Forms.DataGridView();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.PedidosExcluidosblindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PedidoExluidoDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PedidosExcluidosblindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PedidoExluidoDGV
            // 
            this.PedidoExluidoDGV.AllowUserToAddRows = false;
            this.PedidoExluidoDGV.AllowUserToDeleteRows = false;
            this.PedidoExluidoDGV.AllowUserToResizeColumns = false;
            this.PedidoExluidoDGV.AllowUserToResizeRows = false;
            this.PedidoExluidoDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.PedidoExluidoDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.PedidoExluidoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PedidoExluidoDGV.Location = new System.Drawing.Point(24, 139);
            this.PedidoExluidoDGV.MultiSelect = false;
            this.PedidoExluidoDGV.Name = "PedidoExluidoDGV";
            this.PedidoExluidoDGV.ReadOnly = true;
            this.PedidoExluidoDGV.RowHeadersVisible = false;
            this.PedidoExluidoDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PedidoExluidoDGV.Size = new System.Drawing.Size(840, 302);
            this.PedidoExluidoDGV.TabIndex = 0;
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeLabel.Location = new System.Drawing.Point(301, 35);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(271, 25);
            this.nomeLabel.TabIndex = 47;
            this.nomeLabel.Text = "Relação de Pedidos Excluídos";
            // 
            // nomeTB
            // 
            this.nomeTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nomeTB.Location = new System.Drawing.Point(24, 88);
            this.nomeTB.MaxLength = 100;
            this.nomeTB.Name = "nomeTB";
            this.nomeTB.Size = new System.Drawing.Size(281, 29);
            this.nomeTB.TabIndex = 49;
            this.nomeTB.TextChanged += new System.EventHandler(this.nomeTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(21, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 48;
            this.label1.Text = "Cliente:";
            // 
            // PedidoExcluido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(882, 505);
            this.Controls.Add(this.nomeTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.PedidoExluidoDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PedidoExcluido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos Excluídos";
            this.Load += new System.EventHandler(this.PedidoExcluido_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PedidoExcluido_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PedidoExluidoDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PedidosExcluidosblindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PedidoExluidoDGV;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.BindingSource PedidosExcluidosblindingSource;
        private System.Windows.Forms.TextBox nomeTB;
        private System.Windows.Forms.Label label1;
    }
}