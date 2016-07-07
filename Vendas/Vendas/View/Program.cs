using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendas.DAL;
using Vendas.Model;

//goo.gl/8dvNIN

namespace Vendas.View
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            Cliente c = new Cliente();
            Vendedor v = new Vendedor();
            Produto p = new Produto();
            Venda venda = new Venda();
            ItensVenda itensVenda = new ItensVenda();
            FormaDePagamento pagamento = new FormaDePagamento();
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Listar Clientes");
                Console.WriteLine("3 - Cadastrar Vendedor");
                Console.WriteLine("4 - Listar Vendedores");
                Console.WriteLine("5 - Cadastrar Vendedor");
                Console.WriteLine("6 - Listar Vendedores");
                Console.WriteLine("7 - Realizar Venda");
                Console.WriteLine("8 - Listar Vendas");
                Console.WriteLine("9 - Listar Vendas por Cliente");
                Console.WriteLine("10 - Cadastrar Forma de Pagamento");
                Console.WriteLine("11 - Listar Vendas por Forma");
                Console.WriteLine("12 - Remover Cliente");
                Console.WriteLine("13 - Alterar Cliente");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("Digite a sua opção: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        c = new Cliente();
                        Console.WriteLine("Digite o Nome: ");
                        c.Nome = Console.ReadLine();
                        Console.WriteLine("Digite o CPF: ");
                        c.Cpf = Console.ReadLine();
                        if (ClienteDAO.AdicionarCliente(c))
                        {
                            Console.WriteLine("Cliente cadastrado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Cliente já cadastrado!");
                        }
                        break;
                    case "2":
                        Console.WriteLine(" --- Lista de Clientes ---");
                        if (ClienteDAO.RetornarLista().Count > 0)
                        {
                            foreach (Cliente clienteCadastrado in ClienteDAO.RetornarLista())
                            {
                                Console.WriteLine("Nome: " + clienteCadastrado.Nome);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Lista vazia!");
                        }
                        break;
                    case "3":
                        v = new Vendedor();
                        Console.WriteLine("Digite o Nome: ");
                        v.Nome = Console.ReadLine();
                        Console.WriteLine("Digite o CPF: ");
                        v.Cpf = Console.ReadLine();
                        Console.WriteLine("Digite a taxa de comissão: ");
                        v.Comissao = Convert.ToDouble(Console.ReadLine());
                        if (VendedorDAO.AdicionarVendedor(v))
                        {
                            Console.WriteLine("Vendedor cadastrado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Vendedor já cadastrado!");
                        }
                        break;
                    case "4":
                        Console.WriteLine(" --- Lista de Vendedores ---");
                        if (VendedorDAO.RetornarLista().Count > 0)
                        {
                            foreach (Vendedor vendedorCadastrado in VendedorDAO.RetornarLista())
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
                        if (ProdutoDAO.AdicionarProduto(p))
                        {
                            Console.WriteLine("Produto cadastrado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Produto já cadastrado!");
                        }
                        break;
                    case "6":
                        Console.WriteLine(" --- Lista de Produtos ---");
                        if (ProdutoDAO.RetornarLista().Count > 0)
                        {
                            foreach (Produto produtoCadastrado in ProdutoDAO.RetornarLista())
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
                    case "7":
                        c = new Cliente();
                        v = new Vendedor();
                        p = new Produto();
                        venda = new Venda();
                        pagamento = new FormaDePagamento();
                        
                        Console.WriteLine("Digite o CPF do cliente: ");
                        c.Cpf = Console.ReadLine();
                        venda.Cliente = ClienteDAO.VerificarClientePorCPF(c);

                        Console.WriteLine("Digite o CPF do vendedor: ");
                        v.Cpf = Console.ReadLine();
                        venda.Vendedor = VendedorDAO.VerificarVendedorPorCPF(v);

                        Console.WriteLine("Digite a forma de pagamento ");
                        pagamento.Nome = Console.ReadLine();
                        venda.FormaDePagamento = FormaDePagamentoDAO.VerificarFormaDePagamentoPorNome(pagamento);

                        if (venda.FormaDePagamento != null)
                        {

                            string verificar;
                            do
                            {
                                itensVenda = new ItensVenda();

                                Console.WriteLine("\nDigite o nome do produto: ");
                                p.Nome = Console.ReadLine();
                                p = ProdutoDAO.VerificarProdutoPorNome(p);

                                itensVenda.Produto = p;
                                itensVenda.PrecoUnitario = p.Markup * p.PrecoCompra;
                                Console.WriteLine("Digite a quantidade: ");
                                itensVenda.QuantidadeVendida = Convert.ToInt32(Console.ReadLine());

                                venda.ListaDeProdutos.Add(itensVenda);

                                Console.WriteLine("\nDeseja adicionar mais um produto? (S ou N)");
                                verificar = Console.ReadLine();
                            } while (verificar.ToUpper().Equals("S") ||
                                verificar.ToUpper().Equals("SIM"));

                            venda.DataDaCompra = DateTime.Now;

                            VendaDAO.AdicionarVenda(venda);
                            Console.WriteLine("Venda registrada com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Não foi possível realizar a venda!");
                        }
                        break;
                    case "8":
                        if (!ImprimirListaDeVendas(VendaDAO.RetornarLista()))
                        {
                            Console.WriteLine("Lista vazia");
                        }
                        break;
                    case "9":
                        c = new Cliente();
                        Console.WriteLine("Digite o CPF do cliente: ");
                        c.Cpf = Console.ReadLine();
                        if (!ImprimirListaDeVendas(VendaDAO.BuscarVendasPorCliente(c)))
                        {
                            Console.WriteLine("Lista vazia");
                        }
                        break;
                    case "10":
                        pagamento = new FormaDePagamento();
                        Console.WriteLine("Digite o Nome: ");
                        pagamento.Nome = Console.ReadLine();
                        if (FormaDePagamentoDAO.AdicionarFormaDePagamento(pagamento))
                        {
                            Console.WriteLine("Forma de pagamento cadastrada com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Forma de pagamento já cadastrada!");
                        }
                        break;
                    case "11":
                        pagamento = new FormaDePagamento();
                        Console.WriteLine("Digite o nome da forma de pagamento: ");
                        pagamento.Nome = Console.ReadLine();
                        if (!ImprimirListaDeVendas(VendaDAO.BuscarVendasPorFormaDePagamento(pagamento)))
                        {
                            Console.WriteLine("Lista vazia");
                        }
                        break;
                    case "12":
                        c = new Cliente();
                        Console.WriteLine("Digite o CPF: ");
                        c.Cpf = Console.ReadLine();
                        c = ClienteDAO.VerificarClientePorCPF(c);
                        if (c != null)
                        {
                            Console.WriteLine("Nome: " + c.Nome);
                            Console.WriteLine("Cpf: " + c.Cpf);
                            Console.WriteLine("Deseja remover o registro?");
                            if (Console.ReadLine().ToUpper().Equals("S"))
                            {
                                if (ClienteDAO.RemoverCliente(c))
                                {
                                    Console.WriteLine("Remoção efetuada com sucesso!");
                                }else
                                {
                                    Console.WriteLine("Remoção não efetuada!");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Cliente não encontrado!");
                        }
                        break;
                    case "13":
                        c = new Cliente();
                        Console.WriteLine("Digite o CPF: ");
                        c.Cpf = Console.ReadLine();
                        c = ClienteDAO.VerificarClientePorCPF(c);
                        if (c != null)
                        {
                            Console.WriteLine("Nome: " + c.Nome);
                            Console.WriteLine("Cpf: " + c.Cpf);
                            Console.WriteLine("Deseja alterar o registro?");
                            if (Console.ReadLine().ToUpper().Equals("S"))
                            {
                                Console.WriteLine("Digite o Nome: ");
                                c.Nome = Console.ReadLine();
                                if (ClienteDAO.AlterarCliente(c))
                                {
                                    Console.WriteLine("Alteraçãp efetuada com sucesso!");
                                }
                                else
                                {
                                    Console.WriteLine("Alteração não efetuada!");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Cliente não encontrado!");
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

        public static bool ImprimirListaDeVendas(List<Venda> lista)
        {
            if (lista.Count > 0)
            {
                Console.WriteLine(" --- Lista de Vendas ---");
                foreach (Venda vendaCadastrada in lista)
                {
                    Console.WriteLine("\nData: " + vendaCadastrada.DataDaCompra);
                    Console.WriteLine("Cliente: " + vendaCadastrada.Cliente.Nome);
                    Console.WriteLine("Vendedor: " + vendaCadastrada.Vendedor.Nome);
                    Console.WriteLine(" --- Lista de Produtos ---");
                    double precoTotal = 0;
                    foreach (ItensVenda produtoCadastrado in vendaCadastrada.ListaDeProdutos)
                    {
                        Console.WriteLine("\n\tNome: " + produtoCadastrado.Produto.Nome);
                        Console.WriteLine("\tPreço: " + produtoCadastrado.PrecoUnitario.ToString("C2"));
                        Console.WriteLine("\tQuantidade: " + produtoCadastrado.QuantidadeVendida);
                        double subTotal = produtoCadastrado.PrecoUnitario *
                            produtoCadastrado.QuantidadeVendida;
                        precoTotal += subTotal;
                        Console.WriteLine("\tSubtotal: " + subTotal.ToString("C2"));

                    }
                    Console.WriteLine("Total da compra: " + precoTotal.ToString("C2"));
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
