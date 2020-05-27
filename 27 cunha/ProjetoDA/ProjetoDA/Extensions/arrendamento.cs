using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA
{
    public partial class Arrendamento {
        public override string ToString()
        {
            return this.InicioContrato + " " + this.DuracaoMeses + " " + this.Renovavel + " " + this.Arrendatario.ToString();
        }
    }
}
