//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RelatorioExcel.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class METAS
    {
        public int ID_META { get; set; }
        public int META { get; set; }
        public int IDESP_EXAM { get; set; }
        public string NOME_ESPECIALIDADE { get; set; }
        public int IDCONTRATO { get; set; }
        public int CONCLUIDO { get; set; }
    
        public virtual CONTRATOes CONTRATOes { get; set; }
        public virtual ESPECIALIDADE_EXAMES ESPECIALIDADE_EXAMES { get; set; }
    }
}
