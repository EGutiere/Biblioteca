using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.Model
{
    class Venda
    {
        public Cliente Cliente { get; set; }
        public Vendedor Vendedor { get; set; }
        public List<ItensVenda> ListaDeProdutos { get; set; }
        public DateTime DataDaCompra { get; set; }

        public Venda()
        {
            Cliente = new Model.Cliente();
            Vendedor = new Model.Vendedor();
            ListaDeProdutos = new List<ItensVenda>();
        }
    }
}
