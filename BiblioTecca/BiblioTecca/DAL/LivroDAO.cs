using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblioTecca.Model;

namespace BiblioTecca.DAL
{
    class LivroDAO
    {
        private static Context ctx = Singleton.Instance.Context;

        public static bool AdicionarLivro(Livro l)
        {
            try
            {
                l.LivroStatus = true;
                ctx.Livros.Add(l);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool AlterarLivro(Livro l)
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

        public static bool RemoverLivro(Livro l)
        {
            try
            {
                if (VerificarLivroPorNome(l) != null)
                {
                    ctx.Livros.Remove(l);
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

        public static List<Livro> RetornarLista()
        {
            return ctx.Livros.ToList();
        }

        public static Livro VerificarLivroPorNome(Livro l)
        {
            return ctx.Livros.FirstOrDefault(x => x.LivroNome.Equals(l.LivroNome));
        }

        public static Livro VerificarLivroPorCod(Livro l)
        {
            return ctx.Livros.FirstOrDefault(x => x.IdLivro.Equals(l.IdLivro));
        }
    }
}
