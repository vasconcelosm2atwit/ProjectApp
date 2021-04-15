using System;
using System.Windows;
using System.Windows.Controls;

namespace ConferenceProjectWPF.UI

    /// <summary>
    /// 
    /// ATTENDANCE PAGE SETUP
    /// - SHOW ATTENDANCE GRID
    /// - ADD COUNT TO EACH ATTENDANCE
    /// - UPDATE COOUNT FOR EACH ATTENDANCE
    /// 
    /// </summary>
{
    public partial class AttendancePage : Page
    {
        AttendanceViewModel attendanceViewModel = new AttendanceViewModel(); // STARTS DATA VIEW
        // HOLDS CURRENT AMMOUNT
        int oldBegAmount; 
        int oldMedAmount;
        int oldEndAmount;
        public AttendancePage()
        {
            InitializeComponent();

            this.DataContext = attendanceViewModel; // LINK PAGE TO DATA
            // ADDING AN EMPTY DATA TO THE COMBO BOX TO ALLOW RESET
            TimeSlot tm = new TimeSlot(); 
            attendanceViewModel.timeslots.Add(tm);

            // ADD TIMESLOTS TO COMBOBOX
            TimeslotCB.ItemsSource = attendanceViewModel.timeslots;
        }

        /// <summary>
        /// ADDING OR UPDATING COUNT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void countGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            Attendance temp = (Attendance)e.Row.Item;
            Console.WriteLine(temp.Count_beg);
            if(temp.Count_beg > temp.Capacity || temp.Count_mid > temp.Capacity || temp.Count_end > temp.Capacity)
            {
                MessageBox.Show("Count cannot be bigger than Capacity. Room Capacity: " + temp.Capacity);
                temp.Count_beg = oldBegAmount;
                temp.Count_mid = oldMedAmount;
                temp.Count_end = oldEndAmount;
            }
            else
            {
                attendanceViewModel.updateAttendance(temp);
            }
        }

        private void countGrid_BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
        {
            Attendance temp = (Attendance) e.Row.Item;
            oldBegAmount = temp.Count_beg;
            oldMedAmount = temp.Count_mid;
            oldEndAmount = temp.Count_end;
        }
    }
}
