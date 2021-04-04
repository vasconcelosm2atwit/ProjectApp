using ConferenceProjectWPF;
using System;
using System.Windows;
using System.Windows.Controls;

namespace ConferenceProjectWPF.UI
{
    /// <summary>
    /// Interaction logic for RoomPage.xaml
    /// </summary>
    public partial class RoomPage : Page
    {

        public RoomPage()
        {
            InitializeComponent();
        }

        // Add new Room
        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            Room newRoom = new Room();
            RoomsDatabaseManager db = new RoomsDatabaseManager();
            
            newRoom.Name = textBoxRmName.Text;
            newRoom.Capacity = Int16.Parse(textBoxRmCapacity.Text);

            db.addRoom(newRoom);
        }
    }
}
