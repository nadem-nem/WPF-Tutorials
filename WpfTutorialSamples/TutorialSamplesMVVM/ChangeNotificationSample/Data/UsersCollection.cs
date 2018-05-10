using System.Collections.ObjectModel;
using TutorialSamplesMVVM.ChangeNotificationSample.Model;

namespace TutorialSamplesMVVM.ChangeNotificationSample.Data
{
    class UsersCollection
    {
        public static ObservableCollection<User> GetPeopleFromDatabase()
        {
            //Simulate database extaction
            //For example from ADO DataSets or EF
            return new ObservableCollection<User>
            {
                 new User() { Name = "John Doe" },
                 new User() { Name = "Jane Doe" }
            };
        }
    }
}
