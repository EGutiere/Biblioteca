using System.Windows;

namespace BiblioTecca.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Menu_CRUD_Pessoa_Click(object sender, RoutedEventArgs e)
        {
            frm_ManterPessoa p = new frm_ManterPessoa();
            p.ShowDialog();
        }

        private void Menu_CRUDLivro_Click(object sender, RoutedEventArgs e)
        {
            frm_ManterLivro l = new frm_ManterLivro();
            l.ShowDialog();
        }

        private void Menu_Alugar_Devolver_Click(object sender, RoutedEventArgs e)
        {
            frm_Alugar_Devolver a = new frm_Alugar_Devolver();
            a.ShowDialog();
        }
    }
}
