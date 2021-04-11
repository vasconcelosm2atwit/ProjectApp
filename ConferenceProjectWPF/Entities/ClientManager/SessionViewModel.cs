using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using PhoneNumbers;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Data;

namespace ConferenceProjectWPF
{
    class SessionViewModel : Model
    {

        public ObservableCollection<Session> Sessions { get; set; }
        public List<Session> dbList { get; set; }
        public ObservableCollection<TimeSlot> AvailableTimeSlots { get; set; }
        public ObservableCollection<Speaker> AvailableSpeakers { get; set; }
        public ObservableCollection<Room> AvailableRooms { get; set; }

        public ICollectionView SessionCollection { get; set; }
        SessionsDatabaseManager db;

        private string _sessionFilter = string.Empty;

        public string SessionFilter
        {
            get
            {
                return _sessionFilter;
            }
            set
            {
                _sessionFilter = value;
                onPropertyChanged(nameof(SessionFilter));
                SessionCollection.Refresh();
            }
        }

        public Session SelectedItem { get; set; }

        public SessionViewModel()
        {
           db = new SessionsDatabaseManager();
           SessionTestData sessionTestData = new SessionTestData();
           this.Sessions = new ObservableCollection<Session>(db.getSessions());


           this.dbList = new List<Session>(db.retrieveSessions());


           this.SessionCollection = CollectionViewSource.GetDefaultView(this.Sessions);

            TimeSlotsDatabaseManager ts = new TimeSlotsDatabaseManager();
           this.AvailableTimeSlots = new ObservableCollection<TimeSlot>(ts.retrieveTimeSlots());
            
            this.AvailableSpeakers = new ObservableCollection<Speaker>(db.getAllSpeakers());

            this.AvailableRooms = new ObservableCollection<Room>(db.getAllRooms());

            SessionCollection.Filter = FilterSpeakers;
        }

        public int creatingSessions(Session session)
        {
            bool isError = false;

            try
            {
                
                db.addSession(session);
            }
            catch (Exception ex)
            {
                isError = true;
                Console.WriteLine(ex);
                Console.WriteLine("Failed to update the Database ---  check error ABOVE");
            }
            
            Sessions.Add(session);
            //return isError;

            foreach(Session s in db.retrieveSessions())
            {
                if(session.Title == s.Title)
                {
                    return s.Id;
                }
            }
            return -1;
        }


        private bool FilterSpeakers(object obj)
        {
            if (obj is Session session)
            {
               return session.Title.ToUpper().Contains(SessionFilter.ToUpper()) || session.Timeslot_1.ToUpper().Contains(SessionFilter.ToUpper()) ||
                    session.Room_1.ToUpper().Contains(SessionFilter.ToUpper()) || session.Speaker_1.ToUpper().Contains(SessionFilter.ToUpper());
            }
            return false;
        }

        public bool EditSession(Session session)
        {
            bool catchError = false;
            try
            {
                db.updateSessions(session);
            }
            catch (Exception ex)
            {
                catchError = true;
                Console.WriteLine(ex);
                Console.WriteLine("Error sending to the database");
            }

            return catchError;
        }

        public bool checkForDuplicates()
        {
            List<Session> copy = new List<Session>(Sessions);

            var dups = copy.GroupBy(i => new { i.Date, i.Timeslot_combo }).Select(g => new
            {
                Length = g.Key.Date,
                Label = g.Key.Timeslot_combo,
                Count = g.Count()
            }).Where(g => g.Count > 1);

            //Console.WriteLine(dups.Any());

            return dups.Any();
        }

        public bool DeleteItem()
        {

            bool isError = false;
            try
            {
                db.deleteSession(this.SelectedItem);
            }
            catch (Exception ex)
            {
                isError = true;
                Console.WriteLine(ex);
                Console.WriteLine("Failed to update the Database ---  check error ABOVE");
            }
            Sessions.Remove(this.SelectedItem);
            


            return isError;
        }

        public bool checkIfExists(Session s)
        {
            
            s.RealDate = DateTime.Parse(s.Date);
            foreach(Session i in dbList)
            { 
                i.RealDate = DateTime.Parse(i.Date);
                if ((s.Timeslot_1.Equals(i.Timeslot_1) && s.RealDate.Equals(i.RealDate)) &&  s.Room_1.Equals(i.Room_1))
                {
                   
                    return true;
                }
            }


            return false;
        }

        public bool IsRoomTaken(Session s)
        {
            foreach (Session i in dbList)
            {
                if (s.Room_1 == i.Room_1 && (s.Timeslot_1 == i.Timeslot_1 && s.Date == i.Date))
                {
                    return true;
                }
            }

            return false;
        }


    }
}
