using Microsoft.Win32;
using System.IO;
using System.Windows;

namespace WpfTutorialSamples.Dialogs
{
    /// <summary>
    /// Interaction logic for SaveFileDialogSample.xaml
    /// </summary>
    public partial class SaveFileDialogSample : Window
    {
        public SaveFileDialogSample()
        {
            InitializeComponent();
        }

        private void btnSaveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, txtEditor.Text);
        }
    }
}
