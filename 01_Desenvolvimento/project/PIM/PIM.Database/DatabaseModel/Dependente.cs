//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PIM.Database.DatabaseModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dependente
    {
        public int Identificador { get; set; }
        public string Nome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public int IdMorador { get; set; }
        public string GrauParentesco { get; set; }
    
        public virtual Morador Morador { get; set; }
    }
}
