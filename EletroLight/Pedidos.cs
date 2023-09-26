using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace EletroLight
{
    public partial class Pedido : Form
    {
        public Pedido()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }


        // Fecha o Formulário com ESC //
        private void Pedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }


        // CONFIGURAÇÃO DAS COMBOBOX //
        private void Pedido_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-BRUNO\\SQLEXPRESS;Initial Catalog=ELETROLIGHT;Integrated Security=True");

            // Configuração da ComboBox de Cliente
            SqlCommand cmdCliente = new SqlCommand("SELECT nome FROM Cliente", conn);
            SqlDataAdapter daCliente = new SqlDataAdapter();
            daCliente.SelectCommand = cmdCliente;
            DataTable tableCliente = new DataTable();
            daCliente.Fill(tableCliente);
            clienteCB.DataSource = tableCliente;
            clienteCB.DisplayMember = "nome";
            clienteCB.ValueMember = "nome";
            clienteCB.SelectedIndex = -1;
            clienteCB.SelectedIndexChanged += clienteCB_SelectedIndexChanged;

            // Configuração da ComboBox de Produto
            SqlCommand cmdProduto = new SqlCommand("SELECT produto FROM Produto", conn);
            SqlDataAdapter daProduto = new SqlDataAdapter();
            daProduto.SelectCommand = cmdProduto;
            DataTable tableProduto = new DataTable();
            daProduto.Fill(tableProduto);
            produtoCB.DataSource = tableProduto;
            produtoCB.DisplayMember = "produto";
            produtoCB.ValueMember = "produto";
            produtoCB.SelectedIndex = -1;


            // CONFIGURAÇÃO DA DATA GRID //
            {
                SqlConnection conexao = new SqlConnection("Data Source=LAPTOP-BRUNO\\SQLEXPRESS;Initial Catalog=ELETROLIGHT;Integrated Security=True");
                conexao.Open();

                string queryAtualizacao = "SELECT * FROM view_Pedido";
                SqlCommand comandoAtualizacao = new SqlCommand(queryAtualizacao, conexao);
                SqlDataAdapter adaptadorAtualizacao = new SqlDataAdapter(comandoAtualizacao);
                DataSet dataSetAtualizado = new DataSet();
                adaptadorAtualizacao.Fill(dataSetAtualizado);

                dataGV.DataSource = dataSetAtualizado.Tables[0];
                conexao.Close();

                dataGV.Columns[0].HeaderText = "ID";
                dataGV.Columns[1].HeaderText = "Cliente";
                dataGV.Columns[2].HeaderText = "CPF";
                dataGV.Columns[3].HeaderText = "Produto";
                dataGV.Columns[4].HeaderText = "Qtd.";
                dataGV.Columns[5].HeaderText = "Data";
                dataGV.Columns[6].HeaderText = "Valor Unitário";
                dataGV.Columns[7].HeaderText = "Valor Total";

                foreach (DataGridViewColumn coluna in dataGV.Columns)
                {
                    coluna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                foreach (DataGridViewColumn coluna in dataGV.Columns)
                {
                    coluna.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                dataGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                foreach (DataGridViewColumn coluna in dataGV.Columns)
                {
                    coluna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    coluna.HeaderCell.Style.WrapMode = DataGridViewTriState.True;
                    coluna.HeaderCell.Style.Font = new Font(dataGV.Font, FontStyle.Bold);
                    coluna.HeaderCell.Style.Padding = new Padding(3, 3, 3, 3);
                }

                // Adicionando a formatação para valores
                dataGV.CellFormatting += (senderGrid, eventArgs) =>
                {
                    int valorColumnIndex = 6;
                    int valorTotalColumnIndex = 7;

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
        }


        // FUNÇÃO PARA ATUALIZAR A DATA GRID VIEW APÓS INSERIR UM CLIENTE NOVO //
        private void AtualizarDataGridView()
        {
            using (SqlConnection conexao = new SqlConnection("Data Source=LAPTOP-BRUNO\\SQLEXPRESS;Initial Catalog=ELETROLIGHT;Integrated Security=True"))
            {
                conexao.Open();

                string queryAtualizacao = "SELECT * FROM view_Pedido";
                SqlCommand comandoAtualizacao = new SqlCommand(queryAtualizacao, conexao);
                SqlDataAdapter adaptadorAtualizacao = new SqlDataAdapter(comandoAtualizacao);
                DataSet dataSetAtualizado = new DataSet();
                adaptadorAtualizacao.Fill(dataSetAtualizado);

                dataGV.DataSource = dataSetAtualizado.Tables[0];
            }
        }


        // ACEITA APENAS NÚMEROS NA QUANTIDADETB //
        private void quantidadeTB_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }        


        // ATUALIZA A TEXTBOX DO CPF COM BASE NO CLIENTE SELECIONADO //
        private void clienteCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clienteCB.SelectedIndex != -1)
            {
                string selectedNome = clienteCB?.SelectedValue?.ToString() ?? "";

                using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-BRUNO\\SQLEXPRESS;Initial Catalog=ELETROLIGHT;Integrated Security=True"))
                {
                    conn.Open();
                    string query = "SELECT cpf FROM Cliente WHERE nome = @nome";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nome", selectedNome);

                    string cpf = (string)cmd.ExecuteScalar();
                    cpfMTB.Text = cpf;
                }

            }
        }


        // ATUALIZA A TEXBOX VALOR UNITÁRIO COM BASE NO PRODUTO SELECIONADO //
        private void produtoCB_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (produtoCB.SelectedItem != null)
            {
                string selectedProduto = produtoCB.SelectedValue?.ToString() ?? "";

                using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-BRUNO\\SQLEXPRESS;Initial Catalog=ELETROLIGHT;Integrated Security=True"))
                {
                    conn.Open();

                    string query = "SELECT dbo.ObterValorUnitarioProduto(@produto)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@produto", selectedProduto);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal valorUnitario = (decimal)result;
                        valor_unitarioTB.Text = valorUnitario.ToString("0.00"); // Exibe o valor com duas casas decimais
                    }
                    else
                    {
                        valor_unitarioTB.Text = "";
                    }
                }

                CalcularEAtualizarValorTotal();
            }
            else
            {
                valor_unitarioTB.Text = "";
                valor_totalTB.Text = "";
            }
        }


        // CALULA O VALOR TOTAL COM BASE NA QUANTIDADE E VALOR UNITÁRIO //
        private void CalcularEAtualizarValorTotal()
        {
            if (!string.IsNullOrEmpty(valor_unitarioTB.Text) && int.TryParse(quantidadeTB.Text, out int quantidade))
            {
                decimal valorUnitario = decimal.Parse(valor_unitarioTB.Text, new CultureInfo("pt-BR"));

                decimal valorTotal = quantidade * valorUnitario;

                valor_totalTB.Text = valorTotal.ToString("#,##0.00"); // Exibe o valor total com duas casas decimais
            }
            else
            {
                valor_totalTB.Text = "";
            }
        }


        // Toda a vez que um número é inserido dentro da quantidadeTB o calculo de multiplicação é feito //
        private void quantidadeTB_KeyUp(object sender, KeyEventArgs e)
        {
            CalcularEAtualizarValorTotal();
        }


        // BOTÃO INCLUIR //
        private void incluirBT_Click(object sender, EventArgs e)
        {
            try
            {
                string cliente = clienteCB.SelectedValue?.ToString() ?? "";
                string cpf = cpfMTB.Text ?? "";
                string produto = produtoCB.SelectedValue?.ToString() ?? "";
                int quantidade = string.IsNullOrEmpty(quantidadeTB.Text) ? 0 : Convert.ToInt32(quantidadeTB.Text);

                if (string.IsNullOrEmpty(cliente) || string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(produto) || quantidade <= 0)
                {
                    MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar se a data é válida antes de tentar a conversão
                DateTime data;
                if (!DateTime.TryParseExact(dataMTB.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out data))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal valorUnitario = string.IsNullOrEmpty(valor_unitarioTB.Text) ? 0 : decimal.Parse(valor_unitarioTB.Text, NumberStyles.Currency, CultureInfo.CurrentCulture);
                decimal valorTotal = string.IsNullOrEmpty(valor_totalTB.Text) ? 0 : decimal.Parse(valor_totalTB.Text, NumberStyles.Currency, CultureInfo.CurrentCulture);

                using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-BRUNO\\SQLEXPRESS;Initial Catalog=ELETROLIGHT;Integrated Security=True"))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("InserirPedido", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@cliente", cliente);
                        cmd.Parameters.AddWithValue("@cpf", cpf);
                        cmd.Parameters.AddWithValue("@produto", produto);
                        cmd.Parameters.AddWithValue("@quantidade", quantidade);
                        cmd.Parameters.AddWithValue("@data", data);
                        cmd.Parameters.AddWithValue("@valor_unitario", valorUnitario);
                        cmd.Parameters.AddWithValue("@valor_total", valorTotal);

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("O campo ID é gerado automaticamente e não pode ser definido pelo usuário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MessageBox.Show("Pedido inserido com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clienteCB.SelectedIndex = -1;
                idTB.Text = string.Empty;
                cpfMTB.Text = "";
                produtoCB.SelectedIndex = -1;
                quantidadeTB.Text = "";
                dataMTB.Text = "";
                valor_unitarioTB.Text = "";
                valor_totalTB.Text = "";

                // Atualizar a DataGridView após a inserção //
                AtualizarDataGridView();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao inserir Produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // BOTÃO CONSULTAR //
        private void consultarBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(idTB.Text))
                {
                    MessageBox.Show("Insira o ID do pedido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idPedido = Convert.ToInt32(idTB.Text);

                using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-BRUNO\\SQLEXPRESS;Initial Catalog=ELETROLIGHT;Integrated Security=True"))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("ConsultarPedido", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_pedido", idPedido);

                        SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                        DataSet dataSet = new DataSet();
                        adaptador.Fill(dataSet);

                        if (dataSet.Tables[0].Rows.Count > 0)
                        {
                            DataRow row = dataSet.Tables[0].Rows[0];

                            int idCliente = Convert.ToInt32(row["id_cliente"]);
                            int idProduto = Convert.ToInt32(row["id_produto"]);

                            string nomeCliente = ObterNomeCliente(idCliente);
                            string nomeProduto = ObterNomeProduto(idProduto);

                            clienteCB.Text = nomeCliente;
                            produtoCB.Text = nomeProduto;

                            cpfMTB.Text = row["cpf"].ToString();
                            quantidadeTB.Text = row["quantidade"].ToString();
                            dataMTB.Text = ((DateTime)row["data"]).ToString("dd/MM/yyyy");
                            valor_unitarioTB.Text = ((decimal)row["valor_unitario"]).ToString("N2");
                            valor_totalTB.Text = ((decimal)row["valor_total"]).ToString("N2");
                        }
                        else
                        {
                            MessageBox.Show("Nenhum pedido encontrado para o ID informado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar Pedido: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ObterNomeCliente(int idCliente)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-BRUNO\\SQLEXPRESS;Initial Catalog=ELETROLIGHT;Integrated Security=True"))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT nome FROM Cliente WHERE id_cliente = @id_cliente", conn))
                {
                    cmd.Parameters.AddWithValue("@id_cliente", idCliente);
                    return (string)cmd.ExecuteScalar();
                }
            }
        }

        private string ObterNomeProduto(int idProduto)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-BRUNO\\SQLEXPRESS;Initial Catalog=ELETROLIGHT;Integrated Security=True"))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT produto FROM Produto WHERE id_produto = @id_produto", conn))
                {
                    cmd.Parameters.AddWithValue("@id_produto", idProduto);
                    return (string)cmd.ExecuteScalar();
                }
            }
        }


        // BOTÃO LIMPAR //
        private void limparBT_Click(object sender, EventArgs e)
        {
            clienteCB.SelectedIndex = -1;
            idTB.Text = string.Empty;
            cpfMTB.Text = string.Empty;
            produtoCB.SelectedIndex = -1;
            quantidadeTB.Text = string.Empty;
            dataMTB.Text = string.Empty;
            valor_unitarioTB.Text = string.Empty;
            valor_totalTB.Text = string.Empty;
        }


        // BOTÃO EXCLUIR // 
        private void excluirBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(clienteCB.Text) ||
                    string.IsNullOrWhiteSpace(idTB.Text) ||
                    string.IsNullOrWhiteSpace(cpfMTB.Text) ||
                    string.IsNullOrWhiteSpace(produtoCB.Text) ||
                    string.IsNullOrWhiteSpace(quantidadeTB.Text) ||
                    string.IsNullOrWhiteSpace(dataMTB.Text) ||
                    string.IsNullOrWhiteSpace(valor_unitarioTB.Text) ||
                    string.IsNullOrWhiteSpace(valor_totalTB.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir o Pedido?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    string connectionString = @"Data Source=LAPTOP-BRUNO\SQLEXPRESS;Initial Catalog=ELETROLIGHT;Integrated Security=True";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand cmd = new SqlCommand("ExcluirPedido", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_pedido", idTB.Text);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Pedido excluído com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clienteCB.SelectedIndex = -1;
                            idTB.Text = string.Empty;
                            cpfMTB.Text = string.Empty;
                            produtoCB.SelectedIndex = -1;
                            quantidadeTB.Text = string.Empty;
                            dataMTB.Text = string.Empty;
                            valor_unitarioTB.Text = string.Empty;
                            valor_totalTB.Text = string.Empty;

                            // Atualizar a DataGridView após a inserção //
                            AtualizarDataGridView();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir Pedido: " + ex.Message);
            }
        }


        // BOTÃO ATUALIZAR //
        private void atualizarBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(clienteCB.Text) ||
                    string.IsNullOrWhiteSpace(idTB.Text) ||
                    string.IsNullOrWhiteSpace(cpfMTB.Text) ||
                    string.IsNullOrWhiteSpace(produtoCB.Text) ||
                    string.IsNullOrWhiteSpace(quantidadeTB.Text) ||
                    string.IsNullOrWhiteSpace(dataMTB.Text) ||
                    string.IsNullOrWhiteSpace(valor_unitarioTB.Text) ||
                    string.IsNullOrWhiteSpace(valor_totalTB.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult resultado = MessageBox.Show("Tem certeza que deseja atualizar os dados do Pedido?\n" +
                    "Note que o ID não pode ser alterado.", "Confirmação de Atualização", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    string cliente = clienteCB.Text;
                    int id_pedido = Convert.ToInt32(idTB.Text);
                    string produto = produtoCB.Text;
                    int quantidade = Convert.ToInt32(quantidadeTB.Text);
                    DateTime data = DateTime.ParseExact(dataMTB.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                    decimal valor_unitario = decimal.Parse(valor_unitarioTB.Text, NumberStyles.Currency);
                    decimal valor_total = decimal.Parse(valor_totalTB.Text, NumberStyles.Currency);

                    string connectionString = @"Data Source=LAPTOP-BRUNO\SQLEXPRESS;Initial Catalog=ELETROLIGHT;Integrated Security=True";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand cmdAtualizarPedido = new SqlCommand("AtualizarPedido", connection))
                        {
                            cmdAtualizarPedido.CommandType = CommandType.StoredProcedure;

                            cmdAtualizarPedido.Parameters.AddWithValue("@cliente", cliente);
                            cmdAtualizarPedido.Parameters.AddWithValue("@id_pedido", id_pedido);
                            cmdAtualizarPedido.Parameters.AddWithValue("@produto", produto);
                            cmdAtualizarPedido.Parameters.AddWithValue("@quantidade", quantidade);
                            cmdAtualizarPedido.Parameters.AddWithValue("@data", data);
                            cmdAtualizarPedido.Parameters.AddWithValue("@valor_unitario", valor_unitario);
                            cmdAtualizarPedido.Parameters.AddWithValue("@valor_total", valor_total);

                            cmdAtualizarPedido.ExecuteNonQuery();

                            MessageBox.Show("Pedido atualizado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            valor_unitarioTB.Text = valor_unitario.ToString("N2");
                            valor_totalTB.Text = valor_total.ToString("N2");

                            AtualizarDataGridView();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar Pedido: " + ex.Message);
            }
        }


        // BOTÃO RELATÓRIO //
        private void relatorioBT_Click(object sender, EventArgs e)
        {
            RelatorioPedido frm = new RelatorioPedido();
            frm.Show();
        }
    }
}
