namespace ProjetoDA
{
    partial class ClientesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCnovo = new System.Windows.Forms.Button();
            this.listBoxCaquisicoes = new System.Windows.Forms.ListBox();
            this.fKClienteArrendamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projetoDADataSet = new ProjetoDA.ProjetoDADataSet();
            this.btnCguardar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxCarrendamentos = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxCcasas = new System.Windows.Forms.ListBox();
            this.fKClienteCasaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtboxCContacto = new System.Windows.Forms.TextBox();
            this.txtboxCmorada = new System.Windows.Forms.TextBox();
            this.txtboxCnif = new System.Windows.Forms.TextBox();
            this.txtboxCNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fKClienteVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKClienteCasaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.cboFiltrar = new System.Windows.Forms.ComboBox();
            this.btnCfiltrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteTableAdapter = new ProjetoDA.ProjetoDADataSetTableAdapters.ClienteTableAdapter();
            this.casaTableAdapter = new ProjetoDA.ProjetoDADataSetTableAdapters.CasaTableAdapter();
            this.vendaTableAdapter = new ProjetoDA.ProjetoDADataSetTableAdapters.VendaTableAdapter();
            this.arrendamentoSetTableAdapter = new ProjetoDA.ProjetoDADataSetTableAdapters.ArrendamentoSetTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKClienteArrendamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoDADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKClienteCasaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKClienteVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKClienteCasaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCnovo);
            this.groupBox1.Controls.Add(this.listBoxCaquisicoes);
            this.groupBox1.Controls.Add(this.btnCguardar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.listBoxCarrendamentos);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.listBoxCcasas);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtboxCContacto);
            this.groupBox1.Controls.Add(this.txtboxCmorada);
            this.groupBox1.Controls.Add(this.txtboxCnif);
            this.groupBox1.Controls.Add(this.txtboxCNome);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(463, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 493);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalhes";
            // 
            // btnCnovo
            // 
            this.btnCnovo.Location = new System.Drawing.Point(164, 145);
            this.btnCnovo.Name = "btnCnovo";
            this.btnCnovo.Size = new System.Drawing.Size(75, 23);
            this.btnCnovo.TabIndex = 3;
            this.btnCnovo.Text = "Novo";
            this.btnCnovo.UseVisualStyleBackColor = true;
            this.btnCnovo.Click += new System.EventHandler(this.btnCnovo_Click);
            // 
            // listBoxCaquisicoes
            // 
            this.listBoxCaquisicoes.DataSource = this.fKClienteArrendamentoBindingSource;
            this.listBoxCaquisicoes.FormattingEnabled = true;
            this.listBoxCaquisicoes.HorizontalScrollbar = true;
            this.listBoxCaquisicoes.Location = new System.Drawing.Point(12, 405);
            this.listBoxCaquisicoes.Name = "listBoxCaquisicoes";
            this.listBoxCaquisicoes.Size = new System.Drawing.Size(228, 82);
            this.listBoxCaquisicoes.TabIndex = 2;
            // 
            // fKClienteArrendamentoBindingSource
            // 
            this.fKClienteArrendamentoBindingSource.DataMember = "FK_ClienteArrendamento";
            this.fKClienteArrendamentoBindingSource.DataSource = this.clienteBindingSource1;
            // 
            // clienteBindingSource1
            // 
            this.clienteBindingSource1.DataMember = "Cliente";
            this.clienteBindingSource1.DataSource = this.projetoDADataSet;
            // 
            // projetoDADataSet
            // 
            this.projetoDADataSet.DataSetName = "ProjetoDADataSet";
            this.projetoDADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCguardar
            // 
            this.btnCguardar.Location = new System.Drawing.Point(83, 145);
            this.btnCguardar.Name = "btnCguardar";
            this.btnCguardar.Size = new System.Drawing.Size(75, 23);
            this.btnCguardar.TabIndex = 2;
            this.btnCguardar.Text = "Guardar";
            this.btnCguardar.UseVisualStyleBackColor = true;
            this.btnCguardar.Click += new System.EventHandler(this.btnCguardar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Aquisições:";
            // 
            // listBoxCarrendamentos
            // 
            this.listBoxCarrendamentos.DataSource = this.fKClienteArrendamentoBindingSource;
            this.listBoxCarrendamentos.FormattingEnabled = true;
            this.listBoxCarrendamentos.HorizontalScrollbar = true;
            this.listBoxCarrendamentos.Location = new System.Drawing.Point(13, 304);
            this.listBoxCarrendamentos.Name = "listBoxCarrendamentos";
            this.listBoxCarrendamentos.Size = new System.Drawing.Size(227, 82);
            this.listBoxCarrendamentos.TabIndex = 3;
            this.listBoxCarrendamentos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxCarrendamentos_MouseDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Arrendamentos:";
            // 
            // listBoxCcasas
            // 
            this.listBoxCcasas.DataSource = this.fKClienteCasaBindingSource1;
            this.listBoxCcasas.FormattingEnabled = true;
            this.listBoxCcasas.HorizontalScrollbar = true;
            this.listBoxCcasas.Location = new System.Drawing.Point(12, 203);
            this.listBoxCcasas.Name = "listBoxCcasas";
            this.listBoxCcasas.Size = new System.Drawing.Size(228, 82);
            this.listBoxCcasas.TabIndex = 2;
            this.listBoxCcasas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxCcasas_MouseDoubleClick);
            // 
            // fKClienteCasaBindingSource1
            // 
            this.fKClienteCasaBindingSource1.DataMember = "FK_ClienteCasa";
            this.fKClienteCasaBindingSource1.DataSource = this.clienteBindingSource1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Casas:";
            // 
            // txtboxCContacto
            // 
            this.txtboxCContacto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource1, "Contacto", true));
            this.txtboxCContacto.Location = new System.Drawing.Point(92, 107);
            this.txtboxCContacto.Name = "txtboxCContacto";
            this.txtboxCContacto.Size = new System.Drawing.Size(148, 20);
            this.txtboxCContacto.TabIndex = 7;
            // 
            // txtboxCmorada
            // 
            this.txtboxCmorada.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource1, "Morada", true));
            this.txtboxCmorada.Location = new System.Drawing.Point(92, 80);
            this.txtboxCmorada.Name = "txtboxCmorada";
            this.txtboxCmorada.Size = new System.Drawing.Size(148, 20);
            this.txtboxCmorada.TabIndex = 6;
            // 
            // txtboxCnif
            // 
            this.txtboxCnif.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource1, "Nif", true));
            this.txtboxCnif.Location = new System.Drawing.Point(92, 53);
            this.txtboxCnif.Name = "txtboxCnif";
            this.txtboxCnif.Size = new System.Drawing.Size(148, 20);
            this.txtboxCnif.TabIndex = 5;
            // 
            // txtboxCNome
            // 
            this.txtboxCNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource1, "Nome", true));
            this.txtboxCNome.Location = new System.Drawing.Point(92, 26);
            this.txtboxCNome.Name = "txtboxCNome";
            this.txtboxCNome.Size = new System.Drawing.Size(148, 20);
            this.txtboxCNome.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contacto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Morada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NIF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // fKClienteVendaBindingSource
            // 
            this.fKClienteVendaBindingSource.DataMember = "FK_ClienteVenda";
            this.fKClienteVendaBindingSource.DataSource = this.clienteBindingSource1;
            // 
            // fKClienteCasaBindingSource
            // 
            this.fKClienteCasaBindingSource.DataMember = "FK_ClienteCasa";
            this.fKClienteCasaBindingSource.DataSource = this.clienteBindingSource1;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.projetoDADataSet;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(628, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(12, 12);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(313, 20);
            this.txtFiltro.TabIndex = 2;
            // 
            // cboFiltrar
            // 
            this.cboFiltrar.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clienteBindingSource1, "Nome", true));
            this.cboFiltrar.FormattingEnabled = true;
            this.cboFiltrar.Items.AddRange(new object[] {
            "Nome",
            "NIF",
            "Contacto"});
            this.cboFiltrar.Location = new System.Drawing.Point(13, 39);
            this.cboFiltrar.Name = "cboFiltrar";
            this.cboFiltrar.Size = new System.Drawing.Size(121, 21);
            this.cboFiltrar.TabIndex = 3;
            // 
            // btnCfiltrar
            // 
            this.btnCfiltrar.Location = new System.Drawing.Point(140, 39);
            this.btnCfiltrar.Name = "btnCfiltrar";
            this.btnCfiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnCfiltrar.TabIndex = 4;
            this.btnCfiltrar.Text = "Filtrar";
            this.btnCfiltrar.UseVisualStyleBackColor = true;
            this.btnCfiltrar.Click += new System.EventHandler(this.btnCfiltrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.nifDataGridViewTextBoxColumn,
            this.moradaDataGridViewTextBoxColumn,
            this.contactoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clienteBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(13, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 469);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // nifDataGridViewTextBoxColumn
            // 
            this.nifDataGridViewTextBoxColumn.DataPropertyName = "Nif";
            this.nifDataGridViewTextBoxColumn.HeaderText = "Nif";
            this.nifDataGridViewTextBoxColumn.Name = "nifDataGridViewTextBoxColumn";
            // 
            // moradaDataGridViewTextBoxColumn
            // 
            this.moradaDataGridViewTextBoxColumn.DataPropertyName = "Morada";
            this.moradaDataGridViewTextBoxColumn.HeaderText = "Morada";
            this.moradaDataGridViewTextBoxColumn.Name = "moradaDataGridViewTextBoxColumn";
            // 
            // contactoDataGridViewTextBoxColumn
            // 
            this.contactoDataGridViewTextBoxColumn.DataPropertyName = "Contacto";
            this.contactoDataGridViewTextBoxColumn.HeaderText = "Contacto";
            this.contactoDataGridViewTextBoxColumn.Name = "contactoDataGridViewTextBoxColumn";
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // casaTableAdapter
            // 
            this.casaTableAdapter.ClearBeforeFill = true;
            // 
            // vendaTableAdapter
            // 
            this.vendaTableAdapter.ClearBeforeFill = true;
            // 
            // arrendamentoSetTableAdapter
            // 
            this.arrendamentoSetTableAdapter.ClearBeforeFill = true;
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 575);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCfiltrar);
            this.Controls.Add(this.cboFiltrar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ClientesForm";
            this.Text = "ClientesForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKClienteArrendamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoDADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKClienteCasaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKClienteVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKClienteCasaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtboxCContacto;
        private System.Windows.Forms.TextBox txtboxCmorada;
        private System.Windows.Forms.TextBox txtboxCnif;
        private System.Windows.Forms.TextBox txtboxCNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCnovo;
        private System.Windows.Forms.Button btnCguardar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ComboBox cboFiltrar;
        private System.Windows.Forms.Button btnCfiltrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjetoDADataSet projetoDADataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private ProjetoDADataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fKClienteCasaBindingSource;
        private ProjetoDADataSetTableAdapters.CasaTableAdapter casaTableAdapter;
        private System.Windows.Forms.BindingSource fKClienteVendaBindingSource;
        private ProjetoDADataSetTableAdapters.VendaTableAdapter vendaTableAdapter;
        private System.Windows.Forms.BindingSource fKClienteArrendamentoBindingSource;
        private ProjetoDADataSetTableAdapters.ArrendamentoSetTableAdapter arrendamentoSetTableAdapter;
        private System.Windows.Forms.BindingSource fKClienteCasaBindingSource1;
        private System.Windows.Forms.ListBox listBoxCaquisicoes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBoxCarrendamentos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxCcasas;
        private System.Windows.Forms.Label label5;
    }
}