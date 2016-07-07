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
        private static Context ctx = Singleton.Instance.Context;

        public static bool AdicionarProduto(Produto p)
        {
            if (VerificarProdutoPorNome(p) == null)
            {
                ctx.Produtos.Add(p);
                ctx.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static List<Produto> RetornarLista()
        {
            return ctx.Produtos.ToList();
        }

        public static Produto VerificarProdutoPorNome(Produto p)
        {
            return ctx.Produtos.FirstOrDefault(x => x.Nome.Equals(p.Nome));
        }
    }
}
