using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampApp
{   //sessions
    class Sessions
    {
        private String title;
        private int timeSlots_id;
        private int room_id;
        private int speaker_id;
        private String date;

        public string Title { get { return title; } set { title = value; } }
        public int TimeSlots { get { return timeSlots_id; } set { timeSlots_id = value; } }
        public int Room { get { return room_id; } set { room_id = value; } }
        public int Speaker { get { return speaker_id; } set { speaker_id = value; } }
    }
}

