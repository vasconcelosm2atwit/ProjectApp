using System;


namespace ConferenceProjectWPF
{
    class Session
    {
        private string title; 
        private int timeSlots_id;
        private string timeslot; // START.TIME - END.TIME
        private string timeslot_combo;
        private int room_id;
        private string room;
        private int speaker_id;
        private string speaker;
        private string date;
        private DateTime realDate;
        private int id;

        public int Id { get { return id; } set { id = value; } }
        public string Title { get { return title; } set { title = value; } }
        public int TimeSlots { get { return timeSlots_id; } set { timeSlots_id = value; } }
        public int Room { get { return room_id; } set { room_id = value; } }
        public int Speaker { get { return speaker_id; } set { speaker_id = value; } }
        public string Date { get { return date; } set { date = value; } }
        public DateTime RealDate { get { return realDate; } set { realDate = value; } }
        public string Timeslot_1 { get { return timeslot; } set { timeslot = value; } }
        public string Timeslot_combo { get { return timeslot_combo; } set { timeslot_combo = value; } }
        public string Room_1 { get { return room; } set { room = value; } }
        public string Speaker_1 { get { return speaker; } set { speaker = value; } }

    }
}
