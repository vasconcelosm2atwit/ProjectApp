using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampApp
{
    class DatabaseManager
    {
        
        public void addRoom(Room new_room)
        {
            /*new_room = new Room();
            new_room.Name = "test";
            new_room.Capacity = 1;

            Console.WriteLine(new_room.Name + new_room.Capacity);*/
             
        }

        public void addTimeSlot(TimeSlots new_timeSlot)
        {

        }

        public void addSpeaker(Speaker new_speaker)
        {

        }

        public void addSession(Sessions new_session)
        {

        }

        public List<Room>retrieveAllRooms()
        {
            List<Room> rooms = new List<Room>();
            return rooms; 
        }

        public List<Speaker> retrieveAllSpeakers()
        {
            List<Speaker> speakers = new List<Speaker>();
            return speakers;
        }

        public List<TimeSlots> retrieveAllTimeSlots()
        {
            List<TimeSlots> timeSlots = new List<TimeSlots>();
            return timeSlots;
        }

        public List<Session> retrieveAllSessions()
        {
            List<Session> sessions = new List<Session>();
            return sessions;
        }
    }
}
