using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.EntitySql;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA
{
    public partial class Arrendamento {

        public override string ToString()
        {
            return this.InicioContrato.ToString("dd/mm/yyyy") + " por " + this.DuracaoMeses.ToString() + " meses, " + (this.Renovavel ? "" : "não") + " Renovavel a " + this.Arrendatario.ToString();
        }
    }
}
