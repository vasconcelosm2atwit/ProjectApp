using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;


namespace ConferenceProjectWPF
{
    /// <summary>
    /// 
    /// HOME PAGE, THIS IS RESPONSIBLE FOR SHOWING THE CARDS FOR EACH CURRENT SESSIONS
    /// BUTTONS IMPLEMENT COUNTS WHEN CLICKED
    /// 
    /// </summary>
    public partial class HomePage : Page
    {
        SessionViewModel sessionViewModel; // SESSION DATA MODEL
        public HomePage()
        {
            InitializeComponent();
            sessionViewModel = new SessionViewModel(); 
            this.DataContext = sessionViewModel;

            List<Session> session1 = new List<Session>(); // 9:00 AM to 12:00 PM
            List<Session> session2 = new List<Session>(); // 12:00 AM to 3:00 PM 
            List<Session> session3 = new List<Session>(); // 3:00 PM +

            foreach(Session s in sessionViewModel.Sessions)
            {
                if(s.Timeslot_1.Equals("9:00 AM - 10:00 AM") || s.Timeslot_1.Equals("10:00 AM - 11:00 AM") || s.Timeslot_1.Equals("11:00 AM - 12:00 PM"))
                {
                    session1.Add(s);
                }
                else if (s.Timeslot_1.Equals("10:00 AM - 11:59 AM") || s.Timeslot_1.Equals("1:00 PM - 2:00 PM") || s.Timeslot_1.Equals("2:00 PM - 3:00 PM"))
                {
                    session2.Add(s);
                }
                else
                {
                    session3.Add(s);
                }
            }


            Card1.ItemsSource = session1; // START CARD 1
            Card2.ItemsSource = session2; // START CARD 2
            Card3.ItemsSource = session3; // START CARD 3

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyDialogHost.IsOpen = true;
        }
        private void Button_confirm_edit(object sender, RoutedEventArgs e)
        {
            MyDialogHost.IsOpen = false;
        }
        private void Button_cancel_edit(object sender, RoutedEventArgs e)
        {
            MyDialogHost.IsOpen = false;
        }
    }
}
