using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;


namespace EletroLight
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }


        // PERMITE APENAS NÚMEROS NA TEXTBOX RG
        private void rgTB_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        // ALTERA AS LETRAS MINUSCÚLAS PARA MAIÚSCULAS NA TEXTBOX UF 
        private void ufTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }


        // FECHA O FORMULÁRIO COM ESC
        private void Cliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }


        // BOTÃO INCLUIR
        private void incluirBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nomeTB.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(cpfMTB.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(rgTB.Text.Trim()) ||
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
                    using (SqlCommand cmd = new SqlCommand("IncluirCliente", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@nome", nomeTB.Text);
                        cmd.Parameters.AddWithValue("@cpf", cpfMTB.Text);
                        cmd.Parameters.AddWithValue("@rg", rgTB.Text);
                        cmd.Parameters.AddWithValue("@cep", cepMTB.Text);
                        cmd.Parameters.AddWithValue("@endereco", enderecoTB.Text);
                        cmd.Parameters.AddWithValue("@cidade", cidadeTB.Text);
                        cmd.Parameters.AddWithValue("@uf", ufTB.Text);
                        cmd.Parameters.AddWithValue("@telefone", telefoneMTB.Text);
                        cmd.Parameters.AddWithValue("@email", emailTB.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Cliente inserido com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        nomeTB.Text = "";
                        cpfMTB.Text = "";
                        rgTB.Text = "";
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
                    MessageBox.Show("Erro ao inserir cliente: Já existe um cliente com o mesmo CPF ou RG.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Erro ao inserir Cliente: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir Cliente: " + ex.Message);
            }
        }


        // BOTÃO CONSULTAR
        private void consultarBT_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=LAPTOP-BRUNO\SQLEXPRESS;Initial Catalog=ELETROLIGHT;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("ConsultarCliente", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@nome", string.IsNullOrEmpty(nomeTB.Text) ? (object)DBNull.Value : nomeTB.Text);
                        cmd.Parameters.AddWithValue("@cpf", string.IsNullOrEmpty(cpfMTB.Text) ? (object)DBNull.Value : cpfMTB.Text);
                        cmd.Parameters.AddWithValue("@rg", string.IsNullOrEmpty(rgTB.Text) ? (object)DBNull.Value : rgTB.Text);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                idTB.Text = reader["id_cliente"].ToString();
                                nomeTB.Text = reader["nome"].ToString();
                                cpfMTB.Text = reader["cpf"].ToString();
                                rgTB.Text = reader["rg"].ToString();
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
                            MessageBox.Show("Cliente não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar Cliente: " + ex.Message);
            }
        }


        // BOTÃO LIMPAR
        private void limparBT_Click(object sender, EventArgs e)
        {
            idTB.Text = string.Empty;
            nomeTB.Text = string.Empty;
            cpfMTB.Text = string.Empty;
            rgTB.Text = string.Empty;
            cepMTB.Text = string.Empty;
            enderecoTB.Text = string.Empty;
            cidadeTB.Text = string.Empty;
            ufTB.Text = string.Empty;
            telefoneMTB.Text = string.Empty;
            emailTB.Text = string.Empty;
        }


        // BOTÃO EXCLUIR
        private void excluirBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nomeTB.Text) ||
                    string.IsNullOrWhiteSpace(cpfMTB.Text) ||
                    string.IsNullOrWhiteSpace(rgTB.Text) ||
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
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir o Cliente?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    string connectionString = @"Data Source=LAPTOP-BRUNO\SQLEXPRESS;Initial Catalog=ELETROLIGHT;Integrated Security=True";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Pedido WHERE id_cliente = (SELECT id_cliente FROM Cliente WHERE id_cliente = @id_cliente)", connection))
                        {
                            checkCmd.Parameters.AddWithValue("@id_cliente", idTB.Text);
                            int pedidoCount = (int)checkCmd.ExecuteScalar();

                            if (pedidoCount > 0)
                            {
                                MessageBox.Show("O cliente selecionado está vinculado a um pedido e não pode ser excluído.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        using (SqlCommand cmd = new SqlCommand("ExcluirCliente", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_cliente", idTB.Text);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Cliente excluído com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            idTB.Text = "";
                            nomeTB.Text = "";
                            cpfMTB.Text = "";
                            rgTB.Text = "";
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
                MessageBox.Show("Erro ao excluir Cliente: " + ex.Message);
            }
        }


        // BOTÃO ATUALIZAR
        private void atualizarBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nomeTB.Text) ||
                    string.IsNullOrWhiteSpace(cepMTB.Text) ||
                    string.IsNullOrWhiteSpace(rgTB.Text) ||
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

                DialogResult resultado = MessageBox.Show("Tem certeza que deseja atualizar os dados do Cliente?", "Confirmação de Atualização", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    string connectionString = @"Data Source=LAPTOP-BRUNO\SQLEXPRESS;Initial Catalog=ELETROLIGHT;Integrated Security=True";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand cmd = new SqlCommand("AtualizarCliente", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            int clienteID = int.Parse(idTB.Text);
                            cmd.Parameters.AddWithValue("@id_cliente", clienteID);
                            cmd.Parameters.AddWithValue("@nome", nomeTB.Text);
                            cmd.Parameters.AddWithValue("@cpf", cpfMTB.Text);
                            cmd.Parameters.AddWithValue("@rg", rgTB.Text);
                            cmd.Parameters.AddWithValue("@cep", cepMTB.Text);
                            cmd.Parameters.AddWithValue("@endereco", enderecoTB.Text);
                            cmd.Parameters.AddWithValue("@cidade", cidadeTB.Text);
                            cmd.Parameters.AddWithValue("@uf", ufTB.Text);
                            cmd.Parameters.AddWithValue("@telefone", telefoneMTB.Text);
                            cmd.Parameters.AddWithValue("@email", emailTB.Text);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Cliente atualizado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar Cliente: " + ex.Message);
            }
        }
    }
}

    

