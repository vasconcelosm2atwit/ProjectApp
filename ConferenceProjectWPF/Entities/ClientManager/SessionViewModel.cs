using System;
using System.Collections.ObjectModel;

namespace ConferenceProjectWPF
{
    class SessionViewModel : Model
    {
        public ObservableCollection<Session> SpeakerItems { get; set; }

        public Session SelectedSpeaker { get; set; }

    }
}
