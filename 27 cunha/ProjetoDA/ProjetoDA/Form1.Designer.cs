namespace ProjetoDA
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxGereClientes = new System.Windows.Forms.PictureBox();
            this.pictureBoxGerirCasa = new System.Windows.Forms.PictureBox();
            this.lblclientes = new System.Windows.Forms.Label();
            this.LblCasas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGereClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGerirCasa)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(163, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imo DA";
            // 
            // pictureBoxGereClientes
            // 
            this.pictureBoxGereClientes.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGereClientes.Image")));
            this.pictureBoxGereClientes.Location = new System.Drawing.Point(50, 247);
            this.pictureBoxGereClientes.Name = "pictureBoxGereClientes";
            this.pictureBoxGereClientes.Size = new System.Drawing.Size(117, 110);
            this.pictureBoxGereClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGereClientes.TabIndex = 2;
            this.pictureBoxGereClientes.TabStop = false;
            this.pictureBoxGereClientes.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBoxGerirCasa
            // 
            this.pictureBoxGerirCasa.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGerirCasa.Image")));
            this.pictureBoxGerirCasa.Location = new System.Drawing.Point(299, 247);
            this.pictureBoxGerirCasa.Name = "pictureBoxGerirCasa";
            this.pictureBoxGerirCasa.Size = new System.Drawing.Size(114, 110);
            this.pictureBoxGerirCasa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGerirCasa.TabIndex = 3;
            this.pictureBoxGerirCasa.TabStop = false;
            this.pictureBoxGerirCasa.Click += new System.EventHandler(this.pictureBoxGerirCasa_Click);
            // 
            // lblclientes
            // 
            this.lblclientes.AutoSize = true;
            this.lblclientes.BackColor = System.Drawing.Color.Transparent;
            this.lblclientes.Location = new System.Drawing.Point(71, 231);
            this.lblclientes.Name = "lblclientes";
            this.lblclientes.Size = new System.Drawing.Size(70, 13);
            this.lblclientes.TabIndex = 4;
            this.lblclientes.Text = "Gere Clientes";
            // 
            // LblCasas
            // 
            this.LblCasas.AutoSize = true;
            this.LblCasas.Location = new System.Drawing.Point(329, 231);
            this.LblCasas.Name = "LblCasas";
            this.LblCasas.Size = new System.Drawing.Size(62, 13);
            this.LblCasas.TabIndex = 5;
            this.LblCasas.Text = "Gere Casas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(473, 381);
            this.Controls.Add(this.LblCasas);
            this.Controls.Add(this.lblclientes);
            this.Controls.Add(this.pictureBoxGerirCasa);
            this.Controls.Add(this.pictureBoxGereClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGereClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGerirCasa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxGerirCasa;
        private System.Windows.Forms.Label lblclientes;
        private System.Windows.Forms.Label LblCasas;
        private System.Windows.Forms.PictureBox pictureBoxGereClientes;
    }
}

