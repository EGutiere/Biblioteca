using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.Model
{
    class ItensVenda
    {
        public Produto Produto { get; set; }
        public int QuantidadeVendida { get; set; }
        public double PrecoUnitario { get; set; }
    }
}
