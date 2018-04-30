using System.Windows;

namespace TutorialSamplesMVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            TutorialSamplesMVVM.ChangeNotificationSample.ChangeNotificationSample wnd = new ChangeNotificationSample.ChangeNotificationSample();
            wnd.Show();
        }
       
    }
}
