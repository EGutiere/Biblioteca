using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BiblioTecca.DAL;
using BiblioTecca.Model;

namespace BiblioTecca.Views
{
    /// <summary>
    /// Interaction logic for frm_Alugar_Devolver.xaml
    /// </summary>
    public partial class frm_Alugar_Devolver : Window
    {
        private Livro livro = new Livro();
        private Locacao locacao = new Locacao();
        private Pessoa pessoa = new Pessoa();
        
        public frm_Alugar_Devolver()
        {
            InitializeComponent();

        }

        private void btn_fmr_Livros_Alugar_Devolver_Gravar_Click(object sender, RoutedEventArgs e)
        {
            locacao.LocacaoDataAluguel = DateTime.Today;
            locacao.LocacaoDataLimite = DateTime.Today.AddDays(10);

            livro.IdLivro = Convert.ToInt16(txt_CodLivro_Locacao.Text);          
            
        }

        private void btn_frmEmprestimo_Buscar_Click(object sender, RoutedEventArgs e)
        {
            locacao = new Locacao();

            locacao.IdLocacao = Convert.ToInt16(txt_IdLocacao_Buscar.Text);            

            locacao = LocacaoDAO.VerificarLocacaoPorIdLocacao(locacao);

            if (!string.IsNullOrEmpty(txt_IdLocacao_Buscar.Text))
            {
               
                if (locacao != null)
                {
                    txt_NomeLivro_Locacao.Text = locacao.LocacaoLivro.LivroNome;
                    txt_CodLivro_Locacao.Text = Convert.ToString(locacao.LocacaoLivro.IdLivro);

                    txt_NomePessoa_Locacao.Text = locacao.LocacaoPessoa.PessoaNome;
                    txt_CpfPessoa_Locacao.Text = locacao.LocacaoPessoa.PessoaCpf;

                    txt_Data_Limite_Devolucao.Text = Convert.ToString(locacao.LocacaoDataAluguel);

                    if (locacao.LocacaoStatus == true)
                    {
                        txt_Situacao.Text = "Alugado";
                    }
                    else
                    {
                        txt_Situacao.Text = "Devolvido";
                    }
                }
                else
                {
                    MessageBox.Show("Locação não encontrado!", "Locação de Livros",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Favor preencher o campo da busca", "Locação de Livros",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }            

        private void btn_frmPessoa_Alterar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Devolução Feita?", "Alterar Locação", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                locacao = new Locacao();
                livro = new Livro();
                pessoa = new Pessoa();
                locacao.LocacaoDataAluguel = DateTime.Today;
                locacao.LocacaoDataLimite = DateTime.Today.AddDays(10);


                livro.IdLivro = Convert.ToInt16(txt_CodLivro_Locacao.Text);

                try
                {
                    locacao.LocacaoLivro = LivroDAO.VerificarLivroPorCod(livro);
                }
                catch
                {
                    MessageBox.Show("Livro Não Encontrado", "Livro",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                }


                pessoa.PessoaCpf = txt_CpfPessoa_Locacao.Text;

                try
                {
                    locacao.LocacaoPessoa = PessoaDAO.VerificarPessoaPorCPF(pessoa);
                }
                catch
                {
                    MessageBox.Show("asjdlkajsd", "Livro",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                }

                if (txt_Situacao.Text == "Alugado")
                {
                    locacao.LocacaoStatus = true;
                }
                else
                {
                    locacao.LocacaoStatus = false;
                }

                if (LocacaoDAO.AlterarLocacao(locacao))
                {
                    MessageBox.Show("Gravado com sucesso!", "Locação",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possível gravar!", "Locação",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                }
                
                
            }
            
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

    }
}

//if ()
//            {
//                try
//                {
//                    locacao.LocacaoLivro = LivroDAO.VerificarLivroPorCod(livro);
//                }
//                catch
//                {
//                    MessageBox.Show("Livro Não Encontrado", "Livro",
//                    MessageBoxButton.OK, MessageBoxImage.Error);
//                }
//            }          


//            pessoa.PessoaCpf = txt_CpfPessoa_Locacao.Text;

//            try
//            {
//                locacao.LocacaoPessoa = PessoaDAO.VerificarPessoaPorCPF(pessoa);
//            }
//            catch
//            {
//                MessageBox.Show("asjdlkajsd", "Livro",
//                MessageBoxButton.OK, MessageBoxImage.Error);
//            }

            

//            if (LocacaoDAO.AdicionarLocacao(locacao))
//            {
//                MessageBox.Show("Gravado com sucesso!", "Locação",
//                MessageBoxButton.OK, MessageBoxImage.Information);
//            }
//            else
//            {
//                MessageBox.Show("Não foi possível gravar!", "Locação",
//                MessageBoxButton.OK, MessageBoxImage.Error);
//            }
