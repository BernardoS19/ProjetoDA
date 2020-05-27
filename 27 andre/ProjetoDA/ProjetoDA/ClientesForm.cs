using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
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

            (from Cliente in clienteContainer.Cliente
             orderby Cliente.Nome
             select Cliente).Load();

            clienteBindingSource1.DataSource = clienteContainer.Cliente.Local.ToBindingList();

            

       
        }

        private void btnCguardar_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)dataGridView1.CurrentRow.DataBoundItem;

            clienteSelecionado.Nome = txtboxCNome.Text;

            clienteSelecionado.Nif = txtboxCnif.Text;

            clienteSelecionado.Morada = txtboxCmorada.Text;

            clienteSelecionado.Contacto = txtboxCContacto.Text;

            dataGridView1.Refresh();

            clienteContainer.SaveChanges();

            MessageBox.Show("Os dados do cliente foram alterados", "alteração");
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'projetoDADataSet.ArrendamentoSet'. Você pode movê-la ou removê-la conforme necessário.
            //this.arrendamentoSetTableAdapter.Fill(this.projetoDADataSet.ArrendamentoSet);
            // TODO: esta linha de código carrega dados na tabela 'projetoDADataSet.Venda'. Você pode movê-la ou removê-la conforme necessário.
            //this.vendaTableAdapter.Fill(this.projetoDADataSet.Venda);
            // TODO: esta linha de código carrega dados na tabela 'projetoDADataSet.Casa'. Você pode movê-la ou removê-la conforme necessário.
            //this.casaTableAdapter.Fill(this.projetoDADataSet.Casa);
            //this.clienteTableAdapter.Fill(this.projetoDADataSet.Cliente);

        }

        private void txtboxCNome_TextChanged(object sender, EventArgs e)
        {


            dataGridView1.Rows.ToString();


        }

        private void btnCnovo_Click(object sender, EventArgs e)
        {
            /* Cliente novoCliente = new Cliente();

             novoCliente.Nome = txtboxCNome.Text;
             novoCliente.Nif = txtboxCnif.Text;
             novoCliente.Morada = txtboxCmorada.Text;
             novoCliente.Contacto = txtboxCContacto.Text;

             clienteContainer.Cliente.Add(novoCliente);

             clienteContainer.SaveChanges();
             dataGridView1.DataSource = clienteContainer.Cliente.ToList();
             dataGridView1.Refresh();

             btnCnovo.Text = "novo";
             dataGridView1.Enabled = true;

             dataGridView1.ClearSelection();
             txtboxCNome.Text = "";
             txtboxCnif.Text = "";
             txtboxCmorada.Text = "";
             txtboxCContacto.Text = "";*/

            //btnCguardar.Enabled = false;

            clienteBindingSource1.AddNew();


        }

        private void btnCfiltrar_Click(object sender, EventArgs e)
        {
            if (txtFiltro.Text.Length > 0)
            {
                switch (cboFiltrar.SelectedIndex)
                {
                    case 0:

                clienteContainer.Dispose();
                clienteContainer = new Model1Container();
                (from Cliente in clienteContainer.Cliente
                 where Cliente.Nome.ToUpper().Contains(txtFiltro.Text.ToUpper())
                 orderby Cliente.Nome
                 select Cliente).ToList();

                clienteBindingSource1.DataSource = clienteContainer.Cliente.Local.ToBindingList();
                        break;
                    case 1:

                        clienteContainer.Dispose();
                        clienteContainer = new Model1Container();
                        (from Cliente in clienteContainer.Cliente
                         where Cliente.Nif.ToUpper().Contains(txtFiltro.Text.ToUpper())
                         orderby Cliente.Nif
                         select Cliente).ToList();

                        clienteBindingSource1.DataSource = clienteContainer.Cliente.Local.ToBindingList();
                        break;
                   
                    case 2:

                        clienteContainer.Dispose();
                        clienteContainer = new Model1Container();
                        (from Cliente in clienteContainer.Cliente
                         where Cliente.Contacto.ToUpper().Contains(txtFiltro.Text.ToUpper())
                         orderby Cliente.Contacto
                         select Cliente).ToList();

                        clienteBindingSource1.DataSource = clienteContainer.Cliente.Local.ToBindingList();
                        break;
                    
                }
                
            }
            else
            {
        
                clienteContainer.Dispose();
                clienteContainer = new Model1Container();
                (from Cliente in clienteContainer.Cliente
                 orderby Cliente.Nome
                 select Cliente).Load();

                clienteBindingSource1.DataSource = clienteContainer.Cliente.Local.ToBindingList();
            }
        }

        private void cboFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBoxCcasas_SelectedIndexChanged(object sender, EventArgs e)
        {
            fKClienteCasaBindingSource1.DataSource = clienteContainer.Casa.Local.ToBindingList();
            
        }

        private void listBoxCcasas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBoxCcasas.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                MessageBox.Show(index.ToString());
            }
        }
    }
}