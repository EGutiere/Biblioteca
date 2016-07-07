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

        public static List<Venda> RetornaListaPorCliente(Cliente c)
        {
            List<Venda> listaDeVendaAux = new List<Venda>();
            foreach (Venda vendasCadastradas in listaDeVendas)
            {
                if (vendasCadastradas.Cliente.Nome.Equals(c.Nome))
                {
                    listaDeVendaAux.Add(vendasCadastradas);
                }
            }
            return listaDeVendaAux;
        }

        public static List<Venda> RetornaListaPorVendedor(Vendedor v)
        {
            List<Venda> listaDeVendaAux = new List<Venda>();
            foreach (Venda vendasCadastradas in listaDeVendas)
            {
                if (vendasCadastradas.Vendedor.Nome.Equals(v.Nome))
                {
                    listaDeVendaAux.Add(vendasCadastradas);
                }
            }
            return listaDeVendaAux;
        }

        public static List<Venda> RetornarListaPorCep(Endereco e)
        {
            List<Venda> listaDeVendaAux = new List<Venda>();
            foreach (Venda vendasCadastradas in listaDeVendas)
            {
                if (vendasCadastradas.Endereco.Cep.Equals(e.Cep))
                {
                    listaDeVendaAux.Add(vendasCadastradas);
                }                
            }
            return listaDeVendaAux;
        }

        public static List<Venda> RetornarListaPorFormaPagamento(FormaPagamento f)
        {
            List<Venda> listaDeVendaAux = new List<Venda>();
            foreach (Venda vendasCadastradas in listaDeVendas)
            {
                if (vendasCadastradas.FormaPagamento.Nome.Equals(f.Nome))
                {
                    listaDeVendaAux.Add(vendasCadastradas);
                }
            }
            return listaDeVendaAux;
        }

    }
}
