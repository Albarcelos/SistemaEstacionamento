namespace ControleEstacionamento
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaDeValoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.toolstripTextoStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.btnSaida = new System.Windows.Forms.Button();
            this.lblDataHoraAtual = new System.Windows.Forms.Label();
            this.lblPlacaVeiculo = new System.Windows.Forms.Label();
            this.txtPlacaVeiculo = new System.Windows.Forms.TextBox();
            this.dgvVeiculos = new System.Windows.Forms.DataGridView();
            this.btnCancelarEntrada = new System.Windows.Forms.Button();
            this.btnConfirmarEntrada = new System.Windows.Forms.Button();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.timerDatHoraAtual = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.idveiculosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadiaCobradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetVeiculos = new ControleEstacionamento.estacionamentoDataSet2();
            this.veiculosTableAdapter = new ControleEstacionamento.estacionamentoDataSet2TableAdapters.veiculosTableAdapter();
            this.menu.SuspendLayout();
            this.status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetVeiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 24);
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
            this.tabelaDeValoresToolStripMenuItem.Name = "tabelaDeValoresToolStripMenuItem";
            this.tabelaDeValoresToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.tabelaDeValoresToolStripMenuItem.Text = "Tabela de Valores";
            this.tabelaDeValoresToolStripMenuItem.Click += new System.EventHandler(this.tabelaDeValoresToolStripMenuItem_Click_1);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripTextoStatus});
            this.status.Location = new System.Drawing.Point(0, 428);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(800, 22);
            this.status.TabIndex = 2;
            this.status.Text = "statusStrip1";
            // 
            // toolstripTextoStatus
            // 
            this.toolstripTextoStatus.Name = "toolstripTextoStatus";
            this.toolstripTextoStatus.Size = new System.Drawing.Size(0, 17);
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
            this.btnEntrada.Location = new System.Drawing.Point(552, 101);
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
            this.btnSaida.Location = new System.Drawing.Point(673, 101);
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
            this.lblDataHoraAtual.Location = new System.Drawing.Point(508, 36);
            this.lblDataHoraAtual.Name = "lblDataHoraAtual";
            this.lblDataHoraAtual.Size = new System.Drawing.Size(280, 13);
            this.lblDataHoraAtual.TabIndex = 8;
            this.lblDataHoraAtual.Text = "segunda-feira, 10 de junho de 2020 12:12:12";
            this.lblDataHoraAtual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPlacaVeiculo
            // 
            this.lblPlacaVeiculo.AutoSize = true;
            this.lblPlacaVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacaVeiculo.Location = new System.Drawing.Point(549, 74);
            this.lblPlacaVeiculo.Name = "lblPlacaVeiculo";
            this.lblPlacaVeiculo.Size = new System.Drawing.Size(93, 13);
            this.lblPlacaVeiculo.TabIndex = 9;
            this.lblPlacaVeiculo.Text = "Placa Veiculo :";
            this.lblPlacaVeiculo.Visible = false;
            // 
            // txtPlacaVeiculo
            // 
            this.txtPlacaVeiculo.Location = new System.Drawing.Point(648, 71);
            this.txtPlacaVeiculo.MaxLength = 7;
            this.txtPlacaVeiculo.Name = "txtPlacaVeiculo";
            this.txtPlacaVeiculo.Size = new System.Drawing.Size(74, 20);
            this.txtPlacaVeiculo.TabIndex = 10;
            this.txtPlacaVeiculo.Visible = false;
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
            this.idveiculosDataGridViewTextBoxColumn,
            this.placaDataGridViewTextBoxColumn,
            this.entradaDataGridViewTextBoxColumn,
            this.saidaDataGridViewTextBoxColumn,
            this.estadiaDataGridViewTextBoxColumn,
            this.estadiaCobradaDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn});
            this.dgvVeiculos.DataSource = this.veiculosBindingSource;
            this.dgvVeiculos.Location = new System.Drawing.Point(12, 130);
            this.dgvVeiculos.Name = "dgvVeiculos";
            this.dgvVeiculos.ReadOnly = true;
            this.dgvVeiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVeiculos.Size = new System.Drawing.Size(776, 295);
            this.dgvVeiculos.TabIndex = 12;
            this.dgvVeiculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVeiculos_CellClick);
            // 
            // btnCancelarEntrada
            // 
            this.btnCancelarEntrada.Image = global::ControleEstacionamento.Properties.Resources.cross_icone_5804_161;
            this.btnCancelarEntrada.Location = new System.Drawing.Point(728, 69);
            this.btnCancelarEntrada.Name = "btnCancelarEntrada";
            this.btnCancelarEntrada.Size = new System.Drawing.Size(28, 23);
            this.btnCancelarEntrada.TabIndex = 11;
            this.btnCancelarEntrada.UseVisualStyleBackColor = true;
            this.btnCancelarEntrada.Visible = false;
            this.btnCancelarEntrada.Click += new System.EventHandler(this.btnCancelarEntrada_Click);
            // 
            // btnConfirmarEntrada
            // 
            this.btnConfirmarEntrada.Image = global::ControleEstacionamento.Properties.Resources.tick_icone_7522_161;
            this.btnConfirmarEntrada.Location = new System.Drawing.Point(760, 69);
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
            // timerDatHoraAtual
            // 
            this.timerDatHoraAtual.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // idveiculosDataGridViewTextBoxColumn
            // 
            this.idveiculosDataGridViewTextBoxColumn.DataPropertyName = "idveiculos";
            this.idveiculosDataGridViewTextBoxColumn.HeaderText = "idveiculos";
            this.idveiculosDataGridViewTextBoxColumn.Name = "idveiculosDataGridViewTextBoxColumn";
            this.idveiculosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placaDataGridViewTextBoxColumn
            // 
            this.placaDataGridViewTextBoxColumn.DataPropertyName = "placa";
            this.placaDataGridViewTextBoxColumn.HeaderText = "placa";
            this.placaDataGridViewTextBoxColumn.Name = "placaDataGridViewTextBoxColumn";
            this.placaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // entradaDataGridViewTextBoxColumn
            // 
            this.entradaDataGridViewTextBoxColumn.DataPropertyName = "entrada";
            this.entradaDataGridViewTextBoxColumn.HeaderText = "entrada";
            this.entradaDataGridViewTextBoxColumn.Name = "entradaDataGridViewTextBoxColumn";
            this.entradaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saidaDataGridViewTextBoxColumn
            // 
            this.saidaDataGridViewTextBoxColumn.DataPropertyName = "saida";
            this.saidaDataGridViewTextBoxColumn.HeaderText = "saida";
            this.saidaDataGridViewTextBoxColumn.Name = "saidaDataGridViewTextBoxColumn";
            this.saidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadiaDataGridViewTextBoxColumn
            // 
            this.estadiaDataGridViewTextBoxColumn.DataPropertyName = "estadia";
            this.estadiaDataGridViewTextBoxColumn.HeaderText = "estadia";
            this.estadiaDataGridViewTextBoxColumn.Name = "estadiaDataGridViewTextBoxColumn";
            this.estadiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadiaCobradaDataGridViewTextBoxColumn
            // 
            this.estadiaCobradaDataGridViewTextBoxColumn.DataPropertyName = "estadiaCobrada";
            this.estadiaCobradaDataGridViewTextBoxColumn.HeaderText = "estadiaCobrada";
            this.estadiaCobradaDataGridViewTextBoxColumn.Name = "estadiaCobradaDataGridViewTextBoxColumn";
            this.estadiaCobradaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // veiculosBindingSource
            // 
            this.veiculosBindingSource.DataMember = "veiculos";
            this.veiculosBindingSource.DataSource = this.DataSetVeiculos;
            // 
            // DataSetVeiculos
            // 
            this.DataSetVeiculos.DataSetName = "DataSetVeiculos";
            this.DataSetVeiculos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // veiculosTableAdapter
            // 
            this.veiculosTableAdapter.ClearBeforeFill = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
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
            this.Controls.Add(this.status);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "frmPrincipal";
            this.Text = "Estacionamento";
            this.Load += new System.EventHandler(this.frmInicial_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetVeiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.StatusStrip status;
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
        private System.Windows.Forms.ToolStripStatusLabel toolstripTextoStatus;
        private System.Windows.Forms.DataGridView dgvVeiculos;
        private System.Windows.Forms.Timer timerDatHoraAtual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVeiculosColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaVeiculoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEntradaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSaidaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempoEstadiaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadiaCobradaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorCobradoColumn;
        private estacionamentoDataSet2 DataSetVeiculos;
        private System.Windows.Forms.BindingSource veiculosBindingSource;
        private estacionamentoDataSet2TableAdapters.veiculosTableAdapter veiculosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idveiculosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadiaCobradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
    }
}

