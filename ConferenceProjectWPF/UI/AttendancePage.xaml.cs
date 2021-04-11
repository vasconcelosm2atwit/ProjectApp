using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ConferenceProjectWPF.UI
{
    /// <summary>
    /// Interaction logic for AttendancePage.xaml
    /// </summary>
    public partial class AttendancePage : Page
    {
        AttendanceViewModel attendanceViewModel = new AttendanceViewModel();
        public AttendancePage()
        {
            InitializeComponent();

            this.DataContext = attendanceViewModel;
           
            TimeslotCB.ItemsSource = attendanceViewModel.timeslots;
           // attendanceViewModel.SelectedItem = attendanceViewModel.Attendances[0];
            //TimeslotCB.SelectedItem = attendanceViewModel.timeslots[1].ConcatTimeSlot;


        }

        private void DataGridTextColumn_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            Console.WriteLine("left");
        }

        private void DataGridTextColumn_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("left");
        }

        private void countGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            Console.WriteLine(attendanceViewModel.SelectedItem.Count_beg);
        }

        private void countGrid_CurrentCellChanged(object sender, EventArgs e)
        {
           // Console.WriteLine(attendanceViewModel.SelectedItem.Count_beg);
        }

        private void countGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
           // Console.WriteLine("Starting update");
           // Console.WriteLine(attendanceViewModel.SelectedItem.Count_beg);
            Attendance a = (Attendance)e.Row.Item;
            Console.WriteLine(" end ->" + a.Count_beg + " - " + a.Count_mid + " - " + a.Count_end);
            attendanceViewModel.updateAttendance(attendanceViewModel.SelectedItem);
        }

        private void countGrid_BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
        {
            
          //  Console.WriteLine(attendanceViewModel.SelectedItem.Count_beg);
           // Console.WriteLine("Ending update");
            Attendance a = (Attendance) e.Row.Item;
            Console.WriteLine( " beg ->" + a.Count_beg + " - " + a.Count_mid + " - " + a.Count_end);

        }
    }
}
