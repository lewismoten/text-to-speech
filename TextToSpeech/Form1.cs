using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using SpeechLib;
using System.Speech;
using System.Speech.Synthesis;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Diagnostics;
using System.IO;

namespace TextToSpeech
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer Synthesizer = new SpeechSynthesizer();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadOnlyCollection<InstalledVoice> voices = Synthesizer.GetInstalledVoices();
            foreach (InstalledVoice voice in voices)
            {
                this.VoiceComboBox.Items.Add(voice.VoiceInfo.Name);
            }

            this.VoiceComboBox.SelectedIndex = 0;

            Synthesizer.StateChanged += new EventHandler<StateChangedEventArgs>(Synthesizer_StateChanged);

            saveFileDialog1.AddExtension = true;
            saveFileDialog1.DefaultExt = "wav";
            saveFileDialog1.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            saveFileDialog1.Filter = "WAV Sound Files (*.wav)|*.wav";

        }

        void Synthesizer_StateChanged(object sender, StateChangedEventArgs e)
        {
            if (e.State == SynthesizerState.Ready)
            {
                this.StartStopButton.Text = "&Speak";
                this.PauseResumeButton.Text = "&Pause";
                this.PauseResumeButton.Enabled = false;
                this.SaveButton.Enabled = true;
                Synthesizer.SetOutputToDefaultAudioDevice();
            }
            else if (e.State == SynthesizerState.Paused)
            {
                this.PauseResumeButton.Text = "&Resume";
            }
            else if (e.State == SynthesizerState.Speaking)
            {
                this.StartStopButton.Text = "&Stop";
                this.PauseResumeButton.Text = "&Pause";
                this.PauseResumeButton.Enabled = true;
                this.SaveButton.Enabled = false;
            }
        }

        private void VoiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Synthesizer.SelectVoice(this.VoiceComboBox.Text);
        }

        private void SpeedTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Synthesizer.Rate = SpeedTrackBar.Value;
        }

        private void StartStopButton_Click(object sender, EventArgs e)
        {
            if (Synthesizer.State == SynthesizerState.Speaking)
            {
                Synthesizer.SpeakAsyncCancelAll();
            }
            else
            {
                Synthesizer.SpeakAsync(TextTextBox.Text);
            }
        }

        private void PauseResumeButton_Click(object sender, EventArgs e)
        {
            if (Synthesizer.State == SynthesizerState.Paused)
            {
                Synthesizer.Resume();
            }
            else
            {
                Synthesizer.Pause();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            Synthesizer.SetOutputToWaveFile(saveFileDialog1.FileName);
            Synthesizer.SpeakAsync(TextTextBox.Text);
        }


    }
}
