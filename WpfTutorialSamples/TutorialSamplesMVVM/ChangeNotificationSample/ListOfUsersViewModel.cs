using System.Collections.ObjectModel;
using TutorialSamplesMVVM.ChangeNotificationSample.Data;

namespace TutorialSamplesMVVM.ChangeNotificationSample
{
    class ListOfUsersViewModel
    {
        public ObservableCollection<User> users { get; set; }

        public ListOfUsersViewModel()
        {
            users = new ObservableCollection<User>();
        }        

        public ObservableCollection<User> AddUser(string userName)
        {
            users.Add(new User() { Name = userName });

            return users;
        }

        public ObservableCollection<User> ChangeUser(string userToChange, string userName)
        {
            var userIndex = users.IndexOf(new User() { Name = userToChange });
            if(userIndex >= 0) { 
                users.Insert(userIndex, new User { Name = userName });
            }

            return users;
        }

        public ObservableCollection<User> DeleteUser(string userToDelete)
        {
            var userIndex = users.IndexOf(new User() { Name = userToDelete });
            if (userIndex >= 0)
            {
                users.RemoveAt(userIndex);
            }

            return users;
        }

    }
}
