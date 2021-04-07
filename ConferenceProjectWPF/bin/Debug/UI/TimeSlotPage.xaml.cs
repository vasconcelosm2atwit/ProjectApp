using ConferenceProjectWPF;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for SpeakerPage.xaml
    /// </summary>
    public partial class TimeSlotPage : Page
    {
        string holdStart_time;
        string holdEnd_time;
        TimeslotViewModel timeSlotViewModel = new TimeslotViewModel();
        TimeSlotsDatabaseManager ts = new TimeSlotsDatabaseManager();
        public TimeSlotPage()
        {
            InitializeComponent();

            // Page data linked to TimeSlot
            this.DataContext = timeSlotViewModel;
        }

        private void Button_open_edit(object sender, RoutedEventArgs e)
        {
            holdStart_time = timeSlotViewModel.SelectedTimeslot.Start_time;
            holdEnd_time = timeSlotViewModel.SelectedTimeslot.End_time;

            MyDialogHost.IsOpen = true;
        }

        private void Button_confirm_edit(object sender, RoutedEventArgs e)
        {
            
            if(EditStartTime.Text.Length!=0 && EditEndTime.Text.Length != 0) 
            {
                if (timeSlotViewModel.checkForDuplicates())
                {
                    timeSlotViewModel.SelectedTimeslot.Start_time = holdStart_time;
                    timeSlotViewModel.SelectedTimeslot.End_time = holdEnd_time;
                    CollectionViewSource.GetDefaultView(timeSlotViewModel.TimeSlots).Refresh(); //Refresh current List
                    MessageBox.Show("You tried creating a duplicated");
                }

                timeSlotViewModel.UpdateItem(timeSlotViewModel.SelectedTimeslot);
                
                MyDialogHost.IsOpen = false;
            }
            else
            {
                MessageBox.Show("Fields cannot be empty");
            }
        }

        private void Button_cancel_edit(object sender, RoutedEventArgs e)
        {
            timeSlotViewModel.SelectedTimeslot.Start_time = holdStart_time;
            timeSlotViewModel.SelectedTimeslot.End_time = holdEnd_time;
            CollectionViewSource.GetDefaultView(timeSlotViewModel.TimeSlots).Refresh(); //Refresh current List
            MyDialogHost.IsOpen = false;
        }

        private void Button_open_delete(object sender, RoutedEventArgs e)
        {
            
            deletePopUp.IsOpen = true;
        }

        private void Button_confirm_delete(object sender, RoutedEventArgs e)
        {

            if (timeSlotViewModel.SelectedTimeslot != null)
            {
                timeSlotViewModel.DeleteItem();
                deletePopUp.IsOpen = false;
            }
            else
            {
                return;
            }
            
        }

        private void Button_cancel_delete(object sender, RoutedEventArgs e)
        {
            deletePopUp.IsOpen = false;
        }

        private void Button_open_createTimeSlot(object sender, RoutedEventArgs e)
        {
            createDialogHost.IsOpen = true;
            
        }

        private void Button_confirm_creation(object sender, RoutedEventArgs e)
        {

            if (StartTimePick.Text.Trim().StartsWith("0"))
            {
                StartTimePick.Text = StartTimePick.Text.Remove(0, 1);
            }


            TimeSlot timeSlot = new TimeSlot();
            timeSlot.Start_time = StartTimePick.Text;
            timeSlot.End_time = EndTimePick.Text;
            DateTime startTime = new DateTime();
            DateTime endTime = new DateTime();


            

            if (timeSlot.Start_time != null & timeSlot.End_time != null)
            {
                startTime = DateTime.Parse(timeSlot.Start_time);
                endTime = DateTime.Parse(timeSlot.End_time);
                if (endTime < startTime)
                {
                    Console.WriteLine(startTime.ToString());
                    MessageBox.Show("End Time cannot be earlier than Start Time");
                    return;
                }

                if (!timeSlotViewModel.AlreadyExist(timeSlot))
                {
                    timeSlotViewModel.CreateTimeSlot(timeSlot);
                    createDialogHost.IsOpen = false;
                }
                else
                {
                    MessageBox.Show("Item Already Exists");
                }
               
                

            }else
            {
                MessageBox.Show("Fields must be entered");
                return;

            }

            // DATE TIME TESTING STRINGS
            /**
           // String a = timePick.Text;
            String b = "12:00 PM";
            DateTime datetime = new DateTime();
            datetime = DateTime.Parse(b);
            DateTime datetime2 = new DateTime();
            //datetime2 = DateTime.Parse(timePick.Text);

            if(datetime > datetime2)
            {
             //   Console.WriteLine(a + " is bigger than " + b);
            }
            else
            {
              //  Console.WriteLine(b + " is bigger than " + a);
            }
            
            
                Console.WriteLine(datetime.Hour.ToString() + ":" + datetime.Minute.ToString());
            */
        }

        private void Button_cancel_creation(object sender, RoutedEventArgs e)
        {
            createDialogHost.IsOpen = false;
        }
    }

}
