
using System.ComponentModel;

namespace ConferenceProjectWPF
{
    class Model : INotifyPropertyChanged
    {
        // ObservableCollection<TimeSlot> ListOfSlots;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void onPropertyChanged(string info)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        
    }
}
