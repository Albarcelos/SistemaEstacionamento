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
using MySql.Data;

namespace ControleEstacionamento
{
    public partial class frmPrincipal : Form
    {
        public static string SqlClientString = @"Data Source=PC-ALEXANDRE\SQLEXPRESS;Initial Catalog=DBEstacionamento;Integrated Security=True;SslMode=none";
        private SqlConnection conexao = new SqlConnection();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        public static void ConexaoBD()
        {
            SqlConnection conn = new SqlConnection(SqlClientString);
            try
            {
                if (conn.State.Equals(ConnectionState.Closed))
                {
                    conn.Open();
                }
            }
            catch (SqlException erro)
            {
                MessageBox.Show("Não foi possível conectar com o banco de dados : " + erro.Message, "Erro de Conexão", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            finally
            {
                conn.Dispose();
            }
        }

        private void frmInicial_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dBEstacionamentoDataSet.T_Veiculos'. Você pode movê-la ou removê-la conforme necessário.
            this.t_VeiculosTableAdapter.Fill(this.dBEstacionamentoDataSet.T_Veiculos);

            // Carregamento do sistema.
            timerDatHoraAtual.Enabled = true;

            //DataBase.ConexaoBD();

            


            // Dicas para os botões
            toolTip.SetToolTip(btnAtualizarLista, "Atualizar a lista de valores/vigências.");
            toolTip.SetToolTip(btnEntrada, "Entrada de veículo do sistema.");
            toolTip.SetToolTip(btnSaida, "Saída de veículo do sistema.");
            toolTip.SetToolTip(btnConfirmarEntrada, "Confirmar o processo de entrada do veículo.");
            toolTip.SetToolTip(btnCancelarEntrada, "Cancelar o precesso de entrada de veículo.");
            toolTip.SetToolTip(txtPlacaVeiculo, "Informe a placa do veículo para entrada.");
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            // Mostrar os itens de Entrada de Veiculo da tela.
            txtPlacaVeiculo.Enabled = true;
            txtPlacaVeiculo.Text = "";
            btnConfirmarEntrada.Visible = true;
            btnCancelarEntrada.Visible = true;
        }

        private void btnCancelarEntrada_Click(object sender, EventArgs e)
        {
            // Esconder os itens de Entrada de Veiculo da tela.
            txtPlacaVeiculo.Enabled = false;
            btnConfirmarEntrada.Visible = false;
            btnCancelarEntrada.Visible = false;
        }

        private void btnConfirmarEntrada_Click(object sender, EventArgs e)
        {
            // Efetivar a entrada do veiculo.
            /*
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexao;
            comando.Connection.Open(); // abre a conexao.
            comando.CommandText = ""; // query para efetivar a saida do veiculo.
            comando.ExecuteNonQuery(); // executa a query.
            comando.Connection.Close(); // fecha a conexao.
            */

            MessageBox.Show("Entrada efetuada com sucesso!");

            lblPlacaVeiculo.Visible = false;
            txtPlacaVeiculo.Visible = false;
            btnConfirmarEntrada.Visible = false;
            btnCancelarEntrada.Visible = false;
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            // Efetivar a baixa saida do veiculo e calculo permanencia no local e de valores a pagar.

            // se houve clique em alguma das celulas no datagridview
            if (dgvVeiculos.CurrentRow != null && dgvVeiculos.CurrentRow.Index >= 0)
            {
                // retorna a linha selacionada no grid
                DataGridViewRow dgvLinhaSelected = dgvVeiculos.Rows[dgvVeiculos.CurrentRow.Index];
                int idVeiculoSelected = new int();
                idVeiculoSelected = (int)dgvLinhaSelected.Cells["tIdVeiculoDGVColumn"].Value;

                // pega o dado de acordo com o id da coluna desejada
                MessageBox.Show("Gostaria de confirmar a saída do veículo de placa = " + dgvLinhaSelected.Cells["tPlacaVeiculoDGVColumn"].Value.ToString());
            }
            else
            {
                MessageBox.Show("Selecione o veículo que deseja efetuar a sáida.", "Atenção!");
            }

            /*
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexao;
            comando.Connection.Open(); // abre a conexao.
            comando.CommandText = ""; // query para efetivar a saida do veiculo.
            comando.ExecuteNonQuery(); // executa a query.
            comando.Connection.Close(); // fecha a conexao.
            */
        }

        private void tabelaDeValoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // item do menu para abrir a tela de Valores/Vigencias
            FrmTabelaValores frmTabelaValores = new FrmTabelaValores();
            frmTabelaValores.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Fechar o sistema via o menu Sair.
            Close();
        }

        private void txtPlacaVeiculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir somente Letras e Numeros no campo de placa do veiculo.
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // timer para mostrar a data e hora atual
            lblDataHoraAtual.Text = DateTime.Now.ToString("ddddd, dd MMMM yyyy HH:mm:ss");
        }

        private void dgvVeiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // se houve clique em alguma das celulas no datagridview
            if (e.RowIndex >= 0)
            {
                // retorna a linha selacionada no grid
                DataGridViewRow dgvLinhaSelected = dgvVeiculos.Rows[e.RowIndex];

                // pega o dado de acordo com o id da coluna desejada
                txtPlacaVeiculo.Text = dgvLinhaSelected.Cells["tPlacaVeiculoDGVColumn"].Value.ToString();
            }
        }

        private void btnAtualizarLista_Click(object sender, EventArgs e)
        {
            // Atualizar o grid com os dados da tabela
            this.t_VeiculosTableAdapter.Fill(this.dBEstacionamentoDataSet.T_Veiculos);

            DataSet ds = new DataSet();

            SqlConnection conexao = null;

            try
            {
                conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                SqlCommand cmd = new SqlCommand("SP_CRUD_VALORES_VIGENCIA", conexao);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CA_OPERACAO", "S");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);

                dgvVeiculos.DataSource = ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Atenção!");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
