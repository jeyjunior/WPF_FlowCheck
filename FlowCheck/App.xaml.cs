using FlowCheck.Application;
using System.Configuration;
using System.Data;
using System.Windows;

namespace FlowCheck
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {
        protected override async void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            try
            {
                Bootstrap.Iniciar();
                Configuracao.Iniciar();

                var mainWindow = new MainWindow();
                mainWindow.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao iniciar aplicação: {ex.Message}",
                               "Erro",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);
                Shutdown();
            }
        }
    }
}
