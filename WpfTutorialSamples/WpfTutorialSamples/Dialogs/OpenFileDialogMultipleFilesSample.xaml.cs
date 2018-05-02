using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;


namespace WpfTutorialSamples.Dialogs
{
    /// <summary>
    /// Interaction logic for OpenFileDialogMultipleFilesSample.xaml
    /// </summary>
    public partial class OpenFileDialogMultipleFilesSample : Window
    {
        public OpenFileDialogMultipleFilesSample()
        {
            InitializeComponent();
        }

        private void btnOpenFiles_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog.ShowDialog() == true)
            {
                foreach (string filename in openFileDialog.FileNames)
                    lbFiles.Items.Add(Path.GetFileName(filename));
            }
        }
    }
}
