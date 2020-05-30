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
    public partial class VendaDeCasaForm : Form
    {
        private Model1Container vendaContainer;
        public VendaDeCasaForm()
        {
            InitializeComponent();
            
            vendaContainer = new Model1Container();

            // apresenta os dados da venda da casa
            vendaBindingSource.DataSource = vendaContainer.Venda.Local.ToBindingList();
            
        }

        private void btnEfetivarVenda_Click(object sender, EventArgs e)
        {
           
        }

        private void VendaDeCasaForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
