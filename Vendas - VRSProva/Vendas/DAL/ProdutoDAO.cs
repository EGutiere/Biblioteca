using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendas.Model;

namespace Vendas.DAL
{
    class ProdutoDAO
    {
        private static List<Produto> listaDeProdutos = new List<Produto>();

        public static bool AdicionarProduto(Produto p)
        {
            if (VerificarProdutoPorNome(p) == null)
            {
                listaDeProdutos.Add(p);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static List<Produto> RetornarLista()
        {
            return listaDeProdutos;
        }

        public static Produto VerificarProdutoPorNome(Produto p)
        {
            foreach (Produto produtoCadastrado in ProdutoDAO.RetornarLista())
            {
                if (p.Nome.Equals(produtoCadastrado.Nome))
                {
                    return produtoCadastrado;
                }
            }
            return null;
        }
    }
}
