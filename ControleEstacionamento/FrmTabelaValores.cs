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

            /*
             * To get the DateTime from both these controls use the following code
             * DateTime myDate = datePortionDateTimePicker.Value.Date + timePortionDateTimePicker.Value.TimeOfDay;
             * 
             * To assign the DateTime to both these controls use the following code
             * datePortionDateTimePicker.Value  = myDate.Date;
             * timePortionDateTimePicker.Value  = myDate.TimeOfDay;
             * 
             */
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
            txtValor.Enabled = true;
            dateVigenciaInicial.Enabled = true;
            timeVigenciaInicial.Enabled = true;
            dateVigenciaFinal.Enabled = true;
            timeVigenciaFinal.Enabled = true;
            btnConfirmar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            // Remover Valor e Vigência.
            txtValor.Enabled = false;
            dateVigenciaInicial.Enabled = false;
            timeVigenciaInicial.Enabled = false;
            dateVigenciaFinal.Enabled = false;
            timeVigenciaFinal.Enabled = false;
            btnConfirmar.Enabled = false;
            btnCancelar.Enabled = false;
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
    }
}
