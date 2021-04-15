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
    /// Interaction logic for SessionPage.xaml
    /// </summary>
    public partial class SessionPage : Page
    {
        // Date, timeslot, title, room, speaker
        string holdDate;
        string holdTimeSlot;
        string holdTitle;
        string holdRoom;
        string holdSpeaker;
        SessionViewModel sessionViewModel = new SessionViewModel();

        public SessionPage()
        {
            InitializeComponent();

            this.DataContext = sessionViewModel;
           // timeslotComboBox.ItemsSource = sessionViewModel.AvailableTimeSlots;
            //speakerComboBox.ItemsSource = sessionViewModel.AvailableSpeakers;

            
        }


        private void Button_open_edit(object sender, RoutedEventArgs e)
        {
            holdDate = sessionViewModel.SelectedItem.Date;
            holdTimeSlot = sessionViewModel.SelectedItem.Timeslot_1;
            holdTitle = sessionViewModel.SelectedItem.Title;
            holdRoom = sessionViewModel.SelectedItem.Room_1;
            holdSpeaker = sessionViewModel.SelectedItem.Speaker_1;


            MyDialogHost.IsOpen = true;
        }

        private void Button_confirm_edit(object sender, RoutedEventArgs e)
        {

            if (sessionViewModel.SelectedItem.Date.Length != 0 && sessionViewModel.SelectedItem.Timeslot_1.Length != 0 &&
                sessionViewModel.SelectedItem.Title.Length != 0 && sessionViewModel.SelectedItem.Speaker_1.Length != 0 &&
                sessionViewModel.SelectedItem.Room_1.Length != 0
                )
            {

                // check if there is already a session going on the new room being edited to
                // check newRoom == anotherRoom timeslot and date

                //datePicker1
                //timeslotComboBox
                //roomComboBox
                //speakerComboBox
                //titleTextBox

                

                Session a = sessionViewModel.SelectedItem;

                
                if (sessionViewModel.checkIfExists(sessionViewModel.SelectedItem))
                {

                    MessageBox.Show("This Room is taken on this timeslot and Date");
                    return;

                }

                sessionViewModel.EditSession(sessionViewModel.SelectedItem);
                MyDialogHost.IsOpen = false;



            }
            else
            {

                MessageBox.Show("Fields cannot be empty");

            }

        }

        private void Button_cancel_edit(object sender, RoutedEventArgs e)
        {
            /**string holdDate;
        string holdTimeSlot;
        string holdTitle;
        string holdRoom;
        string holdSpeaker;*/
            sessionViewModel.SelectedItem.Date = holdDate;
            sessionViewModel.SelectedItem.Timeslot_1 = holdTimeSlot;
            sessionViewModel.SelectedItem.Title = holdTitle;
            sessionViewModel.SelectedItem.Room_1 = holdRoom;
            sessionViewModel.SelectedItem.Speaker_1= holdSpeaker;

            CollectionViewSource.GetDefaultView(sessionViewModel.Sessions).Refresh(); //Refresh current List

            MyDialogHost.IsOpen = false;
        }

        private void Button_open_delete(object sender, RoutedEventArgs e)
        {

            deletePopUp.IsOpen = true;
        }

        private void Button_confirm_delete(object sender, RoutedEventArgs e)
        {


            if (sessionViewModel.SelectedItem != null)
            {
                sessionViewModel.DeleteItem();
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
            // IF SELECTED ITEM IS NULL THEN ADD IT TO SPEAKER
            Speaker speaker = (Speaker) newSpeakerComboBox.SelectedItem;
            TimeSlot timeSlot = (TimeSlot) newTimeslotComboBox.SelectedItem;
            Room room = (Room) newRoomComboBox.SelectedItem;
            Console.WriteLine(newSpeakerComboBox.Text);
            Session newSession = new Session();
            newSession.Room = room.Id;
            newSession.Room_1 = room.Name;

            if(speaker != null) 
            {
                newSession.Speaker = speaker.Id;
                newSession.Speaker_1 = speaker.Name;
            }
            else
            {
               
                newSession.Speaker_1 = newSpeakerComboBox.Text;
                Speaker newSpeaker = new Speaker(newSpeakerComboBox.Text);
                SpeakerDatabaseManager sp = new SpeakerDatabaseManager();
                sp.addSpeaker(newSpeaker);
                List<Speaker> allSps = new List<Speaker>(sp.retrieveSpeakers());
                foreach(Speaker i in allSps)
                {
                    if (i.Name.Equals(newSession.Speaker_1))
                    {
                        newSession.Speaker = i.Id;
                    }
                }
            }

            
            newSession.TimeSlots = timeSlot.Id;
            newSession.Timeslot_1 = timeSlot.ConcatTimeSlot;
            newSession.Title = newTitleTextBox.Text;
            newSession.Date = newDate.Text;

            if (sessionViewModel.checkIfExists(newSession))
            {

                MessageBox.Show("This Room is taken on this timeslot and Date");
                return;
                
            }
            AttendanceDatabaseManager ad = new AttendanceDatabaseManager();
            Attendance attendance = new Attendance();
            sessionViewModel.creatingSessions(newSession);

            SessionsDatabaseManager sd = new SessionsDatabaseManager();
            foreach(Session s in sd.getSessions())
            {
               if(newSession.TimeSlots == s.TimeSlots && newSession.Speaker == s.Speaker)
               {
                        Console.WriteLine("NAME" + s.Speaker_1);
                        attendance.Session_id = s.Id;
               }
            }
            

            Console.WriteLine("aa " + attendance.Session_id);

            attendance.Count_beg = 0;
            attendance.Count_mid = 0;
            attendance.Count_end = 0;

            ad.addCount(attendance);



            // timeslot
            // speaker
            // title
            // date
            // room

            
            createDialogHost.IsOpen = false;
        }

        private void Button_cancel_creation(object sender, RoutedEventArgs e)
        {
            createDialogHost.IsOpen = false;
        }

        private void timeslotComboBox_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
