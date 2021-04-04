using ConferenceProjectWPF.Controllers;
using ConferenceProjectWPF.Entities;
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
    public partial class SpeakerPage : Page
    {
        string holdOn;
        BaseViewModel bs;

        TimeSlotsDatabaseManager ts = new TimeSlotsDatabaseManager();
        public SpeakerPage()
        {
            InitializeComponent();
           bs = new BaseViewModel();
            this.DataContext = bs;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            holdOn = bs.SelectedTimeslot.Start_time;
            Console.WriteLine();
            MyDialogHost.IsOpen = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(bs.SelectedTimeslot.Start_time);
            Console.WriteLine(currentTimeStartTime.Text.Length);
            if (currentTimeStartTime.Text.Length == 0)
            {
               
                MessageBox.Show("Field Must be entered");
            }
            else
            {
                MyDialogHost.IsOpen = false;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            bs.SelectedTimeslot.Start_time = holdOn;
            CollectionViewSource.GetDefaultView(bs.Items).Refresh(); //Refresh current List
            MyDialogHost.IsOpen = false;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            
            deletePopUp.IsOpen = true;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

            if (bs.SelectedTimeslot != null)
            {
                ts.deleteTimeSlot(bs.SelectedTimeslot);
                bs.Items.Remove(bs.SelectedTimeslot);
            }
            else
            {
                return;
            }
            deletePopUp.IsOpen = false;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            deletePopUp.IsOpen = false;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            createDialogHost.IsOpen = true;
            
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {


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
                
                bs.Items.Add(timeSlot);
                ts.addTimeSlot(timeSlot);
                createDialogHost.IsOpen = false;

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

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            createDialogHost.IsOpen = false;
        }
    }

}
