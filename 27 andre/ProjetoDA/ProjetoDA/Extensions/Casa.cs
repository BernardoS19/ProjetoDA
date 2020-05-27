using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA
{
    public partial class Casa
    {
        public override string ToString()
        {
            
            return this.IdCasa + " " + this.Localidade + " " + this.Tipo.ToString();
             
         
        }
    }
}
