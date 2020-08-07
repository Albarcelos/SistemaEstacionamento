using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstacionamento
{
    public partial class FrmTabelaValores : Form
    {
        public FrmTabelaValores()
        {
            InitializeComponent();
        }

        private void FrmTabelaValores_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'estacionamentoDataSet1.valores'. Você pode movê-la ou removê-la conforme necessário.
            this.valoresTableAdapter.Fill(this.DataSetValores.valores);

            // Dicas para os botões
            toolTip.SetToolTip(btnAtualizarLista, "Atualizar a lista de valores/vigências.");
            toolTip.SetToolTip(btnAdicionar, "Adicionar novo item de valores/vigências.");
            toolTip.SetToolTip(btnAlterar, "Alterar o item de valores/vigências selecionado.");
            toolTip.SetToolTip(btnRemover, "Remover o item de valores/vigências selecionado.");
            toolTip.SetToolTip(btnConfirmar, "Confirmar a adição ou alteração item de valores/vigências.");
            toolTip.SetToolTip(btnCancelar, "Cancelar a adição ou alteração item de valores/vigências.");

            toolTip.SetToolTip(txtValor, "Informe o valor que será cobrado por hora.");
            toolTip.SetToolTip(dateVigenciaInicial, "Informe a data de início da vigência do valor de cobrança.");
            toolTip.SetToolTip(timeVigenciaInicial, "Informe o horário da data de início da vigência do valor de cobrança.");
            toolTip.SetToolTip(dateVigenciaFinal, "Informe a data de término da vigência do valor de cobrança.");
            toolTip.SetToolTip(timeVigenciaFinal, "Informe o horário da data de término da vigência do valor de cobrança.");
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Adicionar Valor e Vigência.
            txtValor.Enabled = true;
            dateVigenciaInicial.Enabled = true;
            timeVigenciaInicial.Enabled = true;
            dateVigenciaFinal.Enabled = true;
            timeVigenciaFinal.Enabled = true;
            btnConfirmar.Enabled = true;
            btnCancelar.Enabled = true;

            txtValor.Text = "";
            dateVigenciaInicial.Value = DateTime.Now;
            timeVigenciaInicial.Value = DateTime.Now;
            dateVigenciaFinal.Value = DateTime.Now;
            timeVigenciaFinal.Value = DateTime.Now;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // Alterar Valor e Vigência.

            // se houve clique em alguma das celulas no datagridview
            if (dgvValorVigencia.CurrentRow.Index >= 0)
            {
                // Habilitar campos
                txtValor.Enabled = true;
                dateVigenciaInicial.Enabled = true;
                timeVigenciaInicial.Enabled = true;
                dateVigenciaFinal.Enabled = true;
                timeVigenciaFinal.Enabled = true;
                btnConfirmar.Enabled = true;
                btnCancelar.Enabled = true;

                // retorna a linha selacionada no grid
                DataGridViewRow dgvLinhaSelected = dgvValorVigencia.Rows[dgvValorVigencia.CurrentRow.Index];

                // pega o dado de acordo com o id da coluna desejada
                txtValor.Text = dgvLinhaSelected.Cells["valorDGVColumn"].Value.ToString();
                dateVigenciaInicial.Value = (DateTime)dgvLinhaSelected.Cells["vigenciaInicialDGVColumn"].Value;
                timeVigenciaInicial.Value = Convert.ToDateTime(dgvLinhaSelected.Cells["vigenciaInicialDGVColumn"].Value);
                dateVigenciaFinal.Value = (DateTime)dgvLinhaSelected.Cells["vigenciaFinalDGVColumn"].Value;
                timeVigenciaFinal.Value = Convert.ToDateTime((DateTime)dgvLinhaSelected.Cells["vigenciaFinalDGVColumn"].Value);
            }
            else
            {
                MessageBox.Show("Selecione o registro que deseja alterar.", "Atenção!");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            // Remover Valor e Vigência.
            // se houve clique em alguma das celulas no datagridview
            if (dgvValorVigencia.CurrentRow.Index >= 0)
            {
                // Desabilitar campos
                txtValor.Enabled = false;
                dateVigenciaInicial.Enabled = false;
                timeVigenciaInicial.Enabled = false;
                dateVigenciaFinal.Enabled = false;
                timeVigenciaFinal.Enabled = false;
                btnConfirmar.Enabled = false;
                btnCancelar.Enabled = false;

                // retorna a linha selacionada no grid
                DataGridViewRow dgvLinhaSelected = dgvValorVigencia.Rows[dgvValorVigencia.CurrentRow.Index];

                // pega o dado de acordo com o id da coluna desejada
                txtValor.Text = dgvLinhaSelected.Cells["valorDGVColumn"].Value.ToString();

                MessageBox.Show("registro que deseja remover = " + dgvLinhaSelected.Cells["idValoresDGVColumn"].Value.ToString(), "Atenção!");
            }
            else
            {
                MessageBox.Show("Selecione o registro que deseja remover.", "Atenção!");
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Fechar a tela
            Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validação para input de somente numeros com validação de somente uma ','
            if (e.KeyChar == ',' && txtValor.Text.Contains(","))
            {
                // Bloqueia mais de uma virgula ','
                e.Handled = true;
            }
            else if (e.KeyChar == ',' && txtValor.Text.Length == 0)
            {
                // Bloqueia que o primeiro caracter seja uma virgula ','
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                // Bloqueia caracteres que nao sejam numeros ou virgula
                e.Handled = true;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Confirmar inclusão/alteração de Valor

            // data no mysql deve ser gravada no formato 'YYYY-MM-DD hh:mm:ss' (usa)
            // decimal no mysql necessita a troca da ',' (brasil) por '.' (usa)
            /* To get the DateTime from both these controls use the following code
             * DateTime myDate = datePortionDateTimePicker.Value.Date + timePortionDateTimePicker.Value.TimeOfDay;
             */
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Cancelar inclusão/alteração de Valor
            txtValor.Enabled = false;
            dateVigenciaInicial.Enabled = false;
            timeVigenciaInicial.Enabled = false;
            dateVigenciaFinal.Enabled = false;
            timeVigenciaFinal.Enabled = false;
            btnConfirmar.Enabled = false;
            btnCancelar.Enabled = false;

            txtValor.Text = "";
            dateVigenciaInicial.Value = DateTime.Now;
            timeVigenciaInicial.Value = DateTime.Now;
            dateVigenciaFinal.Value = DateTime.Now;
            timeVigenciaFinal.Value = DateTime.Now;
        }

        private void dgvValorVigencia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // se houve clique em alguma das celulas no datagridview
            if (e.RowIndex >= 0)
            {
                // retorna a linha selacionada no grid
                DataGridViewRow dgvLinhaSelected = dgvValorVigencia.Rows[e.RowIndex];

                // pega o dado de acordo com o id da coluna desejada
                txtValor.Text = dgvLinhaSelected.Cells["valorDGVColumn"].Value.ToString();
                dateVigenciaInicial.Value = (DateTime)dgvLinhaSelected.Cells["vigenciaInicialDGVColumn"].Value;
                timeVigenciaInicial.Value = Convert.ToDateTime(dgvLinhaSelected.Cells["vigenciaInicialDGVColumn"].Value);
                dateVigenciaFinal.Value = (DateTime)dgvLinhaSelected.Cells["vigenciaFinalDGVColumn"].Value;
                timeVigenciaFinal.Value = Convert.ToDateTime((DateTime)dgvLinhaSelected.Cells["vigenciaFinalDGVColumn"].Value);
            }
        }

        private void btnAtualizarLista_Click(object sender, EventArgs e)
        {
            // Atualizar o grid com os dados da tabela
            this.valoresTableAdapter.Fill(this.DataSetValores.valores);
        }
    }
}
