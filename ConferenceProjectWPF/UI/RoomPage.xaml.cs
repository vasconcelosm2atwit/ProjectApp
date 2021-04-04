using ConferenceProjectWPF.Controllers;
using ConferenceProjectWPF.Entities;
using ConferenceProjectWPF;
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
