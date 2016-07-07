using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendas.Model;

namespace Vendas.DAL
{
    class VendaDAO
    {
        private static List<Venda> listaDeVendas = new List<Venda>();
        private static List<Venda> listaDeVendasAux = new List<Venda>();
        private static Context ctx = Singleton.Instance.Context;

        public static bool AdicionarVenda(Venda v)
        {
            try
            {
                ctx.Vendas.Add(v);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static List<Venda> RetornarLista()
        {
            return ctx.Vendas.ToList();
        }

        /// <summary>
        /// Método que retorna todas as vendas com base no CPF do cliente
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static List<Venda> BuscarVendasPorCliente(Cliente c)
        {
            return ctx.Vendas.Include("Cliente").
                Include("Vendedor").
                Include("FormaDePagamento").
                Include("ListaDeProdutos").
                Include("ListaDeProdutos.Produto").
                Where(x => x.Cliente.Cpf.Equals(c.Cpf)).ToList();
        }

        public static List<Venda> BuscarVendasPorFormaDePagamento(FormaDePagamento pagamento)
        {
            return ctx.Vendas.Include("Cliente").
                Include("Vendedor").
                Include("FormaDePagamento").
                Include("ListaDeProdutos").
                Include("ListaDeProdutos.Produto").
                Where(x => x.FormaDePagamento.Nome.
                Equals(pagamento.Nome)).ToList();
        }
    }
}
