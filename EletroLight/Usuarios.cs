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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }


        // Fecha o formulário com o ESC //
        private void Usuarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }


        private void Usuarios_Load(object sender, EventArgs e)
        {
            // CONFIGURAÇÃO DA DATA GRID //
            {
                SqlConnection conexao = new SqlConnection("Data Source=LAPTOP-BRUNO\\SQLEXPRESS;Initial Catalog=ELETROLIGHT;Integrated Security=True");
                conexao.Open();

                string queryAtualizacao = "SELECT * FROM Usuario";
                SqlCommand comandoAtualizacao = new SqlCommand(queryAtualizacao, conexao);
                SqlDataAdapter adaptadorAtualizacao = new SqlDataAdapter(comandoAtualizacao);
                DataSet dataSetAtualizado = new DataSet();
                adaptadorAtualizacao.Fill(dataSetAtualizado);

                usuarioDGV.DataSource = dataSetAtualizado.Tables[0];
                conexao.Close();

                usuarioDGV.Columns[0].HeaderText = "ID";
                usuarioDGV.Columns[1].HeaderText = "Usuário";
                usuarioDGV.Columns[2].HeaderText = "Senha";

                foreach (DataGridViewColumn coluna in usuarioDGV.Columns)
                {
                    coluna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                foreach (DataGridViewColumn coluna in usuarioDGV.Columns)
                {
                    coluna.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                usuarioDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                usuarioDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                foreach (DataGridViewColumn coluna in usuarioDGV.Columns)
                {
                    coluna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    coluna.HeaderCell.Style.WrapMode = DataGridViewTriState.True;
                    coluna.HeaderCell.Style.Font = new Font(usuarioDGV.Font, FontStyle.Bold);
                    coluna.HeaderCell.Style.Padding = new Padding(3, 3, 3, 3);
                }
            }
        }


        // FUNÇÃO PARA ATUALIZAR A DATA GRID VIEW APÓS INSERIR UM CLIENTE NOVO //
        private void AtualizarDataGridView()
        {
            using (SqlConnection conexao = new SqlConnection("Data Source=LAPTOP-BRUNO\\SQLEXPRESS;Initial Catalog=ELETROLIGHT;Integrated Security=True"))
            {
                conexao.Open();

                string queryAtualizacao = "SELECT * FROM Usuario";
                SqlCommand comandoAtualizacao = new SqlCommand(queryAtualizacao, conexao);
                SqlDataAdapter adaptadorAtualizacao = new SqlDataAdapter(comandoAtualizacao);
                DataSet dataSetAtualizado = new DataSet();
                adaptadorAtualizacao.Fill(dataSetAtualizado);

                usuarioDGV.DataSource = dataSetAtualizado.Tables[0];
            }
        }


        // Aceita apenas números no idTB //
        private void idTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        // BOTÃO INCLUIR //
        private void incluirBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(usuarioTB.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(senhaTB.Text.Trim()))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string connectionString = @"Data Source=LAPTOP-BRUNO\SQLEXPRESS;Initial Catalog=ELETROLIGHT;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("IncluirUsuario", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@usuario", string.IsNullOrEmpty(usuarioTB.Text) ? (object)DBNull.Value : usuarioTB.Text);
                        cmd.Parameters.AddWithValue("@senha", senhaTB.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("O campo ID é gerado automaticamente e não pode ser definido pelo usuário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show("Usuário inserido com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        usuarioTB.Text = "";
                        senhaTB.Text = "";
                        idTB.Text = "";

                        AtualizarDataGridView();
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Violation of UNIQUE KEY constraint"))
                {
                    MessageBox.Show("Erro ao inserir Usuário: Já existe um registro com mesmo nome de usuário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Erro ao inserir Usuário: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir Usuário: " + ex.Message);
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

                    if (string.IsNullOrEmpty(idTB.Text))
                    {
                        MessageBox.Show("Insira o ID do usuário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    using (SqlCommand cmd = new SqlCommand("ConsultarUsuario", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Se você deseja consultar apenas por ID, utilize o campo "idTB"
                        cmd.Parameters.AddWithValue("@id_usuario", string.IsNullOrEmpty(idTB.Text) ? (object)DBNull.Value : Convert.ToInt32(idTB.Text));

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            reader.Read(); // Lê a primeira linha

                            idTB.Text = reader["id_usuario"].ToString();
                            usuarioTB.Text = reader["usuario"].ToString();
                            senhaTB.Text = reader["senha"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Usuário não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar usuário: " + ex.Message);
            }
        }


        // BOTÃO LIMPAR //
        private void limparBT_Click(object sender, EventArgs e)
        {
            idTB.Text = string.Empty;
            usuarioTB.Text = string.Empty;
            senhaTB.Text = string.Empty;
        }


        // BOTÃO EXCLUIR //
        private void excluirBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(idTB.Text) ||
                    string.IsNullOrWhiteSpace(usuarioTB.Text) ||
                    string.IsNullOrWhiteSpace(senhaTB.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string connectionString = @"Data Source=LAPTOP-BRUNO\SQLEXPRESS;Initial Catalog=ELETROLIGHT;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Usuario", connection))
                    {
                        int userCount = (int)checkCmd.ExecuteScalar();

                        if (userCount == 1)
                        {
                            MessageBox.Show("Este é o único usuário cadastrado, portanto não pode ser excluído. Crie outro usuário antes de tentar excluí-lo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand("ExcluirUsuario", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_usuario", idTB.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Usuário excluído com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        idTB.Text = "";
                        usuarioTB.Text = "";
                        senhaTB.Text = "";

                        AtualizarDataGridView();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir Usuário: " + ex.Message);
            }
        }


        // BOTÃO ATUALIZAR //
        private void atualizarBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(usuarioTB.Text) ||
                    string.IsNullOrWhiteSpace(idTB.Text) ||
                    string.IsNullOrWhiteSpace(senhaTB.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult resultado = MessageBox.Show("Tem certeza que deseja atualizar os dados do Usuário?", "Confirmação de Atualização", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    string connectionString = @"Data Source=LAPTOP-BRUNO\SQLEXPRESS;Initial Catalog=ELETROLIGHT;Integrated Security=True";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand cmd = new SqlCommand("AtualizarUsuario", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            int usuarioID = int.Parse(idTB.Text);
                            cmd.Parameters.AddWithValue("@id_usuario", usuarioID); 
                            cmd.Parameters.AddWithValue("@usuario", usuarioTB.Text);
                            cmd.Parameters.AddWithValue("@senha", senhaTB.Text);


                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Usuário atualizado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            AtualizarDataGridView();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar Usuário: " + ex.Message);
            }
        }
    }
}
