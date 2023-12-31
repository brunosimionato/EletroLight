﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EletroLight
{
    public partial class PedidoExcluido : Form
    {
        public PedidoExcluido()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }


        // FECHA O FORMULÁRIO COM ESC
        private void PedidoExcluido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

        }


        private void PedidoExcluido_Load(object sender, EventArgs e)
        {
            // CONFIGURAÇÃO DA DATAGRIDVIEW
            {
                SqlConnection conexao = new SqlConnection("Data Source=LAPTOP-BRUNO\\SQLEXPRESS;Initial Catalog=ELETROLIGHT;Integrated Security=True");
                conexao.Open();

                string queryAtualizacao = "SELECT * FROM PedidoExcluido";
                SqlCommand comandoAtualizacao = new SqlCommand(queryAtualizacao, conexao);
                SqlDataAdapter adaptadorAtualizacao = new SqlDataAdapter(comandoAtualizacao);
                DataSet dataSetAtualizado = new DataSet();
                adaptadorAtualizacao.Fill(dataSetAtualizado);

                PedidoExluidoDGV.DataSource = dataSetAtualizado.Tables[0];
                conexao.Close();

                PedidoExluidoDGV.Columns[0].HeaderText = "ID";
                PedidoExluidoDGV.Columns[1].HeaderText = "ID Pedido";
                PedidoExluidoDGV.Columns[2].HeaderText = "Cliente";
                PedidoExluidoDGV.Columns[3].HeaderText = "CPF";
                PedidoExluidoDGV.Columns[4].HeaderText = "Produto";
                PedidoExluidoDGV.Columns[5].HeaderText = "Qtd.";
                PedidoExluidoDGV.Columns[6].HeaderText = "Data";
                PedidoExluidoDGV.Columns[7].HeaderText = "Valor Unitário";
                PedidoExluidoDGV.Columns[8].HeaderText = "Valor Total";

                foreach (DataGridViewColumn coluna in PedidoExluidoDGV.Columns)
                {
                    coluna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }


                foreach (DataGridViewColumn coluna in PedidoExluidoDGV.Columns)
                {
                    coluna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                foreach (DataGridViewColumn coluna in PedidoExluidoDGV.Columns)
                {
                    coluna.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                PedidoExluidoDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                PedidoExluidoDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                foreach (DataGridViewColumn coluna in PedidoExluidoDGV.Columns)
                {
                    coluna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    coluna.HeaderCell.Style.WrapMode = DataGridViewTriState.True;
                    coluna.HeaderCell.Style.Font = new Font(PedidoExluidoDGV.Font, FontStyle.Bold);
                    coluna.HeaderCell.Style.Padding = new Padding(3, 3, 3, 3);
                }


                // ADICIONA A FORMATAÇÃO DE VALORES NA DATAGRIDVIEW
                PedidoExluidoDGV.CellFormatting += (senderGrid, eventArgs) =>
                {
                    int valorColumnIndex = 7;
                    int valorTotalColumnIndex = 8;

                    if (eventArgs.ColumnIndex == valorColumnIndex || eventArgs.ColumnIndex == valorTotalColumnIndex)
                    {
                        if (eventArgs.Value != null && eventArgs.Value is decimal)
                        {
                            eventArgs.Value = ((decimal)eventArgs.Value).ToString("N2");
                            eventArgs.FormattingApplied = true;
                        }
                    }
                };
            }

            // Substitua o 'PedidoExluidoDGV' pelo nome do seu DataGridView
            int lastIndex = PedidoExluidoDGV.Rows.Count - 1;
            PedidoExluidoDGV.Rows[lastIndex].Height = 1; // Defina a altura mínima desejada

        }


        // FILTRO POR NOME
        private void nomeTB_TextChanged(object sender, EventArgs e)
        {
            string filtro = nomeTB.Text;

            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-BRUNO\\SQLEXPRESS;Initial Catalog=ELETROLIGHT;Integrated Security=True"))
            {
                connection.Open();
                string sql = "SELECT * FROM PedidoExcluido WHERE cliente LIKE @filtro";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        PedidoExluidoDGV.DataSource = dataTable;
                    }
                }
            }
        }


    }
}

