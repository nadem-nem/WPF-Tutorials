using System.Collections.ObjectModel;
using System.Windows;
using TutorialSamplesMVVM.ChangeNotificationSample.Data;

namespace TutorialSamplesMVVM.ChangeNotificationSample
{
    /// <summary>
    /// Interaction logic for ChangeNotificationSample.xaml
    /// </summary>
    public partial class ChangeNotificationSample : Window
    {
        ListOfUsersViewModel usersViewModel;
        
        public ChangeNotificationSample()
        {
            InitializeComponent();

            usersViewModel = new ListOfUsersViewModel();

            usersViewModel.users.Add(new User() { Name = "John Doe" });
            usersViewModel.users.Add(new User() { Name = "Jane Doe" });

            lbUsers.ItemsSource = usersViewModel.users;
        }

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            usersViewModel.AddUser("New user");
        }

        private void btnChangeUser_Click(object sender, RoutedEventArgs e)
        {
            int userIndex = 0;
            if (lbUsers.SelectedItem != null) {
                userIndex = usersViewModel.users.IndexOf(lbUsers.SelectedItem as User);
                usersViewModel.users.RemoveAt(userIndex);
                usersViewModel.users.Insert(userIndex, new User() { Name = "Random Name" });                
            }
        }

        private void btnDeleteUser_Click(object sender, RoutedEventArgs e)
        {
            if (lbUsers.SelectedItem != null)
                usersViewModel.users.Remove(lbUsers.SelectedItem as User);
        }
    }
}
