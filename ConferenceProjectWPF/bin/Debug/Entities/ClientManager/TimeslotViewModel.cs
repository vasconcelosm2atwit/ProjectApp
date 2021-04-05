
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

        public bool UpdateItem(TimeSlot timeslot)
        {
            bool isError = false;
            try
            {
                db.updateTimeSlot(timeslot);
            }
            catch (Exception ex)
            {
                isError = true;
                Console.WriteLine(ex);
                Console.WriteLine("Failed to update the Database ---  check error ABOVE");
            }
            return isError;
        }
        public bool DeleteItem()
        {
            
            bool isError = false;
            try
            {
                db.deleteTimeSlot(this.SelectedTimeslot);
            }
            catch (Exception ex)
            {
                isError = true;
                Console.WriteLine(ex);
                Console.WriteLine("Failed to update the Database ---  check error ABOVE");
            }
            TimeSlots.Remove(this.SelectedTimeslot);
            return isError;
        }

        public bool CreateTimeSlot(TimeSlot timeSlot)
        {
            
            bool isError = false;

            try
            {
                db.addTimeSlot(timeSlot);
            }
            catch (Exception ex)
            {
                isError = true;
                Console.WriteLine(ex);
                Console.WriteLine("Failed to update the Database ---  check error ABOVE");
            }
            TimeSlots.Add(timeSlot);
            return isError;

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
