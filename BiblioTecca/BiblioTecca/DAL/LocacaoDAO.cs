using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblioTecca.Model;

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

        public static Locacao VerificarLocacao(Locacao l)
        {
            return ctx.Locacoes.FirstOrDefault(x => x.IdLocacao.Equals(l.IdLocacao)); //&& x.LocacaoLivro.IdLivro.Equals(l.LocacaoLivro.IdLivro));
        }

        public static Locacao VerificarLocacaoPorNomePessoa(Locacao l)
        {
            return ctx.Locacoes.FirstOrDefault(x => x.LocacaoPessoa.PessoaNome.Equals(l.LocacaoPessoa.PessoaNome));
        }        

        public static Locacao VerificarLocacaoPorNomeLivro(Locacao l)
        {
            return ctx.Locacoes.FirstOrDefault(x => x.LocacaoLivro.LivroNome.Equals(l.LocacaoLivro.LivroNome));
        }

        public static Locacao VerificarLocacaoPorIdLocacao(Locacao l)
        {
            return ctx.Locacoes.FirstOrDefault(x => x.IdLocacao.Equals(l.IdLocacao));
        }

        public static List<Locacao> RetornarListaDeLocacoes(Locacao l)
        {
            return ctx.Locacoes.ToList();
        }        
    }
}
