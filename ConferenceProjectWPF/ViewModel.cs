using ConferenceProjectWPF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceProjectWPF
{
    class ViewModel
    {
        public IList<TimeSlot> timeSlots { get; set; }
        public IList<Room> allRooms { get; set; }

        public TimeSlot SelectedTimeslot { get; set; }
        public Room SelectedRoom { get; set; }

    }
}
