using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            bool verificacao;
            Cliente c = new Cliente();
            Vendedor v = new Vendedor();
            Produto p = new Produto();
            List<Produto> listaDeProdutos = new List<Produto>();
            List<Vendedor> listaDeVendedores = new List<Vendedor>();
            List<Cliente> listaDeClientes = new List<Cliente>();
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Listar Clientes");
                Console.WriteLine("3 - Cadastrar Vendedor");
                Console.WriteLine("4 - Listar Vendedores");
                Console.WriteLine("5 - Cadastrar Vendedor");
                Console.WriteLine("6 - Listar Vendedores");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("Digite a sua opção: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        verificacao = false;
                        c = new Cliente();
                        Console.WriteLine("Digite o Id: ");
                        c.Id = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o Nome: ");
                        c.Nome = Console.ReadLine();
                        Console.WriteLine("Digite o CPF: ");
                        c.Cpf = Console.ReadLine();

                        foreach (Cliente clienteCadastrado in listaDeClientes)
                        {
                            if (c.Cpf.Equals(clienteCadastrado.Cpf))
                            {
                                verificacao = true;
                            }
                        }
                        if (verificacao)
                        {
                            Console.WriteLine("Cliente já cadastrado!");
                        }
                        else
                        {
                            listaDeClientes.Add(c);
                            Console.WriteLine("Cliente cadastrado com sucesso!");
                        }
                        break;
                    case "2":
                        Console.WriteLine(" --- Lista de Clientes ---");
                        if (listaDeClientes.Count > 0)
                        {
                            foreach (Cliente clienteCadastrado in listaDeClientes)
                            {
                                Console.WriteLine("Nome: " + clienteCadastrado.Id.ToString("0.00"));
                            }
                        }
                        else
                        {
                            Console.WriteLine("Lista vazia!");
                        }
                        break;
                    case "3":
                        v = new Vendedor();
                        Console.WriteLine("Digite o Id: ");
                        v.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o Nome: ");
                        v.Nome = Console.ReadLine();
                        Console.WriteLine("Digite o CPF: ");
                        v.Cpf = Console.ReadLine();
                        Console.WriteLine("Digite a taxa de comissão: ");
                        v.Comissao = Convert.ToDouble(Console.ReadLine());
                        listaDeVendedores.Add(v);
                        Console.WriteLine("Vendedor cadastrado com sucesso!");
                        break;
                    case "4":
                        Console.WriteLine(" --- Lista de Vendedores ---");
                        if (listaDeVendedores.Count > 0)
                        {
                            foreach (Vendedor vendedorCadastrado in listaDeVendedores)
                            {
                                Console.WriteLine("Nome: " + vendedorCadastrado.Nome);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Lista vazia!");
                        }
                        break;
                    case "5":
                        p = new Produto();
                        Console.WriteLine("Digite o Nome: ");
                        p.Nome = Console.ReadLine();
                        Console.WriteLine("Digite o preço de compra: ");
                        p.PrecoCompra = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o markup: ");
                        p.Markup = Convert.ToDouble(Console.ReadLine());
                        listaDeProdutos.Add(p);
                        Console.WriteLine("Produto cadastrado com sucesso!");
                        break;
                    case "6":
                        Console.WriteLine(" --- Lista de Produtos ---");
                        if (listaDeProdutos.Count > 0)
                        {
                            foreach (Produto produtoCadastrado in listaDeProdutos)
                            {
                                Console.WriteLine("Nome: " + produtoCadastrado.Nome);
                                double valorFinal = produtoCadastrado.Markup * 
                                    produtoCadastrado.PrecoCompra;
                                Console.WriteLine("Preço Final: " + valorFinal.ToString("C2") + "\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Lista vazia!");
                        }
                        break;
                    case "0":
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                Console.ReadKey();
            } while (!opcao.Equals("0"));

        }
    }
}
