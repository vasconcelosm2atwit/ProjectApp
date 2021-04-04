using System;

namespace ConferenceProjectWPF
{
    class Speaker
    {
        private int id;
        private String name;
        private string email;
        private string phone_number;


        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string PhoneNumber { get { return phone_number; } set { phone_number = value; } }
    }
}
