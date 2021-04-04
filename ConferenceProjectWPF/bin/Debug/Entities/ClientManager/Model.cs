
using System.ComponentModel;

namespace ConferenceProjectWPF
{
    class Model : INotifyPropertyChanged
    {
       // ObservableCollection<TimeSlot> ListOfSlots;

        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };
        
    }
}
