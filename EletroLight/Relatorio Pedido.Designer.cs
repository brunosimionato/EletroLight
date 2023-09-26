namespace EletroLight
{
    partial class RelatorioPedido
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioPedido));
            this.viewPedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eLETROLIGHTDataSet = new EletroLight.ELETROLIGHTDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.view_PedidoTableAdapter = new EletroLight.ELETROLIGHTDataSetTableAdapters.view_PedidoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.viewPedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLETROLIGHTDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // viewPedidoBindingSource
            // 
            this.viewPedidoBindingSource.DataMember = "view_Pedido";
            this.viewPedidoBindingSource.DataSource = this.eLETROLIGHTDataSet;
            // 
            // eLETROLIGHTDataSet
            // 
            this.eLETROLIGHTDataSet.DataSetName = "ELETROLIGHTDataSet";
            this.eLETROLIGHTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "tabela_pedidos";
            reportDataSource1.Value = this.viewPedidoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EletroLight.Relatorios.Relatorio Pedido.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1107, 749);
            this.reportViewer1.TabIndex = 0;
            // 
            // view_PedidoTableAdapter
            // 
            this.view_PedidoTableAdapter.ClearBeforeFill = true;
            // 
            // RelatorioPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1107, 749);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RelatorioPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio de Pedidos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RelatorioPedido_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RelatorioPedido_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.viewPedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLETROLIGHTDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ELETROLIGHTDataSet eLETROLIGHTDataSet;
        private System.Windows.Forms.BindingSource viewPedidoBindingSource;
        private ELETROLIGHTDataSetTableAdapters.view_PedidoTableAdapter view_PedidoTableAdapter;
    }
}