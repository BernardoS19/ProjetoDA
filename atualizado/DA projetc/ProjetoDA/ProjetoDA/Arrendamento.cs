//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetoDA
{
    using System;
    using System.Collections.Generic;
    
    public partial class Arrendamento
    {
        public int IdArrendamento { get; set; }
        public System.DateTime InicioContrato { get; set; }
        public System.DateTimeOffset DuracaoMeses { get; set; }
        public bool Renovavel { get; set; }
    
        public virtual CasaArrendavel CasaArrendavel { get; set; }
        public virtual Cliente Arrendatario { get; set; }
    }
}
