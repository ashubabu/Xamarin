using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace MasterDetail
{
    public class MainPageViewModel
    {
        ICommand _navigateCommand;
        INavigation _navigation;
        public MainPageViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }
        public ICommand NavigateCommand
        {
            get {
                return _navigateCommand ??
                  (_navigateCommand = new NavigateCommandHandler(
                                      async () => {  await _navigation.PushAsync(new View2()); }, true));
                    }
        }
        
    }

    public class NavigateCommandHandler : ICommand
    {
        public event EventHandler CanExecuteChanged;
        bool _canExecute;
        Action _action;
        public NavigateCommandHandler(Action action, bool canExecute)
        {
            _action = action;
            _canExecute = canExecute;
        }
        public bool CanExecute(object parameter)
        {
            return _canExecute;
        }

        public void Execute(object parameter)
        {
            _action();
        }
    }
}
