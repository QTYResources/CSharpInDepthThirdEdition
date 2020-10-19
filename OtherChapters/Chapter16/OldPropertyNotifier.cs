using System.ComponentModel;

namespace Chapter16
{
    [Description("Listing 16.5")]
    class OldPropertyNotifier : INotifyPropertyChanged
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
                    NotifyPropertyChanged("FirstValue");
                }
            }
        }

        // Other properties with the same pattern

        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
