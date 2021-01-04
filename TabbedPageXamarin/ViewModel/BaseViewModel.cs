using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace TabbedPageXamarin.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        private string _title { get; set; }

        public INavigation Navigation { get; set; }

        public BaseViewModel()
        {
        }
        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
