using System.Collections.Generic;
using System.Windows;

namespace WpfTutorialSamples.ListView_control
{
    /// <summary>
    /// Interaction logic for ListViewItemTemplateSample.xaml
    /// </summary>
    public partial class ListViewItemTemplateSample : Window
    {
        public ListViewItemTemplateSample()
        {
            InitializeComponent();
            List<User> items = new List<User>();
            items.Add(new User() { Name = "John Doe", Age = 42, Mail = "john@doe-family.com" });
            items.Add(new User() { Name = "Jane Doe", Age = 39, Mail = "jane@doe-family.com" });
            items.Add(new User() { Name = "Sammy Doe", Age = 13, Mail = "sammy.doe@gmail.com" });
            lvDataBinding.ItemsSource = items;
        }
    }    
}
