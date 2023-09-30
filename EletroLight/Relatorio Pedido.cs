using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EletroLight
{
    public partial class RelatorioPedido : Form
    {
        public RelatorioPedido()
        {
            InitializeComponent();
            this.KeyPreview = true;

        }


        // FECHA O FORMULÁRIO COM ESC
        private void RelatorioPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }


        // CARREGA O REPORTVIEW NO LAYOUT DE IMPRESSÃO
        private void RelatorioPedido_Load(object sender, EventArgs e)
        {
            this.view_PedidoTableAdapter.Fill(this.eLETROLIGHTDataSet.view_Pedido);
            this.reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        }
    }
}
