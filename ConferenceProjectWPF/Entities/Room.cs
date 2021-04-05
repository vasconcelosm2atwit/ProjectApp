using System;


namespace ConferenceProjectWPF
{
    
    class Room 
    {
        private int id;
        private String name;
        private int capacity;


        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int Capacity { get { return capacity; } set { capacity = value; } }

        public Room()
        {

        }
        public Room(string name)
        {
            this.Name = name;
        }
       
        

       
    }
}
