using ConferenceProjectWPF;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace ConferenceProjectWPF.UI
{
    /// <summary>
    /// Interaction logic for TimeSlotPage.xaml
    /// </summary>
    public partial class SpeakerPage : Page
    {

        string holdEmail;
        string holdName;
        string holdPhoneNumber;
        SpeakerViewModel speakerViewModel = new SpeakerViewModel();
       // TimeSlotsDatabaseManager ts = new TimeSlotsDatabaseManager();
        public SpeakerPage()
        {
            InitializeComponent();

            // name, email and phone number


            this.DataContext = speakerViewModel;




        }

        private void Button_open_edit(object sender, RoutedEventArgs e)
        {
            holdEmail = speakerViewModel.SelectedItem.Email;
            holdName = speakerViewModel.SelectedItem.Name;
            holdPhoneNumber = speakerViewModel.SelectedItem.PhoneNumber;

            MyDialogHost.IsOpen = true;
        }

        private void Button_confirm_edit(object sender, RoutedEventArgs e)
        {

            if (true)
            {
                if (speakerViewModel.checkForDuplicates())
                {
                    speakerViewModel.SelectedItem.Name = holdName;
                    speakerViewModel.SelectedItem.Email = holdEmail;
                    speakerViewModel.SelectedItem.PhoneNumber = holdPhoneNumber;
                    CollectionViewSource.GetDefaultView(speakerViewModel.Speakers).Refresh(); //Refresh current List
                    MessageBox.Show("You tried creating a duplicated");
                }

                MyDialogHost.IsOpen = false;
            }
            else
            {
                MessageBox.Show("Fields cannot be empty");
            }
        }

        private void Button_cancel_edit(object sender, RoutedEventArgs e)
        {
            speakerViewModel.SelectedItem.Name = holdName;
            speakerViewModel.SelectedItem.Email = holdEmail;
            speakerViewModel.SelectedItem.PhoneNumber = holdPhoneNumber;
            CollectionViewSource.GetDefaultView(speakerViewModel.Speakers).Refresh(); //Refresh current List
            MyDialogHost.IsOpen = false;
        }

        private void Button_open_delete(object sender, RoutedEventArgs e)
        {

            deletePopUp.IsOpen = true;
        }

        private void Button_confirm_delete(object sender, RoutedEventArgs e)
        {

            if (speakerViewModel.SelectedItem != null)
            {
                speakerViewModel.DeleteItem();
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
            if(newNameTextBox != null)
            {
                Speaker newSpeaker = new Speaker();
                newSpeaker.Name = newNameTextBox.Text;
                newSpeaker.PhoneNumber = newPhoneTextBox.Text;
                newSpeaker.Email = newEmailTextBox.Text;

                speakerViewModel.CreateSpeaker(newSpeaker);
                createDialogHost.IsOpen = false;
            }
            else
            {
                MessageBox.Show("A name is required to create a speaker");
            }
          
        }

        private void Button_cancel_creation(object sender, RoutedEventArgs e)
        {
            createDialogHost.IsOpen = false;
        }
        




    


    }
}
