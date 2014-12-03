
using System.Windows.Input;				// ICommand
using Microsoft.TeamFoundation.MVVM;    // ViewModelBase

namespace WindowChrome_sample
{
    public partial class MainViewModel : ViewModelBase
    {





        private ICommand _MinimizeCommand;
        public ICommand MinimizeCommand
        {
            get
            {
                if (_MinimizeCommand == null)
                {
                    _MinimizeCommand = new RelayCommand(ExecuteMinimizeCommand);
                }
                return _MinimizeCommand;
            }
        }
        private ICommand _CloseCommand;
        public ICommand CloseCommand
        {
            get
            {
                if (_CloseCommand == null)
                {
                    _CloseCommand = new RelayCommand(ExecuteCloseCommand);
                }
                return _CloseCommand;
            }
        }

        private ICommand _MaximizeCommand;
        public ICommand MaximizeCommand
        {
            get
            {
                if (_MaximizeCommand == null)
                {
                    _MaximizeCommand = new RelayCommand(ExecuteMaximizeCommand, CanExecuteMaximizeCommand);
                }
                return _MaximizeCommand;
            }
        }
        private ICommand _RestoreCommand;
        public ICommand RestoreCommand
        {
            get
            {
                if (_RestoreCommand == null)
                {
                    _RestoreCommand = new RelayCommand(ExecuteRestoreCommand, CanExecuteRestoreCommand);
                }
                return _RestoreCommand;
            }
        }

    }
}