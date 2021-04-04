using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceProjectWPF.Entities
{
    class TimeSlot
    {
            private int id;
            private string start_time;
            private string end_time;

            public int Id { get { return id; } set { id = value; } }
            public string Start_time { get { return start_time; } set { start_time = value;  } }
            public string End_time { get { return end_time; } set { end_time = value; } }

       // public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };
    }
}
