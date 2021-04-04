
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace ConferenceProjectWPF
{
    // handles the logic for timeslot
    class TimeslotViewModel : Model
    {
        public ObservableCollection<TimeSlot> TimeSlots { get; set; }
        TimeSlotsDatabaseManager db;

        public TimeSlot SelectedTimeslot { get; set; }

        public TimeslotViewModel()
        {
            db = new TimeSlotsDatabaseManager();
            this.TimeSlots = new ObservableCollection<TimeSlot>(db.retrieveTimeSlots());
        }

        public void DeleteItem()
        {
            db.deleteTimeSlot(this.SelectedTimeslot);
            TimeSlots.Remove(this.SelectedTimeslot);
        }

        public void CreateTimeSlot(TimeSlot timeSlot)
        {
            TimeSlots.Add(timeSlot);
            db.addTimeSlot(timeSlot);

        }

        public bool AlreadyExist(TimeSlot timeSlot)
        {
            foreach(TimeSlot t in TimeSlots)
            {  
                if(t.Start_time == timeSlot.Start_time && t.End_time == timeSlot.End_time)
                {
                    return true;
                }
            }

            return false;
            
        }

        public bool checkForDuplicates()
        {
            List<TimeSlot> copy = new List<TimeSlot>(TimeSlots);

            var dups = copy.GroupBy(i => new { i.Start_time, i.End_time }).Select(g => new
            {
                Length = g.Key.Start_time,
                Label = g.Key.End_time,
                Count = g.Count()
            }).Where(g => g.Count > 1);

            //Console.WriteLine(dups.Any());

            return dups.Any();
        }
        

        
    }
}
