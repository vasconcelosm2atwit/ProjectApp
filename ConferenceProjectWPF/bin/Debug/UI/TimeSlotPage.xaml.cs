using ConferenceProjectWPF.Controllers;
using ConferenceProjectWPF.Entities;
using ConferenceProjectWPF.UI.ChildComponents;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;


namespace ConferenceProjectWPF.UI
{
    /// <summary>
    /// Interaction logic for TimeSlotPage.xaml
    /// </summary>
    public partial class TimeSlotPage : Page
    {
         //ObservableCollection<TimeSlot> tsList = new ObservableCollection<TimeSlot>();
        private readonly ViewModel viewModel;
        TimeSlotsDatabaseManager db = new TimeSlotsDatabaseManager();
        BaseViewModel baseViewModel;
        public TimeSlotPage()
        {
            InitializeComponent();
            
            this.viewModel = new ViewModel
            {
                timeSlots = new ObservableCollection<TimeSlot>(db.retrieveTimeSlots())
            };



            // this.DataContext = this.viewModel;
            baseViewModel = new BaseViewModel();
            this.DataContext = baseViewModel;

           



        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            
            
            
            TimeSlot t = this.viewModel.SelectedTimeslot;
            // this.viewModel.timeSlots.beginEdit();
            ConfirmModal confirmModal = new ConfirmModal();
            confirmModal.DataContext = baseViewModel;
            confirmModal.Show();


            /// MessageBox.Show(t.Start_time.ToString());
            foreach (TimeSlot i in this.viewModel.timeSlots)
            {
                Console.WriteLine(i.Start_time.ToString());
            }

            //timeSlotTable.BeginEdit();
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            // if (this.viewModel.SelectedTimeslot == null)
            // {
            //     return;
            //  }

            // TimeSlot t = this.viewModel.SelectedTimeslot;


            //  MessageBox.Show("Removing " + t.ToString());
            //  this.viewModel.timeSlots.Remove(t);
            // db.deleteTimeSlot(t);
            //  this.DataContext = this.viewModel;

            baseViewModel.Items.Remove(baseViewModel.SelectedTimeslot);


        }


    }
}
