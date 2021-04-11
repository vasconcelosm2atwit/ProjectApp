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

namespace ConferenceProjectWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Main.Content = new HomePage();
        }
        private void Btn_homeClick(object sender, RoutedEventArgs e)
        {
            Main.Content = new HomePage();
        }

        private void Btn_rooms(object sender, RoutedEventArgs e)
        {
            Main.Content = new UI.RoomPage();
        }

        private void btn_sessions(object sender, RoutedEventArgs e)
        {
            Main.Content = new UI.SessionPage();
        }

        private void btn_speakers(object sender, RoutedEventArgs e)
        {
            Main.Content = new UI.SpeakerPage();
        }

        public void btn_timeSlots(object sender, RoutedEventArgs e)
        {
            Main.Content = new UI.TimeSlotPage();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new UI.SpeakerPage();
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new UI.AttendancePage();
        }

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            Main.Content = new UI.LogPage();
        }
    }
}
