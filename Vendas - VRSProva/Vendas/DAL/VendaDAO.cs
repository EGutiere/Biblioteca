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

        public static void AdicionarVenda(Venda v)
        {
            listaDeVendas.Add(v);
        }

        public static List<Venda> RetornarLista()
        {
            return listaDeVendas;
        }

        /// <summary>
        /// Método que retorna todas as vendas com base no CPF do cliente
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static List<Venda> BuscarVendasPorCliente(Cliente c)
        {
            List<Venda> listaDeVendasAux = new List<Venda>();
            foreach (Venda vendaCadastrada in listaDeVendas)
            {
                if (vendaCadastrada.Cliente.Cpf.Equals(c.Cpf))
                {
                    listaDeVendasAux.Add(vendaCadastrada);
                }
            }
            return listaDeVendasAux;
        }
    }
}
