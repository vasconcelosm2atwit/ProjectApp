using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceProjectWPF.Entities
{
    class Model : INotifyPropertyChanged
    {
       // ObservableCollection<TimeSlot> ListOfSlots;

        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };
        
    }
}
