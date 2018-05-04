using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfTutorialSamples.Audio_and_Video
{
    /// <summary>
    /// Interaction logic for SpeechRecognitionTextCommandsSample.xaml
    /// </summary>
    public partial class SpeechRecognitionTextCommandsSample : Window
    {
        public SpeechRecognitionTextCommandsSample()
        {
            InitializeComponent();
            SpeechRecognizer recognizer = new SpeechRecognizer();
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            txtSpeech.Text = "";
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Command invoked: Open");
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Command invoked: Save");
        }
    }
}
