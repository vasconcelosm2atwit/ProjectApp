namespace ConferenceProjectWPF
{
    /// <summary>
    /// 
    /// ATTENDANCE ENTITIES
    /// 
    /// </summary>
    class Attendance
    {
        private int id;
        private int count_beg;
        private int count_mid;
        private int count_end;
        private int session_id;
        private string session_title;
        private string session_room;
        private string session_speaker;
        private string timeslot;
        private string date;
        private int capacity;

        public int Id { get { return id; } set { id = value; } }
        public int Count_beg { get { return count_beg; } set { count_beg = value; } }
        public int Count_mid { get { return count_mid; } set { count_mid = value; } }
        public int Count_end { get { return count_end; } set { count_end = value; } }
        public int Session_id { get { return session_id; } set { session_id = value; } }
        public string Session_title { get { return session_title; } set { session_title = value; } }
        public string Session_room { get { return session_room; } set { session_room = value; } }
        public string Session_speaker { get { return session_speaker; } set { session_speaker = value; } }
        public string Timeslot { get { return timeslot; } set { timeslot = value; } }
        public string Date { get { return date; } set { date = value; } }
        public int Capacity { get { return capacity; } set { capacity = value; } }
        




    }
}
