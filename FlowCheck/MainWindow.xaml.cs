using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FlowCheck.Views;

namespace FlowCheck
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new TarefaPage());
        }

        private void NavigateToTarefaPage(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new TarefaPage());
        }

        private void NavigateToAnotacaoPage(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AnotacaoPage());
        }
    }
}