using System.ComponentModel;

namespace WpfApp_TwoWay_slider.viewModel
{
    public class Slider : INotifyPropertyChanged
    {
        private int _s;

        public int S
        {
            get { return _s; }
            set
            {
                if (_s != value)
                {
                    _s = value;
                    OnPropertyChanged(nameof(S));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
