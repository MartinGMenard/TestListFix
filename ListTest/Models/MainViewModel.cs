
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ListTest.Models
{
    public sealed class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private bool _isLoading;
        public bool IsLoading
        {
            get => _isLoading;
            set { _isLoading = value; OnPropertyChanged(); }
        }

        public List<OrderRow> Orders { get;  set; } = new();

        private void OnPropertyChanged([CallerMemberName] string? name = null)=> PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
