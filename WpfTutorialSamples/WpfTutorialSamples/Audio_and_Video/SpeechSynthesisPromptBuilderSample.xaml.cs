﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
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
    /// Interaction logic for SpeechSynthesisPromptBuilderSample.xaml
    /// </summary>
    public partial class SpeechSynthesisPromptBuilderSample : Window
    {
        public SpeechSynthesisPromptBuilderSample()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, RoutedEventArgs e)
        {
            PromptBuilder promptBuilder = new PromptBuilder();
            promptBuilder.AppendText("Hello world");

            PromptStyle promptStyle = new PromptStyle();
            promptStyle.Volume = PromptVolume.Soft;
            promptStyle.Rate = PromptRate.Slow;
            promptBuilder.StartStyle(promptStyle);
            promptBuilder.AppendText("and hello to the universe too.");
            promptBuilder.EndStyle();

            promptBuilder.AppendText("On this day, ");
            promptBuilder.AppendTextWithHint(DateTime.Now.ToShortDateString(), SayAs.Date);

            promptBuilder.AppendText(", we're gathered here to learn");
            promptBuilder.AppendText("all", PromptEmphasis.Strong);
            promptBuilder.AppendText("about");
            promptBuilder.AppendTextWithHint("WPF", SayAs.SpellOut);

            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.Speak(promptBuilder);
        }
    }
}
