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
           this.Sessions = new ObservableCollection<Session>(db.retrieveSessions());
            
           this.SessionCollection = CollectionViewSource.GetDefaultView(this.Sessions);

           SessionCollection.Filter = FilterSpeakers;
        }

        public void creatingSessions()
        {

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
              //  db.updateSessions(session);
            }
            catch (Exception ex)
            {
                catchError = true;
                Console.WriteLine(ex);
                Console.WriteLine("Error sending to the database");
            }

            return catchError;
        }


    }
}
