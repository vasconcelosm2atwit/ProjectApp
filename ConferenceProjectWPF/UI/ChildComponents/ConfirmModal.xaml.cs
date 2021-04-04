using ConferenceProjectWPF.Entities;
using System;
using ConferenceProjectWPF;
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
using System.Windows.Shapes;

namespace ConferenceProjectWPF.UI.ChildComponents
{
    /// <summary>
    /// Interaction logic for ConfirmModal.xaml
    /// </summary>
    public partial class ConfirmModal : Window
    {

        String oldStartTime; // Holds current start time
        String oldEndTime; // Holds current End time
        public ConfirmModal()
        {
            InitializeComponent();

            
            


        }



        private void confirm_clicked(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }

        private void cancel_clicked(object sender, RoutedEventArgs e)
        {
            BaseViewModel bs = (BaseViewModel)this.DataContext;
            bs.EditList(oldStartTime, oldEndTime); // Puts the old time back
            CollectionViewSource.GetDefaultView(bs.Items).Refresh(); //Refresh current List
            this.Close();
        }

        private void TestLoad(object sender, RoutedEventArgs e)
        {
            BaseViewModel bs = (BaseViewModel)this.DataContext;
            oldStartTime = bs.SelectedTimeslot.Start_time;
            oldEndTime = bs.SelectedTimeslot.End_time;
        }
    }
}
