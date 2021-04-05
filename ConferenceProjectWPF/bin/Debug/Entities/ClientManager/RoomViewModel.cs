using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Data;

namespace ConferenceProjectWPF
{
    class RoomViewModel : Model
    {
        public ObservableCollection<Room> Rooms { get; set; }

        readonly RoomsDatabaseManager db;
        public ICollectionView RoomsCollection { get; set; }
        public Room SelectedItem { get; set; }

        private string _roomFilter = string.Empty;

        public string RoomFilter
        {
            get
            {
                return _roomFilter;
            }
            set
            {
                _roomFilter = value;
                onPropertyChanged(nameof(RoomFilter));
                RoomsCollection.Refresh();
            }
        }



        public RoomViewModel()
        {
            db = new RoomsDatabaseManager();
            this.Rooms = new ObservableCollection<Room>(db.RetrieveRooms());
            this.RoomsCollection = CollectionViewSource.GetDefaultView(this.Rooms);

            RoomsCollection.Filter = FilterRooms;
        }

        public bool updateRoom(Room room)
        {
            bool isError = false;
            try
            {
                db.updateRoom(room);
            }
            catch (Exception ex)
            {
                isError = true;
                Console.WriteLine(ex);
                Console.WriteLine("Failed to update the Database ---  check error ABOVE");
            }
            return isError;
        }

        public bool DeleteItem()
        {

            bool isError = false;
            try
            {
                db.deleteRoom(this.SelectedItem);
            }
            catch (Exception ex)
            {
                isError = true;
                Console.WriteLine(ex);
                Console.WriteLine("Failed to update the Database ---  check error ABOVE");
            }
            Rooms.Remove(this.SelectedItem);
            return isError;

        }

        public bool CreateRoom(Room room)
        {
            Rooms.Add(room);
            bool isError = false;
            try
            {
                db.addRoom(room);
            }
            catch (Exception ex)
            {
                isError = true;
                Console.WriteLine(ex);
                Console.WriteLine("Failed to update the Database ---  check error ABOVE");
            }
            return isError;

        }

        private bool FilterRooms(object obj)
        {
            if (obj is Room room)
            {
                return room.Name.ToUpper().Contains(RoomFilter.ToUpper());
            }
            return false;
        }

        public bool AlreadyExist(Room room)
        {
            foreach (Room t in Rooms)
            {
                if (t.Name.ToUpper() == room.Name.ToUpper())
                {
                    return true;
                }
            }

            return false;

        }

        public bool checkForDuplicates()
        {
            List<Room> copy = new List<Room>(Rooms);
            List<Room> newList = copy.ConvertAll(room => new Room(room.Name));
            List<string> allUppers = new List<string>();
            foreach (Room a in newList)
            {
                allUppers.Add(a.Name.ToUpper());
            }


            var dups = allUppers.GroupBy(i => new { i }).Select(g => new
            {

                Label = g.Key,
                Count = g.Count()
            }).Where(g => g.Count > 1);


            return dups.Any();
        }


    }
}
