using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendas.Model;

namespace Vendas.DAL
{
    class FormaPagamentoDAO
    {
        public static List<FormaPagamento> listaDeFormaPagamento = new List<FormaPagamento>();

        public static bool AdicionarFromaPagamento(FormaPagamento p)
        {
            if (VerificarFormaPagamento(p) == null)
            {
                listaDeFormaPagamento.Add(p);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static List<FormaPagamento> RetornarLista()
        {
            return listaDeFormaPagamento;
        }

        public static FormaPagamento VerificarFormaPagamento(FormaPagamento f)
        {
            foreach (FormaPagamento formaPagamentoCadastrada in FormaPagamentoDAO.RetornarLista())
            {
                if (f.Nome.Equals(formaPagamentoCadastrada.Nome))
                {
                    return formaPagamentoCadastrada;
                }
            }
            return null;
        }
    }
}
