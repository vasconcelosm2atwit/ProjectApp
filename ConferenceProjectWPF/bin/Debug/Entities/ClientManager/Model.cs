
using System.ComponentModel;

namespace ConferenceProjectWPF
{
    /// <summary>
    /// CONTAINS THE INOTIFY PROPERTY CHANGED
    /// 
    /// SERVES AS AN INTERFACE FOR THE OTHER CLASSES TO USE PROPERTY CHANGED INTERFACE.
    /// 
    /// 
    /// </summary>
    class Model : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void onPropertyChanged(string info)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        
    }
}
