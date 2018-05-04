using System.Speech.Synthesis;
using System.Windows;

namespace WpfTutorialSamples.Audio_and_Video
{
    /// <summary>
    /// Interaction logic for SpeechSynthesisSample.xaml
    /// </summary>
    public partial class SpeechSynthesisSample : Window
    {
        public SpeechSynthesisSample()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, RoutedEventArgs e)
        {
            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.Speak("Hello, world!");
        }
    }
}
