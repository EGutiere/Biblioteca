using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendas.Model;

namespace Vendas.DAL
{
    class VendedorDAO
    {
        private static Context ctx = Singleton.Instance.Context;
        public static bool AdicionarVendedor(Vendedor v)
        {
            if (VerificarVendedorPorCPF(v) == null)
            {
                ctx.Vendedores.Add(v);
                ctx.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static List<Vendedor> RetornarLista()
        {
            return ctx.Vendedores.ToList();
        }

        public static Vendedor VerificarVendedorPorCPF(Vendedor v)
        {
            return ctx.Vendedores.FirstOrDefault(x => x.Cpf.Equals(v.Cpf));
        }
    }
}
