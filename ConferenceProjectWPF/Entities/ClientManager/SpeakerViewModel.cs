using PhoneNumbers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Data;

namespace ConferenceProjectWPF
{
    class SpeakerViewModel : Model
    {
        public ObservableCollection<Speaker> Speakers{ get; set; }
        public ICollectionView SpeakersCollection { get; set; }
        SpeakerDatabaseManager db;

        private string _speakerFilter = string.Empty;

        public string SpeakerFilter
        {
            get
            {
                return _speakerFilter;
            }
            set
            {
                _speakerFilter = value;
                onPropertyChanged(nameof(SpeakerFilter));
                SpeakersCollection.Refresh();
            }
        }

        public Speaker SelectedItem { get; set; }

        public SpeakerViewModel()
        {
            db = new SpeakerDatabaseManager();
            this.Speakers = new ObservableCollection<Speaker>(db.retrieveSpeakers());
            this.SpeakersCollection = CollectionViewSource.GetDefaultView(this.Speakers);

            SpeakersCollection.Filter = FilterSpeakers;
          
        }

        private bool FilterSpeakers(object obj)
        {
           if(obj is Speaker speaker)
            {
                return speaker.Name.ToUpper().Contains(SpeakerFilter.ToUpper());
            }
            return false;
        }


        public bool EditSpeaker(Speaker speaker)
        {
            bool catchError = false;
            try
            {
                db.updateSpeaker(speaker);
            }
            catch (Exception ex)
            {
                catchError = true;
                Console.WriteLine(ex);
                Console.WriteLine("Error sending to the database");
            }

            return catchError;
        }

        public bool DeleteItem()
        {
            bool isError = false;
            

            try
            {
                db.deleteSpeaker(this.SelectedItem);
            }
            catch(Exception ex)
            {
                isError = true;
                Console.WriteLine(ex);
                Console.WriteLine("Failed to update the Database ---  check error ABOVE");
            }
            Speakers.Remove(this.SelectedItem);
            return isError;
            
        }

        public bool CreateSpeaker(Speaker speaker)
        {
            bool isError = false;
            

            try
            {
                db.addSpeaker(speaker);
            }
            catch (Exception ex)
            {
                isError = true;
                Console.WriteLine(ex);
                Console.WriteLine("Failed to update the Database ---  check error ABOVE");
            }

            Speakers.Add(speaker);
            return isError;
        }
        public bool AlreadyExist(Speaker speaker)
        {
            foreach (Speaker t in Speakers)
            {
                if (t.Name.ToUpper() == speaker.Name.ToUpper())
                {
                    return true;
                }
            }

            return false;

        }

        public bool checkForDuplicates()
        {
            List<Speaker> copy = new List<Speaker>(Speakers);
            List<Speaker> newList = copy.ConvertAll(speaker => new Speaker(speaker.Name));
            List<string> allUppers = new List<string>();
            foreach (Speaker a in newList)
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

        public string formartPhoneNumber(string telNo)
        {
            return String.Format("{0:(###) ###-####}", double.Parse(telNo));  
        }

        // isRequired false = empty string returns true
        // isRequired true = empty string returns false
        public bool ValidatePhoneNumber(string phone, bool IsRequired)
        {
            if (string.IsNullOrEmpty(phone) & !IsRequired)
                return true;

            if (string.IsNullOrEmpty(phone) & IsRequired)
                return false;

            var cleaned = RemoveNonNumeric(phone);
            if (IsRequired)
            {
                if (cleaned.Length == 10)
                    return true;
                else
                    return false;
            }
            else
            {
                if (cleaned.Length == 0)
                    return true;
                else if (cleaned.Length > 0 & cleaned.Length < 10)
                    return false;
                else if (cleaned.Length == 10)
                    return true;
                else
                    return false; // should never get here
            }
        }

        /// <summary>
        /// Removes all non numeric characters from a string
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public string RemoveNonNumeric(string phone)
        {
            return Regex.Replace(phone, @"[^0-9]+", "");
        }

        static Regex ValidEmailRegex = CreateValidEmailRegex();

        private static Regex CreateValidEmailRegex()
        {
            string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(validEmailPattern, RegexOptions.IgnoreCase);
        }

        public bool IsEmailValid(string emailAddress)
        {
            bool isValid = ValidEmailRegex.IsMatch(emailAddress);

            return isValid;
        }



    }

}
