namespace ControleEstacionamento
{
    partial class FrmTabelaValores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolstripTabelaValores = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvValorVigencia = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAtualizarLista = new System.Windows.Forms.Button();
            this.timeVigenciaFinal = new System.Windows.Forms.DateTimePicker();
            this.timeVigenciaInicial = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.dateVigenciaFinal = new System.Windows.Forms.DateTimePicker();
            this.dateVigenciaInicial = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dBEstacionamentoDataSet1 = new ControleEstacionamento.DBEstacionamentoDataSet1();
            this.tValoresVigenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_Valores_VigenciaTableAdapter = new ControleEstacionamento.DBEstacionamentoDataSet1TableAdapters.T_Valores_VigenciaTableAdapter();
            this.tIdValoresDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tValorDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDataInicioVigenciaDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDataFimVigenciaDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tStatusValorVigenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValorVigencia)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBEstacionamentoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tValoresVigenciaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripTabelaValores});
            this.statusStrip1.Location = new System.Drawing.Point(0, 485);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(632, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolstripTabelaValores
            // 
            this.toolstripTabelaValores.Name = "toolstripTabelaValores";
            this.toolstripTabelaValores.Size = new System.Drawing.Size(150, 17);
            this.toolstripTabelaValores.Text = "Lista de Valores e Vigêngias";
            // 
            // dgvValorVigencia
            // 
            this.dgvValorVigencia.AllowUserToAddRows = false;
            this.dgvValorVigencia.AllowUserToDeleteRows = false;
            this.dgvValorVigencia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvValorVigencia.AutoGenerateColumns = false;
            this.dgvValorVigencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvValorVigencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvValorVigencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tIdValoresDGVColumn,
            this.tValorDGVColumn,
            this.tDataInicioVigenciaDGVColumn,
            this.tDataFimVigenciaDGVColumn,
            this.tStatusValorVigenciaDataGridViewTextBoxColumn});
            this.dgvValorVigencia.DataSource = this.tValoresVigenciaBindingSource;
            this.dgvValorVigencia.Location = new System.Drawing.Point(12, 187);
            this.dgvValorVigencia.Name = "dgvValorVigencia";
            this.dgvValorVigencia.ReadOnly = true;
            this.dgvValorVigencia.Size = new System.Drawing.Size(608, 285);
            this.dgvValorVigencia.TabIndex = 1;
            this.dgvValorVigencia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvValorVigencia_CellClick);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.Green;
            this.btnAdicionar.Location = new System.Drawing.Point(12, 40);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(176, 23);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnAlterar.Location = new System.Drawing.Point(239, 40);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(176, 23);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.ForeColor = System.Drawing.Color.DarkRed;
            this.btnRemover.Location = new System.Drawing.Point(470, 40);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(150, 23);
            this.btnRemover.TabIndex = 2;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::ControleEstacionamento.Properties.Resources.open_icone_5603_16;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnAtualizarLista);
            this.panel1.Controls.Add(this.timeVigenciaFinal);
            this.panel1.Controls.Add(this.timeVigenciaInicial);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnConfirmar);
            this.panel1.Controls.Add(this.dateVigenciaFinal);
            this.panel1.Controls.Add(this.dateVigenciaInicial);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblValor);
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Location = new System.Drawing.Point(12, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 112);
            this.panel1.TabIndex = 6;
            // 
            // btnAtualizarLista
            // 
            this.btnAtualizarLista.Image = global::ControleEstacionamento.Properties.Resources.refresh_table_icone_6973_16;
            this.btnAtualizarLista.Location = new System.Drawing.Point(3, 81);
            this.btnAtualizarLista.Name = "btnAtualizarLista";
            this.btnAtualizarLista.Size = new System.Drawing.Size(28, 23);
            this.btnAtualizarLista.TabIndex = 14;
            this.btnAtualizarLista.UseVisualStyleBackColor = true;
            this.btnAtualizarLista.Click += new System.EventHandler(this.btnAtualizarLista_Click);
            // 
            // timeVigenciaFinal
            // 
            this.timeVigenciaFinal.Enabled = false;
            this.timeVigenciaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeVigenciaFinal.Location = new System.Drawing.Point(319, 55);
            this.timeVigenciaFinal.Name = "timeVigenciaFinal";
            this.timeVigenciaFinal.ShowUpDown = true;
            this.timeVigenciaFinal.Size = new System.Drawing.Size(84, 20);
            this.timeVigenciaFinal.TabIndex = 12;
            // 
            // timeVigenciaInicial
            // 
            this.timeVigenciaInicial.Enabled = false;
            this.timeVigenciaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeVigenciaInicial.Location = new System.Drawing.Point(319, 29);
            this.timeVigenciaInicial.Name = "timeVigenciaInicial";
            this.timeVigenciaInicial.ShowUpDown = true;
            this.timeVigenciaInicial.Size = new System.Drawing.Size(84, 20);
            this.timeVigenciaInicial.TabIndex = 12;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCancelar.Image = global::ControleEstacionamento.Properties.Resources.cross_icone_5804_161;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(319, 81);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.Green;
            this.btnConfirmar.Image = global::ControleEstacionamento.Properties.Resources.tick_icone_7522_161;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(227, 81);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnConfirmar.Size = new System.Drawing.Size(86, 23);
            this.btnConfirmar.TabIndex = 11;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // dateVigenciaFinal
            // 
            this.dateVigenciaFinal.CustomFormat = "";
            this.dateVigenciaFinal.Enabled = false;
            this.dateVigenciaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateVigenciaFinal.Location = new System.Drawing.Point(227, 55);
            this.dateVigenciaFinal.Name = "dateVigenciaFinal";
            this.dateVigenciaFinal.Size = new System.Drawing.Size(86, 20);
            this.dateVigenciaFinal.TabIndex = 10;
            // 
            // dateVigenciaInicial
            // 
            this.dateVigenciaInicial.CustomFormat = "";
            this.dateVigenciaInicial.Enabled = false;
            this.dateVigenciaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateVigenciaInicial.Location = new System.Drawing.Point(227, 29);
            this.dateVigenciaInicial.Name = "dateVigenciaInicial";
            this.dateVigenciaInicial.Size = new System.Drawing.Size(86, 20);
            this.dateVigenciaInicial.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vigência Final :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Vigência Inicial :";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(133, 6);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(37, 13);
            this.lblValor.TabIndex = 9;
            this.lblValor.Text = "Valor :";
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(227, 3);
            this.txtValor.MaxLength = 6;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(86, 20);
            this.txtValor.TabIndex = 6;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // dBEstacionamentoDataSet1
            // 
            this.dBEstacionamentoDataSet1.DataSetName = "DBEstacionamentoDataSet1";
            this.dBEstacionamentoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tValoresVigenciaBindingSource
            // 
            this.tValoresVigenciaBindingSource.DataMember = "T_Valores_Vigencia";
            this.tValoresVigenciaBindingSource.DataSource = this.dBEstacionamentoDataSet1;
            // 
            // t_Valores_VigenciaTableAdapter
            // 
            this.t_Valores_VigenciaTableAdapter.ClearBeforeFill = true;
            // 
            // tIdValoresDGVColumn
            // 
            this.tIdValoresDGVColumn.DataPropertyName = "T_IdValores";
            this.tIdValoresDGVColumn.HeaderText = "T_IdValores";
            this.tIdValoresDGVColumn.Name = "tIdValoresDGVColumn";
            this.tIdValoresDGVColumn.ReadOnly = true;
            this.tIdValoresDGVColumn.Visible = false;
            // 
            // tValorDGVColumn
            // 
            this.tValorDGVColumn.DataPropertyName = "T_Valor";
            dataGridViewCellStyle1.Format = "C2";
            this.tValorDGVColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.tValorDGVColumn.HeaderText = "Valor";
            this.tValorDGVColumn.Name = "tValorDGVColumn";
            this.tValorDGVColumn.ReadOnly = true;
            // 
            // tDataInicioVigenciaDGVColumn
            // 
            this.tDataInicioVigenciaDGVColumn.DataPropertyName = "T_DataInicioVigencia";
            dataGridViewCellStyle2.Format = "G";
            this.tDataInicioVigenciaDGVColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.tDataInicioVigenciaDGVColumn.HeaderText = "Data de Inicio Vigência";
            this.tDataInicioVigenciaDGVColumn.Name = "tDataInicioVigenciaDGVColumn";
            this.tDataInicioVigenciaDGVColumn.ReadOnly = true;
            // 
            // tDataFimVigenciaDGVColumn
            // 
            this.tDataFimVigenciaDGVColumn.DataPropertyName = "T_DataFimVigencia";
            dataGridViewCellStyle3.Format = "G";
            this.tDataFimVigenciaDGVColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.tDataFimVigenciaDGVColumn.HeaderText = "Data de Fim Vigência";
            this.tDataFimVigenciaDGVColumn.Name = "tDataFimVigenciaDGVColumn";
            this.tDataFimVigenciaDGVColumn.ReadOnly = true;
            // 
            // tStatusValorVigenciaDataGridViewTextBoxColumn
            // 
            this.tStatusValorVigenciaDataGridViewTextBoxColumn.DataPropertyName = "T_StatusValorVigencia";
            this.tStatusValorVigenciaDataGridViewTextBoxColumn.HeaderText = "Status";
            this.tStatusValorVigenciaDataGridViewTextBoxColumn.Name = "tStatusValorVigenciaDataGridViewTextBoxColumn";
            this.tStatusValorVigenciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmTabelaValores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 507);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dgvValorVigencia);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmTabelaValores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTabelaValores";
            this.Load += new System.EventHandler(this.FrmTabelaValores_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValorVigencia)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBEstacionamentoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tValoresVigenciaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolstripTabelaValores;
        private System.Windows.Forms.DataGridView dgvValorVigencia;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.DateTimePicker dateVigenciaFinal;
        private System.Windows.Forms.DateTimePicker dateVigenciaInicial;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker timeVigenciaFinal;
        private System.Windows.Forms.DateTimePicker timeVigenciaInicial;
        private System.Windows.Forms.Button btnAtualizarLista;
        private System.Windows.Forms.ToolTip toolTip;
        private DBEstacionamentoDataSet1 dBEstacionamentoDataSet1;
        private System.Windows.Forms.BindingSource tValoresVigenciaBindingSource;
        private DBEstacionamentoDataSet1TableAdapters.T_Valores_VigenciaTableAdapter t_Valores_VigenciaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIdValoresDGVColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tValorDGVColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDataInicioVigenciaDGVColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDataFimVigenciaDGVColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tStatusValorVigenciaDataGridViewTextBoxColumn;
    }
}