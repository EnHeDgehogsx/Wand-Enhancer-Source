using System.Windows;
using WandEnhancer.Core.Services;

namespace WandEnhancer
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            LocalizationManager.Initialize();
            MainWindow.Show();
        }

        public new static void Shutdown()
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                Application.Current.Shutdown();
            });
        }
    }
}