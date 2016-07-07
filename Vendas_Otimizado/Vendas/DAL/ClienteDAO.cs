using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendas.Model;

namespace Vendas.DAL
{
    class ClienteDAO
    {
        private static List<Cliente> listaDeClientes = new List<Cliente>();

        public static bool AdicionarCliente(Cliente c)
        {
            if (VerificarClientePorCPF(c) == null)
            {
                listaDeClientes.Add(c);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static List<Cliente> RetornarLista()
        {
            return listaDeClientes;
        }

        public static Cliente VerificarClientePorCPF(Cliente c)
        {
            foreach (Cliente clienteCadastrado in ClienteDAO.RetornarLista())
            {
                if (c.Cpf.Equals(clienteCadastrado.Cpf))
                {
                    return clienteCadastrado;
                }
            }
            return null;
        }
    }
}
