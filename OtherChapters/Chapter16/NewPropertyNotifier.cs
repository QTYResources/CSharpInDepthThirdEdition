using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Chapter16
{
    [Description("Listing 16.6")]
    class NewPropertyNotifier : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int firstValue;
        public int FirstValue
        {
            get { return firstValue; }
            set
            {
                if (value != firstValue)
                {
                    firstValue = value;
                    NotifyPropertyChanged();
                }
            }
        }

        // Other properties with the same pattern

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
