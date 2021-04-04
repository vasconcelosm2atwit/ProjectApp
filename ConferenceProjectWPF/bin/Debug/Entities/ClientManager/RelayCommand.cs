using System;
using System.Windows.Input;

namespace ConferenceProjectWPF
{
    // basic command to run the action
    class RelayCommand : ICommand
    {
        private Action mAction;
        // the event that is fired when value has changed
        public event EventHandler CanExecuteChanged = (sender, e) => { };

        public RelayCommand(Action action )
        {
            mAction = action;
        }

        // this says a button can do it, this says it can always execute
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            mAction();
        }
    }
}
