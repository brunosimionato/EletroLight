using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;


namespace EletroLight
{
    public partial class Produto : Form
    {

        public Produto()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }


        // FECHA O FORMÚLARIO COM A TECLA ESC
        private void Produto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }


        // CONFIGURAÇÃO DAS COMBOBOX
        private void Produto_Load_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-BRUNO\\SQLEXPRESS;Initial Catalog=ELETROLIGHT;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT descricao FROM Categoria", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable table1 = new DataTable();
            da.Fill(table1);

            table1.DefaultView.Sort = "descricao ASC";
            table1 = table1.DefaultView.ToTable();

            categoriaCB.DataSource = table1;
            categoriaCB.DisplayMember = "descricao";
            categoriaCB.ValueMember = "descricao";
            categoriaCB.SelectedIndex = -1;


            SqlCommand cmdFornecedor = new SqlCommand("SELECT nome FROM Fornecedor", conn);
            SqlDataAdapter daFornecedor = new SqlDataAdapter();
            daFornecedor.SelectCommand = cmdFornecedor;
            DataTable tableFornecedor = new DataTable();
            daFornecedor.Fill(tableFornecedor);

            tableFornecedor.DefaultView.Sort = "nome ASC";
            tableFornecedor = tableFornecedor.DefaultView.ToTable();

            fornecedorCB.DataSource = tableFornecedor;
            fornecedorCB.DisplayMember = "nome";
            fornecedorCB.ValueMember = "nome";
            fornecedorCB.SelectedIndex = -1;
        }


        // FORMATA O VALOR MONETÁRIO DA TEXT BOX VALOR
        private void valorTB_TextChanged_1(object sender, EventArgs e)
        {
            string textoSemFormatacao = valorTB.Text.Replace(",", "").Replace(".", "");

            if (decimal.TryParse(textoSemFormatacao, out decimal valor))
            {
                string valorFormatado = (valor / 100).ToString("N2");

                valorTB.Text = valorFormatado;
                valorTB.SelectionStart = valorTB.Text.Length;
            }
        }


        //ACEITA APENAS NÚMEROS TEXTBOX VALOR
        private void valorTB_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        // PERMITE APENAS NÚMEROS NA TEXTBOX QUANTIDADE
        private void quantidadeTB_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        // BOTÃO INCLUIR
        private void incluirBT_Click_1(object sender, EventArgs e)
        {
            try
            {
                string produto = produtoTB.Text;
                string categoria = categoriaCB.Text;
                string valor = valorTB.Text;

                if (string.IsNullOrEmpty(produto) || string.IsNullOrEmpty(categoria) || string.IsNullOrEmpty(valor) || string.IsNullOrEmpty(quantidadeTB.Text) || string.IsNullOrEmpty(fornecedorCB.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(quantidadeTB.Text, out int quantidade) || quantidade <= 0)
                {
                    MessageBox.Show("A quantidade deve ser um número inteiro maior que zero.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    quantidadeTB.Text = string.Empty;
                    return;
                }

                string fornecedor = fornecedorCB.Text;

                string connectionString = @"Data Source=LAPTOP-BRUNO\SQLEXPRESS;Initial Catalog=ELETROLIGHT;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    bool uqProdutoExists;
                    using (SqlCommand cmdCheckUQ = new SqlCommand("SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS WHERE CONSTRAINT_NAME = 'UQ_produto'", connection))
                    {
                        uqProdutoExists = (int)cmdCheckUQ.ExecuteScalar() > 0;
                    }

                    if (!uqProdutoExists)
                    {
                        using (SqlCommand cmdCreateUQ = new SqlCommand("ALTER TABLE Produto ADD CONSTRAINT UQ_produto UNIQUE (produto)", connection))
                        {
                            cmdCreateUQ.ExecuteNonQuery();
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand("IncluirProduto", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@produto", produto);
                        cmd.Parameters.AddWithValue("@categoria", categoria);
                        cmd.Parameters.AddWithValue("@valor", decimal.Parse(valor));
                        cmd.Parameters.AddWithValue("@quantidade", quantidade);
                        cmd.Parameters.AddWithValue("@fornecedor", fornecedor);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Produto inserido com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        produtoTB.Text = string.Empty;
                        categoriaCB.SelectedIndex = -1;
                        valorTB.Text = string.Empty;
                        quantidadeTB.Text = string.Empty;
                        fornecedorCB.SelectedIndex = -1;
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("unique") || ex.Message.Contains("duplicate"))
                {
                    MessageBox.Show("Produto já está vinculado com essa \n" +
                        "combinação de categoria e fornecedor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Erro ao inserir Produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // BOTÃO CONSULTAR
         private void consultarBT_Click_1(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=LAPTOP-BRUNO\SQLEXPRESS;Initial Catalog=ELETROLIGHT;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT p.id_produto, p.produto, REPLACE(p.valor, ',', '.') as valor, p.quantidade, c.descricao as categoria, f.nome as fornecedor " +
                                                           "FROM Produto p " +
                                                           "INNER JOIN Categoria c ON p.id_categoria = c.id_categoria " +
                                                           "INNER JOIN Fornecedor f ON p.id_fornecedor = f.id_fornecedor " +
                                                           "WHERE p.produto = @produto", connection))
                    {
                        cmd.Parameters.AddWithValue("@produto", string.IsNullOrEmpty(produtoTB.Text) ? (object)DBNull.Value : (object)produtoTB.Text);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();

                                idTB.Text = reader["id_produto"].ToString();
                                produtoTB.Text = reader["produto"].ToString();

                                valorTB.Text = reader["valor"].ToString();

                                quantidadeTB.Text = reader["quantidade"].ToString();
                                categoriaCB.Text = reader["categoria"].ToString();
                                fornecedorCB.Text = reader["fornecedor"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Produto não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar Produto: " + ex.Message);
            }
        }


        // BOTÃO LIMPAR
        private void limparBT_Click_1(object sender, EventArgs e)
        {
            idTB.Text = string.Empty;
            produtoTB.Text = string.Empty;
            categoriaCB.Text = string.Empty;
            valorTB.Text = string.Empty;
            quantidadeTB.Text = string.Empty;
            fornecedorCB.Text = string.Empty;
            categoriaCB.SelectedIndex = -1;
            fornecedorCB.SelectedIndex = -1;
        }


        // BOTÃO EXCLUIR
         private void excluirBT_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(produtoTB.Text) ||
                    string.IsNullOrWhiteSpace(categoriaCB.Text) ||
                    string.IsNullOrWhiteSpace(valorTB.Text) ||
                    string.IsNullOrWhiteSpace(quantidadeTB.Text) ||
                    string.IsNullOrWhiteSpace(fornecedorCB.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir o Produto?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    string connectionString = @"Data Source=LAPTOP-BRUNO\SQLEXPRESS;Initial Catalog=ELETROLIGHT;Integrated Security=True";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Pedido WHERE id_produto = (SELECT id_produto FROM Produto WHERE id_produto = @id_produto)", connection))
                        {
                            checkCmd.Parameters.AddWithValue("@id_produto", idTB.Text);
                            int pedidoCount = (int)checkCmd.ExecuteScalar();

                            if (pedidoCount > 0)
                            {
                                MessageBox.Show("O produto selecionado está vinculado a um pedido e não pode ser excluído.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        using (SqlCommand cmd = new SqlCommand("ExcluirProduto", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_produto", idTB.Text);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Produto excluído com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            idTB.Text = "";
                            produtoTB.Text = "";
                            categoriaCB.Text = "";
                            valorTB.Text = "";
                            quantidadeTB.Text = "";
                            fornecedorCB.Text = "";
                            categoriaCB.SelectedIndex = -1;
                            fornecedorCB.SelectedIndex = -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir produto: " + ex.Message);
            }
         }


        // BOTÃO ATUALIZAR
        private void atualizarBT_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(produtoTB.Text) ||
                    string.IsNullOrWhiteSpace(categoriaCB.Text) ||
                    string.IsNullOrWhiteSpace(valorTB.Text) ||
                    string.IsNullOrWhiteSpace(quantidadeTB.Text) ||
                    string.IsNullOrWhiteSpace(fornecedorCB.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int quantidade;
                if (!int.TryParse(quantidadeTB.Text, out quantidade) || quantidade <= 0)
                {
                    MessageBox.Show("A quantidade deve ser um número inteiro maior que zero.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    quantidadeTB.Text = string.Empty;
                    return;
                }

                DialogResult resultado = MessageBox.Show("Tem certeza que deseja atualizar os dados do Produto?", "Confirmação de Atualização", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    string produto = produtoTB.Text;
                    string categoria = categoriaCB.Text;
                    string valor = valorTB.Text;

                    valor = valor.Replace(",", ".");
                    decimal valorDecimal = decimal.Parse(valor, CultureInfo.InvariantCulture);

                    string fornecedor = fornecedorCB.Text;

                    string connectionString = @"Data Source=LAPTOP-BRUNO\SQLEXPRESS;Initial Catalog=ELETROLIGHT;Integrated Security=True";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand cmdObterIdProduto = new SqlCommand("SELECT id_produto FROM Produto WHERE produto = @produto", connection))
                        {
                            cmdObterIdProduto.Parameters.AddWithValue("@produto", produto);

                            object result = cmdObterIdProduto.ExecuteScalar();

                            if (result != null && result != DBNull.Value)
                            {
                                int idProduto = Convert.ToInt32(result);

                                using (SqlCommand cmdAtualizarProduto = new SqlCommand("AtualizarProduto", connection))
                                {
                                    cmdAtualizarProduto.CommandType = CommandType.StoredProcedure;

                                    cmdAtualizarProduto.Parameters.AddWithValue("@id_produto", idProduto);
                                    cmdAtualizarProduto.Parameters.AddWithValue("@produto", produto);
                                    cmdAtualizarProduto.Parameters.AddWithValue("@categoria", categoria);
                                    cmdAtualizarProduto.Parameters.AddWithValue("@valor", valorDecimal);
                                    cmdAtualizarProduto.Parameters.AddWithValue("@quantidade", quantidade);
                                    cmdAtualizarProduto.Parameters.AddWithValue("@fornecedor", fornecedor);

                                    cmdAtualizarProduto.ExecuteNonQuery();

                                    MessageBox.Show("Produto atualizado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    string valorFormatado = (valorDecimal).ToString("N2");
                                    valorTB.Text = valorFormatado;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Produto não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar Produto: " + ex.Message);
            }
        }
    }
}
