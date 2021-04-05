using ConferenceProjectWPF;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace ConferenceProjectWPF.UI
{
    /// <summary>
    /// Interaction logic for RoomPage.xaml
    /// </summary>
    public partial class RoomPage : Page
    {
        string holdName;
        int holdCapacity;
        RoomViewModel roomViewModel = new RoomViewModel();
        public RoomPage()
        {
            InitializeComponent();
            this.DataContext = roomViewModel;
        }

        // Add new Room
        private void Button_open_edit(object sender, RoutedEventArgs e)
        {
           
            holdName = roomViewModel.SelectedItem.Name;
            holdCapacity = roomViewModel.SelectedItem.Capacity;

            MyDialogHost.IsOpen = true;
        }

        private void Button_confirm_edit(object sender, RoutedEventArgs e)
        {
            
           
            
            if (roomViewModel.SelectedItem.Name.Length != 0)
            {

                if (roomViewModel.checkForDuplicates())
                {
                    roomViewModel.SelectedItem.Name = holdName;
                    roomViewModel.SelectedItem.Capacity = holdCapacity;
                    CollectionViewSource.GetDefaultView(roomViewModel.Rooms).Refresh(); //Refresh current List
                    MessageBox.Show(NameTextBox.Text + " Already Exists");
                    NameTextBox.Text = holdName;
                    MyDialogHost.IsOpen = true;
                    return;


                }

                
                if (CapacityTextBox.Text.Length != 0)
                {
                    int x;
                    bool isNumeric = int.TryParse(CapacityTextBox.Text, out x);
                    int newCapacity = isNumeric ? Int16.Parse(CapacityTextBox.Text) : -1;
                    bool acceptableRange = newCapacity > -1 && newCapacity < 501;

                    if(isNumeric && acceptableRange)
                    {
                        roomViewModel.updateRoom(roomViewModel.SelectedItem);
                        MyDialogHost.IsOpen = false;
                        return;
                    }
                    else
                    {
                        roomViewModel.SelectedItem.Capacity = holdCapacity;
                        MessageBox.Show("Capacity must be a number between 0 and 500");
                    }
                }
                else
                {
                    roomViewModel.updateRoom(roomViewModel.SelectedItem);
                    MyDialogHost.IsOpen = false;
                }

              
            }
            else
            {
                
                MessageBox.Show("Fields cannot be empty");
                
            }
        }

        private void Button_cancel_edit(object sender, RoutedEventArgs e)
        {
            roomViewModel.SelectedItem.Name = holdName;
            roomViewModel.SelectedItem.Capacity = holdCapacity;
           
            CollectionViewSource.GetDefaultView(roomViewModel.Rooms).Refresh(); //Refresh current List
            MyDialogHost.IsOpen = false;
        }

        private void Button_open_delete(object sender, RoutedEventArgs e)
        {

            deletePopUp.IsOpen = true;
        }

        private void Button_confirm_delete(object sender, RoutedEventArgs e)
        {

            if (roomViewModel.SelectedItem != null)
            {
                roomViewModel.DeleteItem();
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

        private void Button_open_createRoom(object sender, RoutedEventArgs e)
        {
            createDialogHost.IsOpen = true;

        }

        private void Button_confirm_creation(object sender, RoutedEventArgs e)
        {
            if (newNameTextBox.Text.Length != 0)
            {
                Room newRoom = new Room();
                newRoom.Name = newNameTextBox.Text;
                
                // check if name already exist
                if (roomViewModel.AlreadyExist(newRoom))
                {
                    MessageBox.Show(NameTextBox.Text + " Already Exists");
                    newNameTextBox.Text = "";
                    createDialogHost.IsOpen = true;
                    return;
                }

                // if there is a capacity
                if (newCapacityTextBox.Text.Length != 0)
                {
                    Console.WriteLine( "Capacity :" + newCapacityTextBox.Text.Length);
                    int x;
                    bool isNumeric = int.TryParse(newCapacityTextBox.Text, out x);
                    int newCapacity = isNumeric ? Int16.Parse(newCapacityTextBox.Text) : -1;
                    bool acceptableRange = newCapacity > -1 && newCapacity < 501;

                    if (isNumeric && acceptableRange)
                    {
                        newRoom.Capacity = newCapacity;
                        roomViewModel.CreateRoom(newRoom);
                        createDialogHost.IsOpen = false;
                        return;
                    }
                    else
                    {
                        newCapacityTextBox.Text = "";
                        MessageBox.Show("Capacity must be a number between 0 and 500");
                    }
                }
                else
                {
                    roomViewModel.CreateRoom(newRoom);
                    createDialogHost.IsOpen = false;
                }


            }
            else
            {

                MessageBox.Show("Fields cannot be empty");

            }

        }

        private void Button_cancel_creation(object sender, RoutedEventArgs e)
        {
            createDialogHost.IsOpen = false;
        }
    }
}
