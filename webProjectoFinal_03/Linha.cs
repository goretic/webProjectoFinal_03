//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webProjectoFinal_03
{
    using System;
    using System.Collections.Generic;
    
    public partial class Linha
    {
        public int LinhaPK { get; set; }
        public Nullable<int> DocumentoFK { get; set; }
        public Nullable<int> ProdutoFK { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public Nullable<decimal> Preco { get; set; }
        public Nullable<decimal> IVA { get; set; }
    
        public virtual Documento Documento { get; set; }
        public virtual Produto Produto { get; set; }
    }
}