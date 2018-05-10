using System.ComponentModel;

namespace TutorialSamplesMVVM.ChangeNotificationSample.Model
{
    class User : INotifyPropertyChanged
    {
        private string name;
        public string Name
        {
            get { return this.name; }
            set
            {
                if (this.name != value)
                {
                    this.name = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
       
        public void RaisePropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
       
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
