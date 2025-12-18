using ListTest.Repository;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;

namespace ListTest
{
    public partial class App : Application
    {
        public IServiceProvider Services { get; private set; } = null!;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var services = new ServiceCollection();

            services.AddSingleton<IFakeSqlRepository, FakeSqlRepository>();
            services.AddSingleton<MainWindow>();

            Services = services.BuildServiceProvider();
            var mainWindow = Services.GetRequiredService<MainWindow>();

            MainWindow = mainWindow;
            ShutdownMode = ShutdownMode.OnMainWindowClose;

            mainWindow.Show();
        }
    }
}
