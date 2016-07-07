using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendas.Model;

namespace Vendas.DAL
{
    class FormaDePagamentoDAO
    {
        private static Context ctx = Singleton.Instance.Context;
        public static bool AdicionarFormaDePagamento(FormaDePagamento pagamento)
        {
            if (VerificarFormaDePagamentoPorNome(pagamento) == null)
            {
                ctx.FormasDePagamento.Add(pagamento);
                ctx.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static List<FormaDePagamento> RetornarLista()
        {
            return ctx.FormasDePagamento.ToList();
        }

        public static FormaDePagamento VerificarFormaDePagamentoPorNome(FormaDePagamento pagamento)
        {
            return ctx.FormasDePagamento.FirstOrDefault(x => x.Nome.Equals(pagamento.Nome));
        }
    }
}
