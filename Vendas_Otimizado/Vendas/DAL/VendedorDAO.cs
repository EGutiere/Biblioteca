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
        private static List<Vendedor> listaDeVendedores = new List<Vendedor>();

        public static bool AdicionarVendedor(Vendedor v)
        {
            if (VerificarVendedorPorCPF(v) == null)
            {
                listaDeVendedores.Add(v);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static List<Vendedor> RetornarLista()
        {
            return listaDeVendedores;
        }

        public static Vendedor VerificarVendedorPorCPF(Vendedor v)
        {
            foreach (Vendedor vendedorCadastrado in VendedorDAO.RetornarLista())
            {
                if (v.Cpf.Equals(vendedorCadastrado.Cpf))
                {
                    return vendedorCadastrado;
                }
            }
            return null;
        }

        public static Vendedor VerificarVendedorPorNome(Vendedor v)
        {
            foreach (Vendedor vendedorCadastrado in VendedorDAO.RetornarLista())
            {
                if (v.Nome.Equals(vendedorCadastrado.Nome))
                {
                    return vendedorCadastrado;
                }
            }
            return null;
        }
    }
}
