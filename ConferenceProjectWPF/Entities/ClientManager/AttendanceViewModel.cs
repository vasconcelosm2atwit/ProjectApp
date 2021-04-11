
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;

namespace ConferenceProjectWPF
{
    class AttendanceViewModel : Model
    {
        public ObservableCollection<Attendance> Attendances { get; set; }

        public List<TimeSlot> timeslots { get; set; }

        readonly AttendanceDatabaseManager db;
        public ICollectionView AttendanceCollection { get; set; }
        public Attendance SelectedItem { get; set; }

        private string _attendanceFilter = string.Empty;

        private bool _IsChanged;
        public bool IsChanged
        {
            get { return _IsChanged; }
            set { _IsChanged = value; onPropertyChanged(nameof(IsChanged)); }
        }

        public string AttendanceFilter
        {
            get
            {
                return _attendanceFilter;
            }
            set
            {
                _attendanceFilter = value;
                onPropertyChanged(nameof(AttendanceFilter));
                AttendanceCollection.Refresh();
            }
        }

        public AttendanceViewModel()
        {
            db = new AttendanceDatabaseManager();
            this.Attendances = new ObservableCollection<Attendance>(db.RetrieveCount());
            this.AttendanceCollection = CollectionViewSource.GetDefaultView(this.Attendances);
            TimeSlotsDatabaseManager ts = new TimeSlotsDatabaseManager();
            timeslots = new List<TimeSlot>(ts.retrieveTimeSlots());

           

           // AttendanceCollection.Filter = post => AttendanceFilter == null || AttendanceFilter == ((Attendance)post).Timeslot;

            AttendanceCollection.Filter = FilterAttendance;

            //Console.WriteLine(FilterAttendance);
        }

        

        public bool updateAttendance(Attendance attendance)
        {
            bool isError = false;
            try
            {
                db.updateCount(attendance);
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
            //    db.deleteRoom(this.SelectedItem);
            }
            catch (Exception ex)
            {
                isError = true;
                Console.WriteLine(ex);
                Console.WriteLine("Failed to update the Database ---  check error ABOVE");
            }
           Attendances.Remove(this.SelectedItem);
            return isError;

        }

        public bool CreateAttendance(Attendance attendance)
        {
            Attendances.Add(attendance);
            bool isError = false;
            try
            {
                db.addCount(attendance);
            }
            catch (Exception ex)
            {
                isError = true;
                Console.WriteLine(ex);
                Console.WriteLine("Failed to update the Database ---  check error ABOVE");
            }
            return isError;

        }

        private bool FilterAttendance(object obj)
        {
            if (obj is Attendance attendance)
            {
                return attendance.Timeslot.Contains(AttendanceFilter);
            }
            return false;
        }

        
    }
}
