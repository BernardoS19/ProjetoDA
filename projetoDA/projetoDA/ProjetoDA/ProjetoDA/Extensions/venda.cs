using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA
{
    public partial class Venda
    {
        public override string ToString()
        {
            return this.DataVenda.ToString("dd/mm/yyyy") + ". Valor:" + this.ValorNegociado + ". Comissão: " + this.ComissaoNegociada + ". Comprado por " + this.Comprador.Nome.ToString();
        }
    }
}
