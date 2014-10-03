using NAudio.CoreAudioApi;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicrophonePassthrough
{
    public partial class Form1 : Form
    {
        private WaveIn waveIn;
        private WaveOut waveOut;
        private BufferedWaveProvider waveStream;

        private bool passthroughActive;

        public Form1()
        {
            InitializeComponent();
            this.passthroughActive = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!this.passthroughActive)
            {
                this.waveStream = new BufferedWaveProvider(new WaveFormat(64000, 1));
                //Debug.WriteLine(waveStream.BufferLength);
                //Debug.WriteLine(waveStream.BufferDuration);
                waveStream.BufferDuration = TimeSpan.FromSeconds(0.2);
                this.waveIn = new WaveIn();
                this.waveOut = new WaveOut();
                this.waveIn.WaveFormat = new WaveFormat(64000, 1);
                this.waveIn.BufferMilliseconds = 5;
                this.waveIn.DataAvailable += OnDataAvailable;
                ISampleProvider sampleProvider = new SampleChannel(this.waveStream);
                this.waveOut.Init(sampleProvider);
                this.waveIn.StartRecording();
                waveOut.Play();
                this.passthroughActive = true;
                passthroughToggleButton.Text = "Stop Passthrough";
            }
            else
            {
                this.waveIn.StopRecording();
                this.passthroughActive = false;
                passthroughToggleButton.Text = "Start Passthrough";
            }
        }

        void OnDataAvailable(object sender, WaveInEventArgs e)
        {
            if (this.InvokeRequired)
            {
                //Debug.WriteLine("Data Available");
                this.BeginInvoke(new EventHandler<WaveInEventArgs>(OnDataAvailable), sender, e);
            }
            else
            {
                //Debug.WriteLine("Flushing Data Available");
                waveStream.AddSamples(e.Buffer, 0, e.BytesRecorded);
            }
        }
    }
}
