using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EletroLight
{
    public partial class Fornecedor : Form
    {
        public Fornecedor()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }


        // BOTÃO INCLUIR //
        private void incluirBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nomeTB.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(cnpjMTB.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(cepMTB.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(enderecoTB.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(cidadeTB.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(ufTB.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(emailTB.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(telefoneMTB.Text.Trim()))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string connectionString = @"Data Source=LAPTOP-BRUNO\SQLEXPRESS;Initial Catalog=ELETROLIGHT;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("IncluirFornecedor", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@nome", nomeTB.Text);
                        cmd.Parameters.AddWithValue("@cnpj", cnpjMTB.Text);
                        cmd.Parameters.AddWithValue("@cep", cepMTB.Text);
                        cmd.Parameters.AddWithValue("@endereco", enderecoTB.Text);
                        cmd.Parameters.AddWithValue("@cidade", cidadeTB.Text);
                        cmd.Parameters.AddWithValue("@uf", ufTB.Text);
                        cmd.Parameters.AddWithValue("@telefone", telefoneMTB.Text);
                        cmd.Parameters.AddWithValue("@email", emailTB.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Forncedor inserido com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        nomeTB.Text = "";
                        cnpjMTB.Text = "";
                        cepMTB.Text = "";
                        enderecoTB.Text = "";
                        cidadeTB.Text = "";
                        ufTB.Text = "";
                        telefoneMTB.Text = "";
                        emailTB.Text = "";

                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Violation of UNIQUE KEY constraint"))
                {
                    MessageBox.Show("Erro ao inserir fornecedor: Já existe um fornecedor com o mesmo CNPJ.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Erro ao inserir Fornecedor: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir Fornecedor: " + ex.Message);
            }
        }


        // BOTÃO CONSULTAR //
        private void consultarBT_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=LAPTOP-BRUNO\SQLEXPRESS;Initial Catalog=ELETROLIGHT;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("ConsultarFornecedor", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@nome", string.IsNullOrEmpty(nomeTB.Text) ? (object)DBNull.Value : nomeTB.Text);
                        cmd.Parameters.AddWithValue("@cnpj", string.IsNullOrEmpty(cnpjMTB.Text) ? (object)DBNull.Value : cnpjMTB.Text);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                idTB.Text = reader["id_fornecedor"].ToString();
                                nomeTB.Text = reader["nome"].ToString();
                                cnpjMTB.Text = reader["cnpj"].ToString();
                                cepMTB.Text = reader["cep"].ToString();
                                enderecoTB.Text = reader["endereco"].ToString();
                                cidadeTB.Text = reader["cidade"].ToString();
                                ufTB.Text = reader["uf"].ToString();
                                telefoneMTB.Text = reader["telefone"].ToString();
                                emailTB.Text = reader["email"].ToString();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Fornecedor não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar Fornecedor: " + ex.Message);
            }
        }


        // BOTÃO LIMPAR //
        private void limparBT_Click(object sender, EventArgs e)
        {
            idTB.Text = string.Empty;
            nomeTB.Text = string.Empty;
            cnpjMTB.Text = string.Empty;
            cepMTB.Text = string.Empty;
            enderecoTB.Text = string.Empty;
            cidadeTB.Text = string.Empty;
            ufTB.Text = string.Empty;
            telefoneMTB.Text = string.Empty;
            emailTB.Text = string.Empty;
        }


        // BOTÃO EXCLUIR //
        private void excluirBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nomeTB.Text) ||
                    string.IsNullOrWhiteSpace(cnpjMTB.Text) ||
                    string.IsNullOrWhiteSpace(cepMTB.Text) ||
                    string.IsNullOrWhiteSpace(enderecoTB.Text) ||
                    string.IsNullOrWhiteSpace(cidadeTB.Text) ||
                    string.IsNullOrWhiteSpace(ufTB.Text) ||
                    string.IsNullOrWhiteSpace(telefoneMTB.Text) ||
                    string.IsNullOrWhiteSpace(emailTB.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir o Fornecedor?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    string connectionString = @"Data Source=LAPTOP-BRUNO\SQLEXPRESS;Initial Catalog=ELETROLIGHT;Integrated Security=True";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Produto WHERE id_fornecedor = (SELECT id_fornecedor FROM Fornecedor WHERE id_fornecedor = @id_fornecedor)", connection))
                        {
                            checkCmd.Parameters.AddWithValue("@id_fornecedor", idTB.Text);
                            int pedidoCount = (int)checkCmd.ExecuteScalar();

                            if (pedidoCount > 0)
                            {
                                MessageBox.Show("O Fornecedor selecionado está vinculado a um produto e não pode ser excluído.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }

                        using (SqlCommand cmd = new SqlCommand("ExcluirFornecedor", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_fornecedor", idTB.Text);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Fornecedor excluído com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            idTB.Text = "";
                            nomeTB.Text = "";
                            cnpjMTB.Text = "";
                            cepMTB.Text = "";
                            enderecoTB.Text = "";
                            cidadeTB.Text = "";
                            ufTB.Text = "";
                            telefoneMTB.Text = "";
                            emailTB.Text = "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir Fornecedor: " + ex.Message);
            }
        }


        // BOTÃO ATUALIZAR //
        private void atualizarBT_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=LAPTOP-BRUNO\SQLEXPRESS;Initial Catalog=ELETROLIGHT;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("AtualizarFornecedor", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id_fornecedor", idTB.Text);
                        cmd.Parameters.AddWithValue("@nome", nomeTB.Text);
                        cmd.Parameters.AddWithValue("@cnpj", cnpjMTB.Text);
                        cmd.Parameters.AddWithValue("@cep", cepMTB.Text);
                        cmd.Parameters.AddWithValue("@endereco", enderecoTB.Text);
                        cmd.Parameters.AddWithValue("@cidade", cidadeTB.Text);
                        cmd.Parameters.AddWithValue("@uf", ufTB.Text);
                        cmd.Parameters.AddWithValue("@telefone", telefoneMTB.Text);
                        cmd.Parameters.AddWithValue("@email", emailTB.Text);
                        cmd.ExecuteNonQuery();

                        DialogResult resultado = MessageBox.Show("Tem certeza que deseja atualizar os dados do Fornecedor?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        MessageBox.Show("Fornecedor atualizado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar Fornecedor: " + ex.Message);
            }
        }


        // Altera as letras minúsculas em maiúsculas na ufTB //
        private void ufTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }


        // Fecha o Formulário com ESC //
        private void Fornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
