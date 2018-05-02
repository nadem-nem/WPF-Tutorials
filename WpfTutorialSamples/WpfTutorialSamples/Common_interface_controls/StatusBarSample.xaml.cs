using System.Windows;

namespace WpfTutorialSamples.Common_interface_controls
{
    /// <summary>
    /// Interaction logic for StatusBarSample.xaml
    /// </summary>
    public partial class StatusBarSample : Window
    {
        public StatusBarSample()
        {
            InitializeComponent();
        }

        private void txtEditor_SelectionChanged(object sender, RoutedEventArgs e)
        {

            int row = txtEditor.GetLineIndexFromCharacterIndex(txtEditor.CaretIndex);
            int col = txtEditor.CaretIndex - txtEditor.GetCharacterIndexFromLineIndex(row);
            lblCursorPosition.Text = "Line " + (row + 1) + ", Char " + (col + 1);
        }
    }
}
