using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA
{
    public partial class CasaVendavel : Casa
    {
        public override string ToString()
        {
            return this.IdCasa.ToString();
        }
    }
}
