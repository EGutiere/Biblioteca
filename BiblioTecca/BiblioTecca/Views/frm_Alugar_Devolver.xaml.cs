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
        private Livro l = new Livro();
        private Locacao locacao = new Locacao();
        private Pessoa p = new Pessoa();
        
        public frm_Alugar_Devolver()
        {
            InitializeComponent();

        }

        private void txt_IdLocacao_Buscar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_IdLivro_Buscar.Text))
            {                
                try
                {
                    l = new Livro();
                    l.IdLivro = Convert.ToInt32(txt_IdLivro_Buscar.Text);
                    l = LivroDAO.VerificarLivroPorCod(l);
                    txt_NomeLivro_Locacao.Text = l.LivroNome;
                    txt_ColetaneaLivro_Locacao.Text = l.LivroColetanea;
                    txt_LivroClassificacao_Locacao.Text = l.LivroClassificacao;

                    if (l.LivroStatus)
                    {
                        txt_Situacao.Text = "Disponível";
                    }
                    else
                    {
                        txt_Situacao.Text = "Indisponível";
                    }
                }
                catch (Exception)
                {
                    txt_NomeLivro_Locacao.Text = "";
                    txt_ColetaneaLivro_Locacao.Text = "";
                    txt_LivroClassificacao_Locacao.Text = "";
                    txt_Situacao.Text = "Indisponível";
                }
            }
        }

        private void txt_CpfPessoa_Locacao_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_CpfPessoa_Locacao.Text))
            {
                p = new Pessoa();
                p.PessoaCpf = txt_CpfPessoa_Locacao.Text;
                p = PessoaDAO.VerificarPessoaPorCPF(p);

                try
                {
                    txt_NomePessoa_Locacao.Text = p.PessoaNome;
                    txt_CpfPessoa_Locacao.Text = p.PessoaCpf;
                }
                catch (Exception)
                {                    
                    txt_NomePessoa_Locacao.Text = "";                 
                }
            }
        }




        //private void btn_frmEmprestimo_Buscar_Click(object sender, RoutedEventArgs e)
        //{
        //    l = new Livro();
        //    if (!string.IsNullOrEmpty(txt_IdLocacao_Buscar.Text))
        //    {
        //        l.IdLivro = Convert.ToInt32(txt_IdLocacao_Buscar.Text);
        //        l = LivroDAO.VerificarLivroPorCod(l);
        //        if (l != null)
        //        {
        //            txt_NomeLivro_Locacao.Text = l.LivroNome;

        //        }
        //        else
        //        {
        //            MessageBox.Show("Livro não encontrado!", "Cadastro de Livro",
        //            MessageBoxButton.OK, MessageBoxImage.Information);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Favor preencher o campo da busca", "Cadastro de Livro",
        //        MessageBoxButton.OK, MessageBoxImage.Information);
        //    }
        //}            

        //private void btn_frmPessoa_Alterar_Click(object sender, RoutedEventArgs e)
        //{
        //    if (MessageBox.Show("Devolução Feita?", "Alterar Locação", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
        //    {
        //        locacao = new Locacao();
        //        livro = new Livro();
        //        pessoa = new Pessoa();
        //        locacao.LocacaoDataAluguel = DateTime.Today;
        //        locacao.LocacaoDataLimite = DateTime.Today.AddDays(10);


        //        livro.IdLivro = Convert.ToInt16(txt_CodLivro_Locacao.Text);

        //        try
        //        {
        //            locacao.LocacaoLivro = LivroDAO.VerificarLivroPorCod(livro);
        //        }
        //        catch
        //        {
        //            MessageBox.Show("Livro Não Encontrado", "Livro",
        //            MessageBoxButton.OK, MessageBoxImage.Error);
        //        }


        //        pessoa.PessoaCpf = txt_CpfPessoa_Locacao.Text;

        //        try
        //        {
        //            locacao.LocacaoPessoa = PessoaDAO.VerificarPessoaPorCPF(pessoa);
        //        }
        //        catch
        //        {
        //            MessageBox.Show("asjdlkajsd", "Livro",
        //            MessageBoxButton.OK, MessageBoxImage.Error);
        //        }

        //        if (txt_Situacao.Text == "Alugado")
        //        {
        //            locacao.LocacaoStatus = true;
        //        }
        //        else
        //        {
        //            locacao.LocacaoStatus = false;
        //        }

        //        if (LocacaoDAO.AlterarLocacao(locacao))
        //        {
        //            MessageBox.Show("Gravado com sucesso!", "Locação",
        //            MessageBoxButton.OK, MessageBoxImage.Information);
        //        }
        //        else
        //        {
        //            MessageBox.Show("Não foi possível gravar!", "Locação",
        //            MessageBoxButton.OK, MessageBoxImage.Error);
        //        }


        //    }

        //}

        //private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        //{

        //}

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
