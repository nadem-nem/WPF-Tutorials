using System.Collections.ObjectModel;
using TutorialSamplesMVVM.ChangeNotificationSample.Helpers;
using TutorialSamplesMVVM.ChangeNotificationSample.Model;

namespace TutorialSamplesMVVM.ChangeNotificationSample.ViewModel
{
    class ViewModelMain : ViewModelBase
    {
        public ObservableCollection<User> Users { get; set; }

        object _SelectedUser;

        public object SelectedUser
        {
            get
            {
                return _SelectedUser;
            }
            set
            {
                if (_SelectedUser != value)
                {
                    _SelectedUser = value;
                    RaisePropertyChanged("SelectedUser");
                }
            }
        }

        public RelayCommand AddUserCommand { get; set; }
        public RelayCommand ChangeUserCommand { get; set; }
        public RelayCommand DeleteUserCommand { get; set; }

        public ViewModelMain()
        {
            Users = new ObservableCollection<User>
            {
                new User { Name="Tom"},
                new User { Name="Dick" },
                new User { Name="Harry" },
            };

            AddUserCommand = new RelayCommand(AddUser);
            ChangeUserCommand = new RelayCommand(ChangeUser);
            DeleteUserCommand = new RelayCommand(DeleteUser);
        }

        void AddUser(object parameter)
        {
            Users.Add(new User() { Name = "New user" });
        }

        void ChangeUser(object parameter)
        {
            if (parameter != null)
                (parameter as User).Name = "Random Name";
        }

        void DeleteUser(object parameter)
        {
            if (parameter != null)
                Users.Remove(parameter as User);
        }
    }
}
