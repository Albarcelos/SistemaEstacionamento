﻿namespace ControleEstacionamento
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaDeValoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.btnSaida = new System.Windows.Forms.Button();
            this.lblDataHoraAtual = new System.Windows.Forms.Label();
            this.lblPlacaVeiculo = new System.Windows.Forms.Label();
            this.txtPlacaVeiculo = new System.Windows.Forms.TextBox();
            this.dgvVeiculos = new System.Windows.Forms.DataGridView();
            this.tIdVeiculoDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPlacaVeiculoDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDataEntradaDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDataSaidaDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tTempoEstadiaDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEstadiaCobradaDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tValorTotalDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tVeiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBEstacionamentoDataSet = new ControleEstacionamento.DBEstacionamentoDataSet();
            this.timerDatHoraAtual = new System.Windows.Forms.Timer(this.components);
            this.btnAtualizarLista = new System.Windows.Forms.Button();
            this.btnCancelarEntrada = new System.Windows.Forms.Button();
            this.btnConfirmarEntrada = new System.Windows.Forms.Button();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.t_VeiculosTableAdapter = new ControleEstacionamento.DBEstacionamentoDataSetTableAdapters.T_VeiculosTableAdapter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tVeiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBEstacionamentoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(884, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabelaDeValoresToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // tabelaDeValoresToolStripMenuItem
            // 
            this.tabelaDeValoresToolStripMenuItem.Image = global::ControleEstacionamento.Properties.Resources.edit_a_blank_page_icone_6944_16;
            this.tabelaDeValoresToolStripMenuItem.Name = "tabelaDeValoresToolStripMenuItem";
            this.tabelaDeValoresToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.tabelaDeValoresToolStripMenuItem.Text = "Tabela de Valores";
            this.tabelaDeValoresToolStripMenuItem.Click += new System.EventHandler(this.tabelaDeValoresToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::ControleEstacionamento.Properties.Resources.open_icone_5603_16;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitulo.Location = new System.Drawing.Point(93, 54);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(341, 39);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Carro Bem Guardado";
            // 
            // btnEntrada
            // 
            this.btnEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrada.ForeColor = System.Drawing.Color.Green;
            this.btnEntrada.Location = new System.Drawing.Point(636, 117);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(115, 23);
            this.btnEntrada.TabIndex = 6;
            this.btnEntrada.Text = "Marcar Entrada";
            this.btnEntrada.UseVisualStyleBackColor = true;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // btnSaida
            // 
            this.btnSaida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaida.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSaida.Location = new System.Drawing.Point(757, 117);
            this.btnSaida.Name = "btnSaida";
            this.btnSaida.Size = new System.Drawing.Size(115, 23);
            this.btnSaida.TabIndex = 7;
            this.btnSaida.Text = "Marcar Saída";
            this.btnSaida.UseVisualStyleBackColor = true;
            this.btnSaida.Click += new System.EventHandler(this.btnSaida_Click);
            // 
            // lblDataHoraAtual
            // 
            this.lblDataHoraAtual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataHoraAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataHoraAtual.Location = new System.Drawing.Point(592, 36);
            this.lblDataHoraAtual.Name = "lblDataHoraAtual";
            this.lblDataHoraAtual.Size = new System.Drawing.Size(280, 13);
            this.lblDataHoraAtual.TabIndex = 8;
            this.lblDataHoraAtual.Text = "segunda-feira, 10 de junho de 2020 12:12:12";
            this.lblDataHoraAtual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPlacaVeiculo
            // 
            this.lblPlacaVeiculo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlacaVeiculo.AutoSize = true;
            this.lblPlacaVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacaVeiculo.Location = new System.Drawing.Point(633, 90);
            this.lblPlacaVeiculo.Name = "lblPlacaVeiculo";
            this.lblPlacaVeiculo.Size = new System.Drawing.Size(93, 13);
            this.lblPlacaVeiculo.TabIndex = 9;
            this.lblPlacaVeiculo.Text = "Placa Veiculo :";
            // 
            // txtPlacaVeiculo
            // 
            this.txtPlacaVeiculo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlacaVeiculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlacaVeiculo.Enabled = false;
            this.txtPlacaVeiculo.Location = new System.Drawing.Point(732, 87);
            this.txtPlacaVeiculo.MaxLength = 7;
            this.txtPlacaVeiculo.Name = "txtPlacaVeiculo";
            this.txtPlacaVeiculo.Size = new System.Drawing.Size(74, 20);
            this.txtPlacaVeiculo.TabIndex = 10;
            this.txtPlacaVeiculo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlacaVeiculo_KeyPress);
            // 
            // dgvVeiculos
            // 
            this.dgvVeiculos.AllowUserToAddRows = false;
            this.dgvVeiculos.AllowUserToDeleteRows = false;
            this.dgvVeiculos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVeiculos.AutoGenerateColumns = false;
            this.dgvVeiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tIdVeiculoDGVColumn,
            this.tPlacaVeiculoDGVColumn,
            this.tDataEntradaDGVColumn,
            this.tDataSaidaDGVColumn,
            this.tTempoEstadiaDGVColumn,
            this.tEstadiaCobradaDGVColumn,
            this.tValorTotalDGVColumn});
            this.dgvVeiculos.DataSource = this.tVeiculosBindingSource;
            this.dgvVeiculos.Location = new System.Drawing.Point(12, 146);
            this.dgvVeiculos.Name = "dgvVeiculos";
            this.dgvVeiculos.ReadOnly = true;
            this.dgvVeiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVeiculos.Size = new System.Drawing.Size(860, 390);
            this.dgvVeiculos.TabIndex = 12;
            this.dgvVeiculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVeiculos_CellClick);
            // 
            // tIdVeiculoDGVColumn
            // 
            this.tIdVeiculoDGVColumn.DataPropertyName = "T_IdVeiculo";
            this.tIdVeiculoDGVColumn.HeaderText = "T_IdVeiculo";
            this.tIdVeiculoDGVColumn.Name = "tIdVeiculoDGVColumn";
            this.tIdVeiculoDGVColumn.ReadOnly = true;
            this.tIdVeiculoDGVColumn.Visible = false;
            // 
            // tPlacaVeiculoDGVColumn
            // 
            this.tPlacaVeiculoDGVColumn.DataPropertyName = "T_PlacaVeiculo";
            this.tPlacaVeiculoDGVColumn.HeaderText = "Placa Veículo";
            this.tPlacaVeiculoDGVColumn.Name = "tPlacaVeiculoDGVColumn";
            this.tPlacaVeiculoDGVColumn.ReadOnly = true;
            // 
            // tDataEntradaDGVColumn
            // 
            this.tDataEntradaDGVColumn.DataPropertyName = "T_DataEntrada";
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = null;
            this.tDataEntradaDGVColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.tDataEntradaDGVColumn.HeaderText = "Data de Entrada";
            this.tDataEntradaDGVColumn.Name = "tDataEntradaDGVColumn";
            this.tDataEntradaDGVColumn.ReadOnly = true;
            // 
            // tDataSaidaDGVColumn
            // 
            this.tDataSaidaDGVColumn.DataPropertyName = "T_DataSaida";
            dataGridViewCellStyle2.Format = "G";
            dataGridViewCellStyle2.NullValue = null;
            this.tDataSaidaDGVColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.tDataSaidaDGVColumn.HeaderText = "Data de Saída";
            this.tDataSaidaDGVColumn.Name = "tDataSaidaDGVColumn";
            this.tDataSaidaDGVColumn.ReadOnly = true;
            // 
            // tTempoEstadiaDGVColumn
            // 
            this.tTempoEstadiaDGVColumn.DataPropertyName = "T_TempoEstadia";
            dataGridViewCellStyle3.Format = "t";
            dataGridViewCellStyle3.NullValue = null;
            this.tTempoEstadiaDGVColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.tTempoEstadiaDGVColumn.HeaderText = "Tempo de Estadia";
            this.tTempoEstadiaDGVColumn.Name = "tTempoEstadiaDGVColumn";
            this.tTempoEstadiaDGVColumn.ReadOnly = true;
            // 
            // tEstadiaCobradaDGVColumn
            // 
            this.tEstadiaCobradaDGVColumn.DataPropertyName = "T_EstadiaCobrada";
            dataGridViewCellStyle4.Format = "t";
            this.tEstadiaCobradaDGVColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.tEstadiaCobradaDGVColumn.HeaderText = "Estadia Cobrada";
            this.tEstadiaCobradaDGVColumn.Name = "tEstadiaCobradaDGVColumn";
            this.tEstadiaCobradaDGVColumn.ReadOnly = true;
            // 
            // tValorTotalDGVColumn
            // 
            this.tValorTotalDGVColumn.DataPropertyName = "T_ValorTotal";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.tValorTotalDGVColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.tValorTotalDGVColumn.HeaderText = "Valor Total";
            this.tValorTotalDGVColumn.Name = "tValorTotalDGVColumn";
            this.tValorTotalDGVColumn.ReadOnly = true;
            // 
            // tVeiculosBindingSource
            // 
            this.tVeiculosBindingSource.DataMember = "T_Veiculos";
            this.tVeiculosBindingSource.DataSource = this.dBEstacionamentoDataSet;
            // 
            // dBEstacionamentoDataSet
            // 
            this.dBEstacionamentoDataSet.DataSetName = "DBEstacionamentoDataSet";
            this.dBEstacionamentoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timerDatHoraAtual
            // 
            this.timerDatHoraAtual.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAtualizarLista
            // 
            this.btnAtualizarLista.Image = global::ControleEstacionamento.Properties.Resources.refresh_table_icone_6973_16;
            this.btnAtualizarLista.Location = new System.Drawing.Point(12, 117);
            this.btnAtualizarLista.Name = "btnAtualizarLista";
            this.btnAtualizarLista.Size = new System.Drawing.Size(28, 23);
            this.btnAtualizarLista.TabIndex = 13;
            this.btnAtualizarLista.UseVisualStyleBackColor = true;
            this.btnAtualizarLista.Click += new System.EventHandler(this.btnAtualizarLista_Click);
            // 
            // btnCancelarEntrada
            // 
            this.btnCancelarEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarEntrada.Image = global::ControleEstacionamento.Properties.Resources.cross_icone_5804_161;
            this.btnCancelarEntrada.Location = new System.Drawing.Point(812, 85);
            this.btnCancelarEntrada.Name = "btnCancelarEntrada";
            this.btnCancelarEntrada.Size = new System.Drawing.Size(28, 23);
            this.btnCancelarEntrada.TabIndex = 11;
            this.btnCancelarEntrada.UseVisualStyleBackColor = true;
            this.btnCancelarEntrada.Visible = false;
            this.btnCancelarEntrada.Click += new System.EventHandler(this.btnCancelarEntrada_Click);
            // 
            // btnConfirmarEntrada
            // 
            this.btnConfirmarEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmarEntrada.Image = global::ControleEstacionamento.Properties.Resources.tick_icone_7522_161;
            this.btnConfirmarEntrada.Location = new System.Drawing.Point(844, 85);
            this.btnConfirmarEntrada.Name = "btnConfirmarEntrada";
            this.btnConfirmarEntrada.Size = new System.Drawing.Size(28, 23);
            this.btnConfirmarEntrada.TabIndex = 11;
            this.btnConfirmarEntrada.UseVisualStyleBackColor = true;
            this.btnConfirmarEntrada.Visible = false;
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::ControleEstacionamento.Properties.Resources.estacionamento_logo;
            this.imgLogo.Location = new System.Drawing.Point(12, 36);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(75, 75);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 3;
            this.imgLogo.TabStop = false;
            // 
            // t_VeiculosTableAdapter
            // 
            this.t_VeiculosTableAdapter.ClearBeforeFill = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(884, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel.Text = "...";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnAtualizarLista);
            this.Controls.Add(this.dgvVeiculos);
            this.Controls.Add(this.btnCancelarEntrada);
            this.Controls.Add(this.btnConfirmarEntrada);
            this.Controls.Add(this.txtPlacaVeiculo);
            this.Controls.Add(this.lblPlacaVeiculo);
            this.Controls.Add(this.lblDataHoraAtual);
            this.Controls.Add(this.btnSaida);
            this.Controls.Add(this.btnEntrada);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estacionamento";
            this.Load += new System.EventHandler(this.frmInicial_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tVeiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBEstacionamentoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button btnSaida;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label lblDataHoraAtual;
        private System.Windows.Forms.ToolStripMenuItem tabelaDeValoresToolStripMenuItem;
        private System.Windows.Forms.Label lblPlacaVeiculo;
        private System.Windows.Forms.TextBox txtPlacaVeiculo;
        private System.Windows.Forms.Button btnConfirmarEntrada;
        private System.Windows.Forms.Button btnCancelarEntrada;
        private System.Windows.Forms.DataGridView dgvVeiculos;
        private System.Windows.Forms.Timer timerDatHoraAtual;
        private System.Windows.Forms.Button btnAtualizarLista;
        private System.Windows.Forms.ToolTip toolTip;
        private DBEstacionamentoDataSet dBEstacionamentoDataSet;
        private System.Windows.Forms.BindingSource tVeiculosBindingSource;
        private DBEstacionamentoDataSetTableAdapters.T_VeiculosTableAdapter t_VeiculosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIdVeiculoDGVColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tPlacaVeiculoDGVColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDataEntradaDGVColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDataSaidaDGVColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tTempoEstadiaDGVColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tEstadiaCobradaDGVColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tValorTotalDGVColumn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}

