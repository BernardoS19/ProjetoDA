using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ClientesForm clienteF = new ClientesForm();
            clienteF.ShowDialog();
        }

        private void pictureBoxGerirCasa_Click(object sender, EventArgs e)
        {
            GerirCasasForm CasaF = new GerirCasasForm();
            CasaF.ShowDialog();
        }
    }
}
