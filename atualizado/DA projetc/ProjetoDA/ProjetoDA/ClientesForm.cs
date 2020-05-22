using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDA
{
    public partial class ClientesForm : Form
    {
        private Model1Container clienteContainer;
        public ClientesForm()
        {
            InitializeComponent();
            clienteContainer = new Model1Container();

            (from cliente in clienteContainer.Cliente
             orderby cliente.Nome
             select cliente).Load();

            clienteBindingSource.DataSource = clienteContainer.Cliente.Local.ToBindingList();
                
        }

        private void btnCguardar_Click(object sender, EventArgs e)
        {
            clienteContainer.SaveChanges();
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'projetoDADataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.projetoDADataSet.Cliente);

        }

        private void txtboxCNome_TextChanged(object sender, EventArgs e)
        {
            
           // txtboxCNome.Text = nomeDataGridViewTextBoxColumn;
        }

        private void btnCnovo_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add( txtboxCNome, txtboxCnif, txtboxCmorada, txtboxCContacto);
        
        }
    }
}
