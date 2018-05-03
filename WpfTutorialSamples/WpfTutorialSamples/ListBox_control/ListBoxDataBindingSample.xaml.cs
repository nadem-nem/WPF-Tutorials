using System.Collections.Generic;
using System.Windows;

namespace WpfTutorialSamples.ListBox_control
{
    /// <summary>
    /// Interaction logic for ListBoxDataBindingSample.xaml
    /// </summary>
    public partial class ListBoxDataBindingSample : Window
    {
        public ListBoxDataBindingSample()
        {
            InitializeComponent();
            List<TodoItem> items = new List<TodoItem>
            {
                new TodoItem() { Title = "Complete this WPF tutorial", Completion = 45 },
                new TodoItem() { Title = "Learn C#", Completion = 80 },
                new TodoItem() { Title = "Wash the car", Completion = 0 }
            };

            lbTodoList.ItemsSource = items;
        }
    }

    public class TodoItem
    {
        public string Title { get; set; }
        public int Completion { get; set; }
    }
}
