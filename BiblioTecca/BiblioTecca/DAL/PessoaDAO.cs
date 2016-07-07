using System;
using System.Collections.Generic;
using System.Linq;
using BiblioTecca.Model;

namespace BiblioTecca.DAL
{
    class PessoaDAO
    {
        private static Context ctx = Singleton.Instance.Context;

        public static bool AdicionarPessoa(Pessoa p)
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
            return ctx.Pessoas.FirstOrDefault(x => x.PessoaCpf.Equals(p.PessoaCpf));
        }
    }
}
