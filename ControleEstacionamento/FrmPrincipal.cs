using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ControleEstacionamento
{
    public partial class frmPrincipal : Form
    {
        private MySqlConnection conexao = new MySqlConnection();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmInicial_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'estacionamentoDataSet2.veiculos'. Você pode movê-la ou removê-la conforme necessário.
            this.veiculosTableAdapter.Fill(this.DataSetVeiculos.veiculos);

            // Carregamento do sistema.
            timerDatHoraAtual.Enabled = true;

            DataBase.ConexaoBD();

            /*string strConn = @"server=localhost;user id=root;password=al3xandr3;database=estacionamento;SslMode=none";
            conexao = new MySqlConnection(strConn);
            try{
                // teste de conexao.
                conexao.Open();
                toolstripTextoStatus.Text = "Banco de Dados Conectado!";
                conexao.Close();

                //MySqlCommand comando = new MySqlCommand();
                //comando.Connection = conexao;
                //comando.Connection.Open(); // abre a conexao.
                //comando.CommandText = "select * from valores"; // query para efetivar a saida do veiculo.
                //comando.ExecuteNonQuery(); // executa a query.
                //comando.Connection.Close(); // fecha a conexao.
            }catch{
                MessageBox.Show("Não foi possível se conectar ao banco MySql!", "Erro de Conexão");
            }*/


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
            if (dgvVeiculos.CurrentRow.Index >= 0)
            {
                // retorna a linha selacionada no grid
                DataGridViewRow dgvLinhaSelected = dgvVeiculos.Rows[dgvVeiculos.CurrentRow.Index];
                int idVeiculoSelected = new int();
                idVeiculoSelected = (int)dgvLinhaSelected.Cells["idVeiculosDGVColumn"].Value;

                // pega o dado de acordo com o id da coluna desejada
                MessageBox.Show("Gostaria de confirmar a saída do veículo de placa = " + dgvLinhaSelected.Cells["placaVeiculoDGVColumn"].Value.ToString());
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
            // Abrir tela para alterar a tabela de valores e vigencias.
            MessageBox.Show("Tabela de Valores");
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

        private void tabelaDeValoresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // item do menu para abrir a tela de Valores/Vigencias
            FrmTabelaValores frmTabelaValores = new FrmTabelaValores();
            frmTabelaValores.ShowDialog();
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
                txtPlacaVeiculo.Text = dgvLinhaSelected.Cells["placaVeiculoDGVColumn"].Value.ToString();
            }
        }

        private void btnAtualizarLista_Click(object sender, EventArgs e)
        {
            // Atualizar o grid com os dados da tabela
            this.veiculosTableAdapter.Fill(this.DataSetVeiculos.veiculos);
        }
    }
}
