using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ConferenceProjectWPF
{
    class SpeakerViewModel : Model
    {
        public ObservableCollection<Speaker> Speakers{ get; set; }
        SpeakerDatabaseManager db;

        public Speaker SelectedItem { get; set; }

        public SpeakerViewModel()
        {
            db = new SpeakerDatabaseManager();
            this.Speakers = new ObservableCollection<Speaker>(db.retrieveSpeakers());
        }

        public void EditList(string newEmail, string newName, string newPhoneNumber)
        {
            this.SelectedItem.Email = newEmail;
            this.SelectedItem.Name = newName;
            this.SelectedItem.PhoneNumber = newPhoneNumber;
        }
        public void DeleteItem()
        {
            db.deleteSpeaker(this.SelectedItem);
            Speakers.Remove(this.SelectedItem);
        }

        public void CreateSpeaker(Speaker speaker)
        {
            Speakers.Add(speaker);
            db.addSpeaker(speaker);

        }
        public bool AlreadyExist(Speaker speaker)
        {
            foreach (Speaker t in Speakers)
            {
                if (t.Email == speaker.Email && t.Name == speaker.Name && t.PhoneNumber == speaker.PhoneNumber)
                {
                    return true;
                }
            }

            return false;

        }

        public bool checkForDuplicates()
        {
            List<Speaker> copy = new List<Speaker>(Speakers);

            var dups = copy.GroupBy(i => new { i.Email, i.Name, i.PhoneNumber }).Select(g => new
            {
                Length = g.Key.Email,
                Label = g.Key.Name,
                ph = g.Key.PhoneNumber,
                Count = g.Count()
            }).Where(g => g.Count > 1);

            //Console.WriteLine(dups.Any());

            return dups.Any();
        }
    }
}
