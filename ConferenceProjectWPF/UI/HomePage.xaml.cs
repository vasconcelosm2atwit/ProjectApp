using ConferenceProjectWPF;
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
        SessionViewModel sessionViewModel;
        public HomePage()
        {
            InitializeComponent();
            sessionViewModel = new SessionViewModel();
            this.DataContext = sessionViewModel;

            Card1.ItemsSource = sessionViewModel.Sessions;
            Card2.ItemsSource = sessionViewModel.Sessions;
            //Card3.ItemsSource = sessionViewModel.Sessions;

        }
        

        private void homePageTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
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
