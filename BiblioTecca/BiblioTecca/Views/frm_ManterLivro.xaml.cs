using System;
using System.Windows;
using BiblioTecca.DAL;
using BiblioTecca.Model;

namespace BiblioTecca.Views
{
    /// <summary>
    /// Interaction logic for frmManterLivro.xaml
    /// </summary>
    public partial class frm_ManterLivro : Window
    {
        private Livro l = new Livro();

        public frm_ManterLivro()
        {
            InitializeComponent();
        }

        private void btn_frmLivro_Buscar_Click(object sender, RoutedEventArgs e)
        {
            l = new Livro();
            if (!string.IsNullOrEmpty(txt_Titulo_buscar.Text))
            {
                l.LivroNome = txt_Titulo_buscar.Text;
                l = LivroDAO.VerificarLivroPorNome(l);
                if (l != null)
                {
                    txt_Titulo.Text = l.LivroNome;
                    txt_Coletanea.Text = l.LivroColetanea;
                    txt_Classificacao.Text = l.LivroClassificacao;
                    txt_IdLivro.Text = Convert.ToString(l.IdLivro);
                }
                else
                {
                    MessageBox.Show("Livro não encontrado!", "Cadastro de Livro",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Favor preencher o campo da busca", "Cadastro de Livro",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btn_frmLivro_Inserir_Click(object sender, RoutedEventArgs e)
        {
            l = new Livro();
            l.LivroNome = txt_Titulo.Text;
            l.LivroColetanea = txt_Coletanea.Text;
            l.LivroClassificacao = txt_Classificacao.Text;

            if (LivroDAO.AdicionarLivro(l))
            {
                MessageBox.Show("Gravado com sucesso!", "Cadastro de Livro",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Não foi possível gravar!", "Cadastro de Livro",
                MessageBoxButton.OK, MessageBoxImage.Error);
            }

            txt_Titulo.Text = "";
            txt_Titulo.Focus();
        }

        private void btn_frmLivro_Alterar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Deseja alterar o registro?", "Cadastro de Livro",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                l.LivroNome = txt_Titulo.Text;
                l.LivroColetanea = txt_Coletanea.Text;
                l.LivroClassificacao = txt_Classificacao.Text;

                if (LivroDAO.AlterarLivro(l))
                {
                    MessageBox.Show("Cliente alterado com sucesso", "Cadastra Livro", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Cliente não alterado!", "Cadastra Livro", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                DesabilitarBotoes();
            }
            else
            {
                DesabilitarBotoes();
            }
        }

        private void btn_frmLivro_Excluir_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Deseja remover o registro?", "Cadastro de Livro",
               MessageBoxButton.YesNo, MessageBoxImage.Question) ==
               MessageBoxResult.Yes)
            {
                if (LivroDAO.RemoverLivro(l))
                {
                    MessageBox.Show("Cliente removido com sucesso", "Cadastra Livro", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Cliente não removido!", "Cadastra Livro", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                DesabilitarBotoes();
            }
            else
            {
                DesabilitarBotoes();
            }
        }

        private void btn_frmLivro_Cancelar_Click(object sender, RoutedEventArgs e)
        {
            DesabilitarBotoes();
        }

        public void HabilitarBotoes()
        {
            btn_frmLivro_Inserir.IsEnabled = true;
            btn_frmLivro_Alterar.IsEnabled = true;
            btn_frmLivro_Excluir.IsEnabled = true;
            btn_frmLivro_Cancelar.IsEnabled = false;
        }

        public void DesabilitarBotoes()
        {
            btn_frmLivro_Inserir.IsEnabled = false;
            btn_frmLivro_Alterar.IsEnabled = false;
            btn_frmLivro_Excluir.IsEnabled = false;
            btn_frmLivro_Cancelar.IsEnabled = true;
            txt_Titulo_buscar.Clear();
            txt_Titulo.Clear();
            txt_Coletanea.Clear();
            txt_Classificacao.Clear();
            txt_Titulo_buscar.Focus();
        }
    }
}
