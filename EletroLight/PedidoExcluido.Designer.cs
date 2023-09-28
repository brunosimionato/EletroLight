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
            this.PedidoExluidoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PedidoExluidoDGV.Location = new System.Drawing.Point(23, 76);
            this.PedidoExluidoDGV.MultiSelect = false;
            this.PedidoExluidoDGV.Name = "PedidoExluidoDGV";
            this.PedidoExluidoDGV.ReadOnly = true;
            this.PedidoExluidoDGV.RowHeadersVisible = false;
            this.PedidoExluidoDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PedidoExluidoDGV.Size = new System.Drawing.Size(763, 347);
            this.PedidoExluidoDGV.TabIndex = 0;
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nomeLabel.Location = new System.Drawing.Point(301, 35);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(211, 21);
            this.nomeLabel.TabIndex = 47;
            this.nomeLabel.Text = "Relação de Pedidos Excluídos";
            // 
            // PedidoExcluido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(814, 445);
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
    }
}