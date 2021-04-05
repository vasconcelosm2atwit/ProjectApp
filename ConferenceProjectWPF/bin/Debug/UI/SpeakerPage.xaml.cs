using ConferenceProjectWPF;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

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
            if (NameTextBox.Text.Length != 0)
            {

                if (speakerViewModel.checkForDuplicates())
                {
                    speakerViewModel.SelectedItem.Name = holdName;
                    speakerViewModel.SelectedItem.Email = holdEmail;
                    speakerViewModel.SelectedItem.PhoneNumber = holdPhoneNumber;
                    CollectionViewSource.GetDefaultView(speakerViewModel.Speakers).Refresh(); //Refresh current List
                    MessageBox.Show(NameTextBox.Text + " Already Exists");
                    NameTextBox.Text = holdName;
                    MyDialogHost.IsOpen = true;
                    return;
                }

                if (PhoneTextBox.Text.Length != 0 && speakerViewModel.ValidatePhoneNumber(PhoneTextBox.Text, false))
                {

                    string pN = speakerViewModel.RemoveNonNumeric(PhoneTextBox.Text);
                    string fixedNumber = speakerViewModel.formartPhoneNumber(pN);

                    speakerViewModel.SelectedItem.PhoneNumber = fixedNumber;
                }

                if (PhoneTextBox.Text.Length != 0 && !speakerViewModel.ValidatePhoneNumber(PhoneTextBox.Text, false))
                {
                    PhoneTextBox.Text = "";
                    MessageBox.Show("Phone Number Invalid");
                    return;

                }

                if (EmailTextBox.Text.Length != 0)
                {
                    if (!speakerViewModel.IsEmailValid(EmailTextBox.Text))
                    {
                        EmailTextBox.Text = "";
                        MessageBox.Show("Invalid Email");
                        return;
                    }
                    else
                    {
                        speakerViewModel.SelectedItem.Email = EmailTextBox.Text;
                    }
                }
                bool failedDelivery = speakerViewModel.EditSpeaker(speakerViewModel.SelectedItem);
                MyDialogHost.IsOpen = false;

                if (failedDelivery)
                    MessageBox.Show("Error sending to the DB, check Console for log");
            }
            else
            {
                MessageBox.Show("A name is required to create a speaker");
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
            
            if(newNameTextBox.Text.Length != 0)
            {
                Speaker newSpeaker = new Speaker();
                newSpeaker.Name = newNameTextBox.Text;

                if (speakerViewModel.AlreadyExist(newSpeaker))
                {
                    MessageBox.Show(NameTextBox.Text + " Already Exists");
                    newNameTextBox.Text = "";
                    createDialogHost.IsOpen = true;
                    return;
                }

                if (newPhoneTextBox.Text.Length != 0 && speakerViewModel.ValidatePhoneNumber(newPhoneTextBox.Text, false))
                { 

                    string pN = speakerViewModel.RemoveNonNumeric(newPhoneTextBox.Text);
                    string fixedNumber = speakerViewModel.formartPhoneNumber(pN);

                    newSpeaker.PhoneNumber = fixedNumber;
                }
                
                if(newPhoneTextBox.Text.Length != 0 && !speakerViewModel.ValidatePhoneNumber(newPhoneTextBox.Text, false))
                {
                    newPhoneTextBox.Text = "";
                    MessageBox.Show("Phone Number Invalid");
                    return;

                }
                
                if(newEmailTextBox.Text.Length != 0)
                {
                    if (!speakerViewModel.IsEmailValid(newEmailTextBox.Text))
                    {
                        newEmailTextBox.Text = "";
                        MessageBox.Show("Invalid Email");
                        return;
                    }
                    else
                    {
                        newSpeaker.Email = newEmailTextBox.Text;
                    }
                }
               
                speakerViewModel.CreateSpeaker(newSpeaker);
                createDialogHost.IsOpen = false;
            }
            else
            {
                MessageBox.Show("A name is required to create a speaker");
            }

            newNameTextBox.Text = "";
            newPhoneTextBox.Text = "";
            newEmailTextBox.Text = "";
          
        }

        private void Button_cancel_creation(object sender, RoutedEventArgs e)
        {
            createDialogHost.IsOpen = false;
        }
        


        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void HandleCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

            if (e.Command == ApplicationCommands.Cut ||
     
                 e.Command == ApplicationCommands.Paste)
            {

                e.CanExecute = false;
                e.Handled = true;

            }

        }








    }
}
