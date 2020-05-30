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
    public partial class GerirCasasForm : Form
    {
        private Model1Container casaContainer;
        public GerirCasasForm()
        {
            InitializeComponent();
            casaContainer = new Model1Container();

            // query que faz com que os dados do datagrid sejam apresentados por ordem do ID de forma ascendente quando iniciamos a aplicação
            (from Casa in casaContainer.Casa
             orderby Casa.IdCasa
             select Casa).Load();

            // apresenta os dados da casa
            casaBindingSource.DataSource = casaContainer.Casa.Local.ToBindingList();
        }

        private void btnGerirLimpezas_Click(object sender, EventArgs e)
        {
            // abre o formulário dos Serviços de Limpezas
            LimpezasForm limpezaF = new LimpezasForm();
            limpezaF.ShowDialog();
        }

        private void btnFormArrendar_Click(object sender, EventArgs e)
        {
            // abre o formulário do arrendamento de casas
            ArrendamentosForm ArrendarF = new ArrendamentosForm();
            ArrendarF.ShowDialog();
        }

        private void btnFormVenda_Click(object sender, EventArgs e)
        {
            // abre o formulário da venda de casas
            VendaDeCasaForm VendaF = new VendaDeCasaForm();
            VendaF.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // guarda a informação escrita nas txtboxs na database e da atualiza o datagrid para mostrar a informação sempre atualizada
            Casa casaSelecionada = (Casa)dataGridView1.CurrentRow.DataBoundItem;

            casaSelecionada.Localidade = textBoxCasaLocalidade.Text;
            casaSelecionada.Rua = textBoxCasaRua.Text;
            casaSelecionada.Numero = textBoxCasaNumero.Text;
            casaSelecionada.Andar = textBoxCasaAndar.Text;
            casaSelecionada.Area = numericUpDownArea.Value;
            casaSelecionada.NumeroAssoalhada = numericUpDownAssoalhada.Value;
            casaSelecionada.NumeroWC = numericUpDownWC.Value;
            casaSelecionada.NumeroPisos = numericUpDownPisos.Value;
            casaSelecionada.Tipo = 
            casaSelecionada.Cliente.Nome = comboBox2.Text;

            dataGridView1.Refresh();
            casaContainer.SaveChanges();
        }

        private void btnNova_Click(object sender, EventArgs e)
        {
            // adiciona uma nova linha em branco
            casaBindingSource.AddNew();
        }
    }
}
