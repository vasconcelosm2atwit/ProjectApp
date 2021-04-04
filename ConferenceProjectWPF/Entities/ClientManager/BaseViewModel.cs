using ConferenceProjectWPF.Controllers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceProjectWPF.Entities
{
    class BaseViewModel : TimeslotViewModel
    {
        public ObservableCollection<TimeSlot> Items { get; set; }

        public BaseViewModel()
        {
            //TimeslotViewModel n = new TimeslotViewModel();
            this.Items = timeSlotList;
            
        }
    }
}
