using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webProjectoFinal_03
{
    public class LinhaFatura
    {
        public int ProdutoPK { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
        public decimal IVA { get; set; }
        public decimal valorIVA { get; set; }
        public decimal totalIVA { get; set; }

    }
}