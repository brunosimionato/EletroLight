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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        // BOTÃO ENTRAR
        private void entrarBT_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = usuarioTB.Text;
                string senha = senhaTB.Text;

                using (SqlConnection conexao = new SqlConnection("Data Source=LAPTOP-BRUNO\\SQLEXPRESS;Initial Catalog=ELETROLIGHT;Integrated Security=True"))
                {
                    conexao.Open();

                    string query = "SELECT COUNT(*) FROM Usuario WHERE usuario = @usuario AND senha = @senha";
                    SqlCommand comando = new SqlCommand(query, conexao);
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    comando.Parameters.AddWithValue("@senha", senha);

                    int resultado = (int)comando.ExecuteScalar();

                    if (resultado > 0)
                    {
                        // ABRE O FORMULÁRIO PRINCIPAL (HOME)
                        Home home = new Home();
                        home.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Credenciais inválidas. Tente novamente.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
