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
    
    public partial class DetalheConta
    {
        public int DetalheContaPK { get; set; }
        public Nullable<int> ContaFK { get; set; }
        public Nullable<int> SerieFK { get; set; }
        public string Movimento { get; set; }
    
        public virtual Conta Conta { get; set; }
        public virtual Serie Serie { get; set; }
    }
}
