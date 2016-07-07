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
        private static Context ctx = Singleton.Instance.Context;
        public static bool AdicionarCliente(Cliente c)
        {
            if (VerificarClientePorCPF(c) == null)
            {
                ctx.Clientes.Add(c);
                ctx.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static List<Cliente> RetornarLista()
        {
            return ctx.Clientes.ToList();
        }

        public static Cliente VerificarClientePorCPF(Cliente c)
        {
            return ctx.Clientes.FirstOrDefault(x => x.Cpf.Equals(c.Cpf));
        }

        public static bool RemoverCliente(Cliente c)
        {
            try
            {
                if (VerificarClientePorCPF(c) != null)
                {
                    ctx.Clientes.Remove(c);
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

        public static bool AlterarCliente(Cliente c)
        {
            try
            {
                ctx.Entry(c).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


    }
}
