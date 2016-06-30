using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Model;

namespace Biblioteca.DAL
{
    class PessoaDAO
    {
        private static Context ctx = Singleton.Instance.Context;

        public static bool AdicionarCliente(Pessoa p)
        {
            if (VerificarPessoaPorCPF(p) == null)
            {
                ctx.Pessoas.Add(p);
                ctx.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool AlterarPessoa(Pessoa p)
        {
            try
            {
                ctx.Entry(p).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool RemoverPessoa(Pessoa p)
        {
            try
            {
                if (VerificarPessoaPorCPF(p) != null)
                {
                    ctx.Pessoas.Remove(p);
                    ctx.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static List<Pessoa> RetornarLista()
        {
            return ctx.Pessoas.ToList();
        }

        public static Pessoa VerificarPessoaPorCPF(Pessoa p)
        {
            return ctx.Pessoas.FirstOrDefault(x => x.Cpf.Equals(p.Cpf));
        }
    }
}
