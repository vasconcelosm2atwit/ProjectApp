using ConferenceProjectWPF.Controllers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ConferenceProjectWPF.Entities
{
    // handles the logic for timeslot
    class TimeslotViewModel : Model
    {
        public ObservableCollection<TimeSlot> timeSlotList { get; set; }

        public TimeSlot SelectedTimeslot { get; set; }

        public ICommand getListCommand { get; set; }

        public TimeslotViewModel()
        {
            fillList();
        }

        public void getList()
        {
            this.getListCommand = new RelayCommand(fillList);
        }
        private void fillList()
        {
            TimeSlotsDatabaseManager db = new TimeSlotsDatabaseManager();
            this.timeSlotList = new ObservableCollection<TimeSlot>(db.retrieveTimeSlots());
        }
        
        private void ClearList()
        {
            // clear items
            //this.timeSlotList = new ObservableCollection<TimeSlot>();
        }

        public void EditList(String newStartTime, String newEndTime)
        {
            this.SelectedTimeslot.Start_time = newStartTime;
        }
    }
}
