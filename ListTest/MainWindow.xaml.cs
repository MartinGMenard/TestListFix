using ListTest.Models;
using ListTest.Repository;
using System.Windows;


namespace ListTest
{
    public partial class MainWindow : Window
    {
        private readonly IFakeSqlRepository _fakeSqlRepository;
        private readonly MainViewModel _vm = new();

        public MainWindow(IFakeSqlRepository fakeSqlRepository)
        {
            InitializeComponent();
            _fakeSqlRepository = fakeSqlRepository;
            DataContext = _vm;
        }
        private async void Refresh_Click(object sender, RoutedEventArgs e)
        {
            await RefreshAsync();
        }


        public async Task RefreshAsync()
        {
            _vm.IsLoading = true;

            try
            {
                await Application.Current.Dispatcher.InvokeAsync(() => { }, System.Windows.Threading.DispatcherPriority.Render);
                var rows = _fakeSqlRepository.FetchData();

                _vm.Orders = rows;
            }
            finally
            {
                _vm.IsLoading = false;
            }
        }
    }
}