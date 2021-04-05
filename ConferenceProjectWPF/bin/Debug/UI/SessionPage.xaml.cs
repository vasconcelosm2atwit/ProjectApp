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
        string holdStart_time;
        string holdEnd_time;
        SessionViewModel sessionViewModel = new SessionViewModel();
     
        public SessionPage()
        {
            InitializeComponent();

            this.DataContext = sessionViewModel;
        }


        private void Button_open_edit(object sender, RoutedEventArgs e)
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

        private void Button_open_delete(object sender, RoutedEventArgs e)
        {

            deletePopUp.IsOpen = true;
        }

        private void Button_confirm_delete(object sender, RoutedEventArgs e)
        {

           
                deletePopUp.IsOpen = false;
            

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

            createDialogHost.IsOpen = false;
        }

        private void Button_cancel_creation(object sender, RoutedEventArgs e)
        {
            createDialogHost.IsOpen = false;
        }
    }
}
