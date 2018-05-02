using System.Windows;

namespace WpfTutorialSamples.Rich_text_controls
{
    /// <summary>
    /// Interaction logic for FlowDocumentSearchSample.xaml
    /// </summary>
    public partial class FlowDocumentSearchSample : Window
    {
        public FlowDocumentSearchSample()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            fdViewer.Find();
        }
    }
}
