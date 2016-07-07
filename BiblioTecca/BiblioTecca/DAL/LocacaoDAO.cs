using System;
using System.Linq;
using BiblioTecca.Model;
using System.Collections.Generic;
using System.Data.Entity;

namespace BiblioTecca.DAL
{
    class LocacaoDAO
    {
        private static Context ctx = Singleton.Instance.Context;

        public static bool AdicionarLocacao(Locacao l)
        {
            try
            {
                ctx.Locacoes.Add(l);
                ctx.SaveChanges();                
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool AlterarLocacao(Locacao l)
        {
            try
            {
                ctx.Entry(l).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Locacao BuscarLocacaoPorId(Locacao l)
        {
            return ctx.Locacoes.Include(livro => livro.LocacaoLivro).Include(p => p.LocacaoPessoa).FirstOrDefault(x => x.IdLocacao.Equals(l.IdLocacao));
        }
    }
}
