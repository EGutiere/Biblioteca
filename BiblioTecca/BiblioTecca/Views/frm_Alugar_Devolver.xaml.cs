using System;
using System.Windows;
using System.Windows.Controls;
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
            txt_Data_Limite_Devolucao.Text = Convert.ToString(DateTime.Today.AddDays(10));
        }

        private void txt_IdLivro_Buscar_TextChanged(object sender, TextChangedEventArgs e)
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

        private void btn_fmr_Livros_Alugar_Devolver_Locar_Click(object sender, RoutedEventArgs e)
        {
            locacao = new Locacao();

            l = new Livro();
            l.IdLivro = Convert.ToInt32(txt_IdLivro_Buscar.Text);
            l = LivroDAO.VerificarLivroPorCod(l);

            p = new Pessoa();
            p.PessoaCpf = txt_CpfPessoa_Locacao.Text;
            p = PessoaDAO.VerificarPessoaPorCPF(p);

            try
            {
                locacao.LocacaoLivro = l;
                locacao.LocacaoPessoa = p;
                locacao.LocacaoDataAluguel = DateTime.Today;
                locacao.LocacaoDataLimite = Convert.ToDateTime(txt_Data_Limite_Devolucao.Text);
                locacao.LocacaoStatus = true;

                if (l.LivroStatus)
                {
                    l.LivroStatus = false;
                    LivroDAO.AlterarLivro(l);
                    LocacaoDAO.AdicionarLocacao(locacao);
                    MessageBox.Show("Locação realizada com sucesso " + "Código de locação: " + locacao.IdLocacao.ToString(), "Locação",
                    MessageBoxButton.OK, MessageBoxImage.Warning);

                    txt_IdLivro_Buscar.Text = "0";
                    txt_IdLocacao_Buscar.Clear();
                    txt_CpfPessoa_Locacao.Text = "0";
                    txt_CpfPessoa_Locacao.Clear();
                }
                else
                {
                    MessageBox.Show("Livro Indisponível", "Locação",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Favor preencher os campos", "Locação",
                MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void txt_IdLocacao_Buscar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_IdLocacao_Buscar.Text))
            {
                locacao = new Locacao();
                locacao.IdLocacao = Convert.ToInt32(txt_IdLocacao_Buscar.Text);
                locacao = LocacaoDAO.BuscarLocacaoPorId(locacao);

                try
                {
                    txt_IdLivro_Buscar.Text = Convert.ToString(locacao.LocacaoLivro.IdLivro);

                    txt_CpfPessoa_Locacao.Text = locacao.LocacaoPessoa.PessoaCpf;
                }
                catch (Exception)
                {
                    txt_IdLivro_Buscar.Text = "0";
                    txt_IdLocacao_Buscar.Clear();
                    txt_CpfPessoa_Locacao.Text = "0";
                    txt_CpfPessoa_Locacao.Clear();

                }
            }
        }

        private void btn_fmr_Livros_Alugar_Devolver_Devolver_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_IdLocacao_Buscar.Text))
            {
                locacao = new Locacao();
                locacao.IdLocacao = Convert.ToInt32(txt_IdLocacao_Buscar.Text);
                locacao = LocacaoDAO.BuscarLocacaoPorId(locacao);

                try
                {
                    locacao.LocacaoDataDevolucao = Convert.ToDateTime(txt_Data_Devolucao.Text);
                    if (locacao.LocacaoStatus)
                    {
                        l.LivroStatus = true;
                        LivroDAO.AlterarLivro(l);
                        locacao.LocacaoStatus = false;
                        LocacaoDAO.AlterarLocacao(locacao);
                        MessageBox.Show("Devolução realizada com sucesso", "Locação",
                        MessageBoxButton.OK, MessageBoxImage.Warning);

                        txt_IdLivro_Buscar.Text = "0";
                        txt_IdLocacao_Buscar.Clear();
                        txt_CpfPessoa_Locacao.Text = "0";
                        txt_CpfPessoa_Locacao.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Devolução já realizada", "Locação",
                        MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
                catch (Exception)
                {
                    txt_IdLivro_Buscar.Text = "0";
                    txt_IdLocacao_Buscar.Clear();
                    txt_CpfPessoa_Locacao.Text = "0";
                    txt_CpfPessoa_Locacao.Clear();

                }
            }
        }
    }
}