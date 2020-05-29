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
            
            // query que faz com que os dados do datagrid sejam apresentados por ordem do ID de forma ascendente quando iniciamos a aplicação
            (from Cliente in clienteContainer.Cliente
             orderby Cliente.IdCliente
             select Cliente).Load();

            // apresenta os dados do cliente
            clienteBindingSource1.DataSource = clienteContainer.Cliente.Local.ToBindingList();
        }

        private void btnCguardar_Click(object sender, EventArgs e)
        {
            // guarda a informação escrita nas txtboxs na database e da atualiza o datagrid para mostrar a informação sempre atualizada
            Cliente clienteSelecionado = (Cliente)dataGridView1.CurrentRow.DataBoundItem;
            
            clienteSelecionado.Nome = txtboxCNome.Text;
            clienteSelecionado.Nif = txtboxCnif.Text;
            clienteSelecionado.Morada = txtboxCmorada.Text;
            clienteSelecionado.Contacto = txtboxCContacto.Text;

            dataGridView1.Refresh();
            clienteContainer.SaveChanges();
        }

        private void btnCnovo_Click(object sender, EventArgs e)
        {
            // adiciona uma nova linha em branco
            clienteBindingSource1.AddNew();
        }

        private void btnCfiltrar_Click(object sender, EventArgs e)
        {
            if (txtFiltro.Text.Length > 0)
            {
                switch (cboFiltrar.SelectedIndex)
                {
                    // query que caso o index da combobox seja o 0 filtra a datagrid por Nome do cliente
                    case 0:
                        clienteContainer.Dispose();
                        clienteContainer = new Model1Container();
                        (from Cliente in clienteContainer.Cliente
                         where Cliente.Nome.ToUpper().Contains(txtFiltro.Text.ToUpper())
                         orderby Cliente.Nome
                         select Cliente).ToList();

                        clienteBindingSource1.DataSource = clienteContainer.Cliente.Local.ToBindingList();
                        break;
                    // query que caso o index da combobox seja o 1 filtra a datagrid por NIF do cliente
                    case 1:
                        clienteContainer.Dispose();
                        clienteContainer = new Model1Container();
                        (from Cliente in clienteContainer.Cliente
                         where Cliente.Nif.ToUpper().Contains(txtFiltro.Text.ToUpper())
                         orderby Cliente.Nif
                         select Cliente).ToList();

                        clienteBindingSource1.DataSource = clienteContainer.Cliente.Local.ToBindingList();
                        break;
                    // query que caso o index da combobox seja o 2 filtra a datagrid por Contacto do cliente
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
                // volta a mostrar todos os dados da database no datagrid caso nao esta selecionado nenhum filtro
                clienteContainer.Dispose();
                clienteContainer = new Model1Container();
                (from Cliente in clienteContainer.Cliente
                 orderby Cliente.Nome
                 select Cliente).Load();

                clienteBindingSource1.DataSource = clienteContainer.Cliente.Local.ToBindingList();
            }
        }

        private void listBoxCcasas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // abre o formulário de Venda de Casas
            VendaDeCasaForm VendasF = new VendaDeCasaForm();
            VendasF.ShowDialog();
        }

        private void listBoxCarrendamentos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // abre o formulário de Arrendamento de Casas
            ArrendamentosForm ArrendamentosF = new ArrendamentosForm();
            ArrendamentosF.ShowDialog();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // aprensenta os dados das casas venda/arrendamento/aquisição nas devidas listboxs
            Cliente ClienteSelecionado = (Cliente)dataGridView1.CurrentRow.DataBoundItem;
            listBoxCcasas.DataSource = ClienteSelecionado.Casas.ToList();
            listBoxCarrendamentos.DataSource = ClienteSelecionado.Arrendamentos.ToList();
            listBoxCaquisicoes.DataSource = ClienteSelecionado.Aquisicoes.ToList();
        }
    }
}