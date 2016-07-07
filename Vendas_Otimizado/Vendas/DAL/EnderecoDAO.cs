using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendas.Model;

namespace Vendas.DAL
{
    class EnderecoDAO
    {
        public static List<Endereco> listaDeEnderecos = new List<Endereco>();

        public static bool AdicionarEndereco (Endereco e)
        {
            if (VerificarEnderecoPorCep(e) == null)
            {
                listaDeEnderecos.Add(e);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static List<Endereco> RetornarLista()
        {
            return listaDeEnderecos;
        }

        public static Endereco VerificarEnderecoPorCep(Endereco e)
        {
            foreach (Endereco enderecoCadastrado in EnderecoDAO.RetornarLista())
            {
                if (e.Cep.Equals(enderecoCadastrado.Cep))
                {
                    return enderecoCadastrado;
                }                
            }
            return null;
        }

    }
}
