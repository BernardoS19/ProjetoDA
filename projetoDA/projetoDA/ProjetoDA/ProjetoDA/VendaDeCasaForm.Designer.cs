namespace ProjetoDA
{
    partial class VendaDeCasaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendaDeCasaForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEfetivarVenda = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblProprietario = new System.Windows.Forms.Label();
            this.lblComissao = new System.Windows.Forms.Label();
            this.textBoxValorComissao = new System.Windows.Forms.TextBox();
            this.textBoxValorNegociado = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxComprador = new System.Windows.Forms.ComboBox();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetoDADataSet = new ProjetoDA.ProjetoDADataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.casaCasaVendavelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casa_CasaVendavelTableAdapter = new ProjetoDA.ProjetoDADataSetTableAdapters.Casa_CasaVendavelTableAdapter();
            this.casaCasaVendavelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vendaTableAdapter = new ProjetoDA.ProjetoDADataSetTableAdapters.VendaTableAdapter();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new ProjetoDA.ProjetoDADataSetTableAdapters.ClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoDADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaCasaVendavelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaCasaVendavelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(347, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Proprietário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Valor Base:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Comissão Base:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Data da venda:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Valor negociado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Valor da comissão:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Comprador:";
            // 
            // btnEfetivarVenda
            // 
            this.btnEfetivarVenda.Location = new System.Drawing.Point(12, 330);
            this.btnEfetivarVenda.Name = "btnEfetivarVenda";
            this.btnEfetivarVenda.Size = new System.Drawing.Size(433, 23);
            this.btnEfetivarVenda.TabIndex = 10;
            this.btnEfetivarVenda.Text = "Efetivar Venda";
            this.btnEfetivarVenda.UseVisualStyleBackColor = true;
            this.btnEfetivarVenda.Click += new System.EventHandler(this.btnEfetivarVenda_Click);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(76, 90);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(24, 13);
            this.lblValor.TabIndex = 11;
            this.lblValor.Text = "n/a";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(73, 41);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(27, 13);
            this.lblEstado.TabIndex = 12;
            this.lblEstado.Text = "N/A";
            // 
            // lblProprietario
            // 
            this.lblProprietario.AutoSize = true;
            this.lblProprietario.Location = new System.Drawing.Point(76, 65);
            this.lblProprietario.Name = "lblProprietario";
            this.lblProprietario.Size = new System.Drawing.Size(24, 13);
            this.lblProprietario.TabIndex = 13;
            this.lblProprietario.Text = "n/a";
            // 
            // lblComissao
            // 
            this.lblComissao.AutoSize = true;
            this.lblComissao.Location = new System.Drawing.Point(97, 115);
            this.lblComissao.Name = "lblComissao";
            this.lblComissao.Size = new System.Drawing.Size(24, 13);
            this.lblComissao.TabIndex = 14;
            this.lblComissao.Text = "n/a";
            // 
            // textBoxValorComissao
            // 
            this.textBoxValorComissao.Location = new System.Drawing.Point(147, 252);
            this.textBoxValorComissao.Name = "textBoxValorComissao";
            this.textBoxValorComissao.Size = new System.Drawing.Size(243, 20);
            this.textBoxValorComissao.TabIndex = 16;
            // 
            // textBoxValorNegociado
            // 
            this.textBoxValorNegociado.Location = new System.Drawing.Point(147, 222);
            this.textBoxValorNegociado.Name = "textBoxValorNegociado";
            this.textBoxValorNegociado.Size = new System.Drawing.Size(243, 20);
            this.textBoxValorNegociado.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(147, 188);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(271, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // comboBoxComprador
            // 
            this.comboBoxComprador.DataSource = this.vendaBindingSource;
            this.comboBoxComprador.FormattingEnabled = true;
            this.comboBoxComprador.Location = new System.Drawing.Point(147, 289);
            this.comboBoxComprador.Name = "comboBoxComprador";
            this.comboBoxComprador.Size = new System.Drawing.Size(271, 21);
            this.comboBoxComprador.TabIndex = 19;
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataMember = "Venda";
            this.vendaBindingSource.DataSource = this.projetoDADataSet;
            // 
            // projetoDADataSet
            // 
            this.projetoDADataSet.DataSetName = "ProjetoDADataSet";
            this.projetoDADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(396, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "€";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(396, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "€";
            // 
            // casaCasaVendavelBindingSource
            // 
            this.casaCasaVendavelBindingSource.DataMember = "Casa_CasaVendavel";
            this.casaCasaVendavelBindingSource.DataSource = this.projetoDADataSet;
            // 
            // casa_CasaVendavelTableAdapter
            // 
            this.casa_CasaVendavelTableAdapter.ClearBeforeFill = true;
            // 
            // casaCasaVendavelBindingSource1
            // 
            this.casaCasaVendavelBindingSource1.DataMember = "Casa_CasaVendavel";
            this.casaCasaVendavelBindingSource1.DataSource = this.projetoDADataSet;
            // 
            // vendaTableAdapter
            // 
            this.vendaTableAdapter.ClearBeforeFill = true;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.projetoDADataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // VendaDeCasaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 355);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxComprador);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxValorNegociado);
            this.Controls.Add(this.textBoxValorComissao);
            this.Controls.Add(this.lblComissao);
            this.Controls.Add(this.lblProprietario);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.btnEfetivarVenda);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "VendaDeCasaForm";
            this.Text = "VendaDeCasaForm";
            this.Load += new System.EventHandler(this.VendaDeCasaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoDADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaCasaVendavelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaCasaVendavelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEfetivarVenda;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblProprietario;
        private System.Windows.Forms.Label lblComissao;
        private System.Windows.Forms.TextBox textBoxValorComissao;
        private System.Windows.Forms.TextBox textBoxValorNegociado;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxComprador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private ProjetoDADataSet projetoDADataSet;
        private System.Windows.Forms.BindingSource casaCasaVendavelBindingSource;
        private ProjetoDADataSetTableAdapters.Casa_CasaVendavelTableAdapter casa_CasaVendavelTableAdapter;
        private System.Windows.Forms.BindingSource casaCasaVendavelBindingSource1;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private ProjetoDADataSetTableAdapters.VendaTableAdapter vendaTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private ProjetoDADataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
    }
}