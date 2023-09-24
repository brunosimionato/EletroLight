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
    public partial class Categoria : Form
    {
        public Categoria()
        {
            InitializeComponent();
        }


        // BOTÃO INCLUIR // 
        private void incluirBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(descricaoTB.Text.Trim()))
                {
                    MessageBox.Show("Por favor, preencha o campo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("O campo ID é gerado automaticamente e não pode ser definido pelo usuário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string descricao = descricaoTB.Text.Trim();
                string connectionString = @"Data Source=LAPTOP-BRUNO\SQLEXPRESS;Initial Catalog=ELETROLIGHT;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Categoria WHERE descricao = @descricao", connection))
                    {
                        checkCmd.Parameters.AddWithValue("@descricao", descricao);

                        int categoriaExistente = (int)checkCmd.ExecuteScalar();

                        if (categoriaExistente > 0)
                        {
                            MessageBox.Show("Esta categoria já existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand("IncluirCategoria", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@descricao", descricao);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Categoria inserida com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        idTB.Text = "";
                        descricaoTB.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir categoria: " + ex.Message);
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
                    using (SqlCommand cmd = new SqlCommand("ConsultarCategoria", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id_categoria", string.IsNullOrEmpty(idTB.Text) ? (object)DBNull.Value : idTB.Text);
                        cmd.Parameters.AddWithValue("@descricao", string.IsNullOrEmpty(descricaoTB.Text) ? (object)DBNull.Value : descricaoTB.Text);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                idTB.Text = reader["id_categoria"].ToString();
                                descricaoTB.Text = reader["descricao"].ToString();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Categoria não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar Categoria: " + ex.Message);
            }
        }


        // BOTÃO EXCLUIR //
        private void excluirBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(descricaoTB.Text) ||
                    string.IsNullOrWhiteSpace(idTB.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir a Categoria?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    string connectionString = @"Data Source=LAPTOP-BRUNO\SQLEXPRESS;Initial Catalog=ELETROLIGHT;Integrated Security=True";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Produto WHERE id_categoria = (SELECT id_categoria FROM Categoria WHERE id_categoria = @id_categoria)", connection))
                        {
                            checkCmd.Parameters.AddWithValue("@id_categoria", idTB.Text);
                            int pedidoCount = (int)checkCmd.ExecuteScalar();

                            if (pedidoCount > 0)
                            {
                                MessageBox.Show("A categoria selecionada está vinculado a um produto e não pode ser excluída.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }

                        using (SqlCommand cmd = new SqlCommand("ExcluirCategoria", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_categoria", idTB.Text);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Categoria excluída com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            idTB.Text = "";
                            descricaoTB.Text = "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir categoria: " + ex.Message);
            }
        }


        // BOTÃO LIMPAR //
        private void limparBT_Click(object sender, EventArgs e)
        {
            idTB.Text = string.Empty;
            descricaoTB.Text = string.Empty;
        }
    }
}
