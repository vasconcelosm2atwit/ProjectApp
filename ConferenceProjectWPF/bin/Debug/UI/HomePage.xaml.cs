using ConferenceProjectWPF.Controllers;
using ConferenceProjectWPF.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        private readonly ViewModel viewModel;
        public HomePage()
        {
            InitializeComponent();
            RoomsDatabaseManager db = new RoomsDatabaseManager();
            this.viewModel = new ViewModel
            {
                allRooms = new List<Room>(db.RetrieveRooms())
            };

            this.DataContext = this.viewModel;



        }
        

        private void homePageTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
