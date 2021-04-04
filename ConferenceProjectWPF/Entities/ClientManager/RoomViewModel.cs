using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ConferenceProjectWPF
{
    class RoomViewModel : Model
    {
        public ObservableCollection<Room> Rooms { get; set; }
        RoomsDatabaseManager db;
        public Room SelectedItem { get; set; }



        public RoomViewModel()
        {
            db = new RoomsDatabaseManager();
            this.Rooms = new ObservableCollection<Room>(db.RetrieveRooms());
        }

        public void DeleteItem()
        {
            db.deleteRoom(this.SelectedItem);
            Rooms.Remove(this.SelectedItem);
        }

        public void CreateTimeSlot(Room room)
        {
            Rooms.Add(room);
            db.addRoom(room);

        }

        public bool AlreadyExist(Room room)
        {
            foreach (Room t in Rooms)
            {
                if (t.Capacity == room.Capacity && t.Name == room.Name)
                {
                    return true;
                }
            }

            return false;

        }

        public bool checkForDuplicates()
        {
            List<Room> copy = new List<Room>(Rooms);

            var dups = copy.GroupBy(i => new { i.Capacity, i.Name }).Select(g => new
            {
                Length = g.Key.Capacity,
                Label = g.Key.Name,
                Count = g.Count()
            }).Where(g => g.Count > 1);

            //Console.WriteLine(dups.Any());

            return dups.Any();
        }
    }
}
